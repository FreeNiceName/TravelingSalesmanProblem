using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TSP;

namespace ShowCase
{
    public partial class ShowcaseForm : Form
    {
        private const int UpdateDelay = 100;
        private const float PointRadius = 2.5f;

        private readonly System.Windows.Forms.Timer _tmr = new System.Windows.Forms.Timer { Interval = 1 };

        private Thread _modelThread;
        private bool _update = false;
        private bool _runToEnd = false;
        private bool _isModelRunning = false;

        private (int width, int hieght) bitmapSize = (1000, 1000);
        private Bitmap _bitmap;
        private Brush _pointBrush;
        private bool _isPbBlocked;

        private List<Location> _locations = new List<Location>();
        private TspStepwiseAlgorithmSA _tsp;

        public ShowcaseForm()
        {
            InitializeComponent();
            _bitmap = new Bitmap(bitmapSize.width, bitmapSize.hieght);
            ClearBitmap();
            pbTSP.Image = _bitmap;

            _pointBrush = new SolidBrush(Color.Red);

            numInitTemp.Maximum = int.MaxValue;
            numFinalTemp.Maximum = int.MaxValue;
            numMaxIterations.Maximum = int.MaxValue;

            _tmr.Tick += _tmr_Tick;
        }

        private void DrawRoute(IList<Location> route)
        {
            ClearBitmap();

            Pen linePen = new Pen(Color.Black, PointRadius);

            using (var graphics = Graphics.FromImage(_bitmap))
            {

                for (var i = 0; i < route.Count - 1; ++i)
                    graphics.DrawLine(linePen, 
                        route[i].X, route[i].Y, 
                        route[i + 1].X, route[i + 1].Y);

                graphics.DrawLine(linePen, 
                    route[route.Count - 1].X, 
                    route[route.Count - 1].Y, 
                    route[0].X, route[0].Y);

                for (var i = 0; i < route.Count; ++i)
                    graphics.FillEllipse(_pointBrush, 
                        (route[i].X) - PointRadius, 
                        (route[i].Y) - PointRadius, 
                        PointRadius * 2, PointRadius * 2);
            }
            pbTSP.Refresh();
        }

        private void Init()
        {
            var roads = new List<Road>();
            var metric = new CityBlockDistance();

            for (var i = 0; i < _locations.Count; ++i)
                for (var j = 0; j < _locations.Count; ++j)
                    if (i != j)
                        roads.Add(new Road(_locations[i], _locations[j], metric));

            _tsp.Locations = _locations;
            _tsp.Roads = roads;
            _tsp.Init(_locations[0]);
        }

        private void ClearBitmap()
        {
            Graphics g = Graphics.FromImage(_bitmap);
            g.Clear(Color.White);
        }

        private void pbTSP_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isPbBlocked)
                return;

            var x = _bitmap.Width / (pbTSP.Width / (float)e.X);
            var y = _bitmap.Height / (pbTSP.Height / (float)e.Y);

            _locations.Add(new Location($"{x} | {y}", x, y));

            using (var graphics = Graphics.FromImage(_bitmap))
            {
                graphics.FillEllipse(_pointBrush,
                    x - PointRadius, y - PointRadius,
                    PointRadius * 2, PointRadius * 2);
            }

            pbTSP.Refresh();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (!_locations.Any() || _isPbBlocked)
                return;

            _tsp = new TspStepwiseAlgorithmSA();

            _isPbBlocked = true;
            _tsp.InitialTemperature = (double)numInitTemp.Value;
            _tsp.EndTemperature = (double)numFinalTemp.Value;
            _tsp.MaxIterations = (int)numMaxIterations.Value;
            _tsp.TemperatureStep = (double)numTemperatureStep.Value;

            Init();
            DrawRoute(_tsp.CurrentRoute);
            UpdateLabels();

            _tmr.Start();

            _isModelRunning = true;
            _modelThread = new Thread(RunModel);
            _modelThread.Start();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            _tmr.Stop();
            ClearBitmap();
            pbTSP.Refresh();
            _locations.Clear();
            _isPbBlocked = false;
            _runToEnd = false;
            _isModelRunning = false;
        }

        private void RunModel()
        {
            while (_tsp.MoveNext() && _isModelRunning)
            {
                if (!_runToEnd)
                    Thread.Sleep(UpdateDelay - (int)numModelSpeed.Value);

                _update = true;
            }
        }

        private void UpdateLabels()
        {
            lbIteration.Text = _tsp.CurrentIteration.ToString();
            lbTemperature.Text = _tsp.CurrentTemperature.ToString();
            lbRouteLength.Text = _tsp.CurrentRouteLength.ToString();
        }

        private void _tmr_Tick(object sender, EventArgs e)
        {
            if (_update)
            {
                DrawRoute(_tsp.CurrentRoute);
                UpdateLabels();
                _update = false;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!_locations.Any() || _isPbBlocked)
                return;

            Stream stream;
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "tsp files (*.tsp)|*.tsp|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if ((stream = sfd.OpenFile()) != null)
                {
                    var json = JsonConvert.SerializeObject(_locations);
                    var sw = new StreamWriter(stream);
                    try
                    {
                        sw.Write(json);
                        sw.Flush();
                    }
                    finally
                    {
                        sw.Dispose();
                    }
                    stream.Close();
                }
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "tsp files (*.tsp)|*.tsp|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Reset();

                    filePath = ofd.FileName;

                    var fileStream = ofd.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    _locations = JsonConvert.DeserializeObject<List<Location>>(fileContent);

                    DrawLocations();
                }
            }
        }

        private void DrawLocations()
        {
            using (var graphics = Graphics.FromImage(_bitmap))
            {
                for (var i = 0; i < _locations.Count; ++i)
                {
                    graphics.FillEllipse(_pointBrush,
                        _locations[i].X - PointRadius, _locations[i].Y - PointRadius,
                        PointRadius * 2, PointRadius * 2);
                }
            }

            pbTSP.Refresh();
        }

        private void btToEnd_Click(object sender, EventArgs e)
        {
            _runToEnd = true;
        }
    }
}
