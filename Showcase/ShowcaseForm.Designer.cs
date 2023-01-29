
namespace ShowCase
{
    partial class ShowcaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btToEnd = new System.Windows.Forms.Button();
            this.lbRouteLength = new System.Windows.Forms.Label();
            this.lbRouteLengthText = new System.Windows.Forms.Label();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.lbIteration = new System.Windows.Forms.Label();
            this.lbTemperatureText = new System.Windows.Forms.Label();
            this.lbIterationText = new System.Windows.Forms.Label();
            this.numModelSpeed = new System.Windows.Forms.NumericUpDown();
            this.lbModelSpeed = new System.Windows.Forms.Label();
            this.numTemperatureStep = new System.Windows.Forms.NumericUpDown();
            this.lbTemperatureStep = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.numMaxIterations = new System.Windows.Forms.NumericUpDown();
            this.numInitTemp = new System.Windows.Forms.NumericUpDown();
            this.lbMaxIterations = new System.Windows.Forms.Label();
            this.lbInitTemp = new System.Windows.Forms.Label();
            this.lbFinalTemp = new System.Windows.Forms.Label();
            this.numFinalTemp = new System.Windows.Forms.NumericUpDown();
            this.pbTSP = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperatureStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btToEnd);
            this.panel1.Controls.Add(this.lbRouteLength);
            this.panel1.Controls.Add(this.lbRouteLengthText);
            this.panel1.Controls.Add(this.btLoad);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.lbTemperature);
            this.panel1.Controls.Add(this.lbIteration);
            this.panel1.Controls.Add(this.lbTemperatureText);
            this.panel1.Controls.Add(this.lbIterationText);
            this.panel1.Controls.Add(this.numModelSpeed);
            this.panel1.Controls.Add(this.lbModelSpeed);
            this.panel1.Controls.Add(this.numTemperatureStep);
            this.panel1.Controls.Add(this.lbTemperatureStep);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.numMaxIterations);
            this.panel1.Controls.Add(this.numInitTemp);
            this.panel1.Controls.Add(this.lbMaxIterations);
            this.panel1.Controls.Add(this.lbInitTemp);
            this.panel1.Controls.Add(this.lbFinalTemp);
            this.panel1.Controls.Add(this.numFinalTemp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(661, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 661);
            this.panel1.TabIndex = 0;
            // 
            // btToEnd
            // 
            this.btToEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btToEnd.Location = new System.Drawing.Point(92, 468);
            this.btToEnd.Name = "btToEnd";
            this.btToEnd.Size = new System.Drawing.Size(42, 23);
            this.btToEnd.TabIndex = 20;
            this.btToEnd.Text = ">>";
            this.btToEnd.UseVisualStyleBackColor = true;
            this.btToEnd.Click += new System.EventHandler(this.btToEnd_Click);
            // 
            // lbRouteLength
            // 
            this.lbRouteLength.AutoSize = true;
            this.lbRouteLength.Location = new System.Drawing.Point(5, 302);
            this.lbRouteLength.Name = "lbRouteLength";
            this.lbRouteLength.Size = new System.Drawing.Size(0, 15);
            this.lbRouteLength.TabIndex = 19;
            // 
            // lbRouteLengthText
            // 
            this.lbRouteLengthText.AutoSize = true;
            this.lbRouteLengthText.Location = new System.Drawing.Point(5, 287);
            this.lbRouteLengthText.Name = "lbRouteLengthText";
            this.lbRouteLengthText.Size = new System.Drawing.Size(81, 15);
            this.lbRouteLengthText.TabIndex = 18;
            this.lbRouteLengthText.Text = "Route Length:";
            // 
            // btLoad
            // 
            this.btLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLoad.Location = new System.Drawing.Point(71, 497);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(65, 50);
            this.btLoad.TabIndex = 17;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSave.Location = new System.Drawing.Point(0, 497);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 50);
            this.btSave.TabIndex = 16;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(5, 272);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(0, 15);
            this.lbTemperature.TabIndex = 15;
            // 
            // lbIteration
            // 
            this.lbIteration.AutoSize = true;
            this.lbIteration.Location = new System.Drawing.Point(5, 242);
            this.lbIteration.Name = "lbIteration";
            this.lbIteration.Size = new System.Drawing.Size(0, 15);
            this.lbIteration.TabIndex = 14;
            // 
            // lbTemperatureText
            // 
            this.lbTemperatureText.AutoSize = true;
            this.lbTemperatureText.Location = new System.Drawing.Point(5, 257);
            this.lbTemperatureText.Name = "lbTemperatureText";
            this.lbTemperatureText.Size = new System.Drawing.Size(76, 15);
            this.lbTemperatureText.TabIndex = 13;
            this.lbTemperatureText.Text = "Temperature:";
            // 
            // lbIterationText
            // 
            this.lbIterationText.AutoSize = true;
            this.lbIterationText.Location = new System.Drawing.Point(5, 227);
            this.lbIterationText.Name = "lbIterationText";
            this.lbIterationText.Size = new System.Drawing.Size(54, 15);
            this.lbIterationText.TabIndex = 12;
            this.lbIterationText.Text = "Iteration:";
            // 
            // numModelSpeed
            // 
            this.numModelSpeed.Location = new System.Drawing.Point(-1, 468);
            this.numModelSpeed.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numModelSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numModelSpeed.Name = "numModelSpeed";
            this.numModelSpeed.Size = new System.Drawing.Size(87, 23);
            this.numModelSpeed.TabIndex = 11;
            this.numModelSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbModelSpeed
            // 
            this.lbModelSpeed.AutoSize = true;
            this.lbModelSpeed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbModelSpeed.Location = new System.Drawing.Point(2, 450);
            this.lbModelSpeed.Name = "lbModelSpeed";
            this.lbModelSpeed.Size = new System.Drawing.Size(105, 17);
            this.lbModelSpeed.TabIndex = 10;
            this.lbModelSpeed.Text = "Modeling Speed";
            // 
            // numTemperatureStep
            // 
            this.numTemperatureStep.DecimalPlaces = 5;
            this.numTemperatureStep.Location = new System.Drawing.Point(0, 115);
            this.numTemperatureStep.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numTemperatureStep.Name = "numTemperatureStep";
            this.numTemperatureStep.Size = new System.Drawing.Size(137, 23);
            this.numTemperatureStep.TabIndex = 9;
            this.numTemperatureStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // lbTemperatureStep
            // 
            this.lbTemperatureStep.AutoSize = true;
            this.lbTemperatureStep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTemperatureStep.Location = new System.Drawing.Point(3, 97);
            this.lbTemperatureStep.Name = "lbTemperatureStep";
            this.lbTemperatureStep.Size = new System.Drawing.Size(112, 17);
            this.lbTemperatureStep.TabIndex = 8;
            this.lbTemperatureStep.Text = "Temperature Step";
            // 
            // btClear
            // 
            this.btClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClear.Location = new System.Drawing.Point(0, 609);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(137, 50);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStart.Location = new System.Drawing.Point(0, 553);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(137, 50);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // numMaxIterations
            // 
            this.numMaxIterations.Location = new System.Drawing.Point(0, 159);
            this.numMaxIterations.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numMaxIterations.Name = "numMaxIterations";
            this.numMaxIterations.Size = new System.Drawing.Size(137, 23);
            this.numMaxIterations.TabIndex = 5;
            this.numMaxIterations.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // numInitTemp
            // 
            this.numInitTemp.DecimalPlaces = 5;
            this.numInitTemp.Location = new System.Drawing.Point(0, 27);
            this.numInitTemp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numInitTemp.Name = "numInitTemp";
            this.numInitTemp.Size = new System.Drawing.Size(137, 23);
            this.numInitTemp.TabIndex = 3;
            this.numInitTemp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbMaxIterations
            // 
            this.lbMaxIterations.AutoSize = true;
            this.lbMaxIterations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaxIterations.Location = new System.Drawing.Point(3, 141);
            this.lbMaxIterations.Name = "lbMaxIterations";
            this.lbMaxIterations.Size = new System.Drawing.Size(91, 17);
            this.lbMaxIterations.TabIndex = 2;
            this.lbMaxIterations.Text = "Max Iterations";
            // 
            // lbInitTemp
            // 
            this.lbInitTemp.AutoSize = true;
            this.lbInitTemp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInitTemp.Location = new System.Drawing.Point(3, 9);
            this.lbInitTemp.Name = "lbInitTemp";
            this.lbInitTemp.Size = new System.Drawing.Size(116, 17);
            this.lbInitTemp.TabIndex = 0;
            this.lbInitTemp.Text = "Initial Temperature";
            // 
            // lbFinalTemp
            // 
            this.lbFinalTemp.AutoSize = true;
            this.lbFinalTemp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFinalTemp.Location = new System.Drawing.Point(3, 53);
            this.lbFinalTemp.Name = "lbFinalTemp";
            this.lbFinalTemp.Size = new System.Drawing.Size(112, 17);
            this.lbFinalTemp.TabIndex = 1;
            this.lbFinalTemp.Text = "Final Temperature";
            // 
            // numFinalTemp
            // 
            this.numFinalTemp.DecimalPlaces = 5;
            this.numFinalTemp.Location = new System.Drawing.Point(0, 71);
            this.numFinalTemp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numFinalTemp.Name = "numFinalTemp";
            this.numFinalTemp.Size = new System.Drawing.Size(137, 23);
            this.numFinalTemp.TabIndex = 4;
            // 
            // pbTSP
            // 
            this.pbTSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTSP.Location = new System.Drawing.Point(0, 0);
            this.pbTSP.Name = "pbTSP";
            this.pbTSP.Size = new System.Drawing.Size(661, 661);
            this.pbTSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTSP.TabIndex = 1;
            this.pbTSP.TabStop = false;
            this.pbTSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbTSP_MouseClick);
            // 
            // ShowcaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.pbTSP);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowcaseForm";
            this.Text = "Showcase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperatureStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numMaxIterations;
        private System.Windows.Forms.NumericUpDown numInitTemp;
        private System.Windows.Forms.Label lbMaxIterations;
        private System.Windows.Forms.Label lbInitTemp;
        private System.Windows.Forms.Label lbFinalTemp;
        private System.Windows.Forms.NumericUpDown numFinalTemp;
        private System.Windows.Forms.PictureBox pbTSP;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.NumericUpDown numTemperatureStep;
        private System.Windows.Forms.Label lbTemperatureStep;
        private System.Windows.Forms.NumericUpDown numModelSpeed;
        private System.Windows.Forms.Label lbModelSpeed;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbIteration;
        private System.Windows.Forms.Label lbTemperatureText;
        private System.Windows.Forms.Label lbIterationText;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbRouteLength;
        private System.Windows.Forms.Label lbRouteLengthText;
        private System.Windows.Forms.Button btToEnd;
    }
}

