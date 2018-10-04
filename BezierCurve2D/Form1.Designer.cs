namespace BezierCurve2D
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDrawCurve = new System.Windows.Forms.Button();
            this.trackBarAnimSpeed = new System.Windows.Forms.TrackBar();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelAnimSpeed = new System.Windows.Forms.Label();
            this.labelFast = new System.Windows.Forms.Label();
            this.labelNormal = new System.Windows.Forms.Label();
            this.labelSlow = new System.Windows.Forms.Label();
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY4 = new System.Windows.Forms.NumericUpDown();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelY3 = new System.Windows.Forms.Label();
            this.labelY4 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelX4 = new System.Windows.Forms.Label();
            this.buttonEraseCurve = new System.Windows.Forms.Button();
            this.labelControlPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnimSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrawCurve
            // 
            this.buttonDrawCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDrawCurve.Location = new System.Drawing.Point(902, 12);
            this.buttonDrawCurve.Name = "buttonDrawCurve";
            this.buttonDrawCurve.Size = new System.Drawing.Size(103, 25);
            this.buttonDrawCurve.TabIndex = 0;
            this.buttonDrawCurve.Text = "Draw Bezier Curve";
            this.buttonDrawCurve.UseVisualStyleBackColor = true;
            this.buttonDrawCurve.Click += new System.EventHandler(this.buttonDrawCurve_Click);
            // 
            // trackBarAnimSpeed
            // 
            this.trackBarAnimSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarAnimSpeed.LargeChange = 1;
            this.trackBarAnimSpeed.Location = new System.Drawing.Point(960, 119);
            this.trackBarAnimSpeed.Maximum = 3;
            this.trackBarAnimSpeed.Minimum = 1;
            this.trackBarAnimSpeed.Name = "trackBarAnimSpeed";
            this.trackBarAnimSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAnimSpeed.Size = new System.Drawing.Size(45, 103);
            this.trackBarAnimSpeed.TabIndex = 1;
            this.trackBarAnimSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarAnimSpeed.Value = 3;
            this.trackBarAnimSpeed.Scroll += new System.EventHandler(this.trackBarAnimSpeed_Scroll);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(902, 737);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(103, 25);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset to Defaults";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelAnimSpeed
            // 
            this.labelAnimSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAnimSpeed.AutoSize = true;
            this.labelAnimSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnimSpeed.Location = new System.Drawing.Point(918, 94);
            this.labelAnimSpeed.Name = "labelAnimSpeed";
            this.labelAnimSpeed.Size = new System.Drawing.Size(87, 13);
            this.labelAnimSpeed.TabIndex = 3;
            this.labelAnimSpeed.Text = "Animation Speed";
            // 
            // labelFast
            // 
            this.labelFast.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFast.AutoSize = true;
            this.labelFast.Location = new System.Drawing.Point(934, 125);
            this.labelFast.Name = "labelFast";
            this.labelFast.Size = new System.Drawing.Size(27, 13);
            this.labelFast.TabIndex = 4;
            this.labelFast.Text = "Fast";
            // 
            // labelNormal
            // 
            this.labelNormal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNormal.AutoSize = true;
            this.labelNormal.Location = new System.Drawing.Point(921, 163);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(40, 13);
            this.labelNormal.TabIndex = 5;
            this.labelNormal.Text = "Normal";
            // 
            // labelSlow
            // 
            this.labelSlow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSlow.AutoSize = true;
            this.labelSlow.Location = new System.Drawing.Point(931, 201);
            this.labelSlow.Name = "labelSlow";
            this.labelSlow.Size = new System.Drawing.Size(30, 13);
            this.labelSlow.TabIndex = 6;
            this.labelSlow.Text = "Slow";
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownX1.DecimalPlaces = 1;
            this.numericUpDownX1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownX1.Location = new System.Drawing.Point(949, 514);
            this.numericUpDownX1.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownX1.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownX1.TabIndex = 7;
            this.numericUpDownX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownX1.ValueChanged += new System.EventHandler(this.numericUpDownX1_ValueChanged);
            // 
            // numericUpDownY1
            // 
            this.numericUpDownY1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownY1.DecimalPlaces = 1;
            this.numericUpDownY1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownY1.Location = new System.Drawing.Point(949, 540);
            this.numericUpDownY1.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownY1.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.Name = "numericUpDownY1";
            this.numericUpDownY1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownY1.TabIndex = 8;
            this.numericUpDownY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownY1.ValueChanged += new System.EventHandler(this.numericUpDownY1_ValueChanged);
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownX2.DecimalPlaces = 1;
            this.numericUpDownX2.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownX2.Location = new System.Drawing.Point(949, 568);
            this.numericUpDownX2.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownX2.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownX2.TabIndex = 9;
            this.numericUpDownX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownX2.ValueChanged += new System.EventHandler(this.numericUpDownX2_ValueChanged);
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownY2.DecimalPlaces = 1;
            this.numericUpDownY2.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownY2.Location = new System.Drawing.Point(949, 594);
            this.numericUpDownY2.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownY2.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownY2.TabIndex = 10;
            this.numericUpDownY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownY2.ValueChanged += new System.EventHandler(this.numericUpDownY2_ValueChanged);
            // 
            // numericUpDownX3
            // 
            this.numericUpDownX3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownX3.DecimalPlaces = 1;
            this.numericUpDownX3.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownX3.Location = new System.Drawing.Point(949, 627);
            this.numericUpDownX3.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownX3.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numericUpDownX3.Name = "numericUpDownX3";
            this.numericUpDownX3.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownX3.TabIndex = 11;
            this.numericUpDownX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownX3.ValueChanged += new System.EventHandler(this.numericUpDownX3_ValueChanged);
            // 
            // numericUpDownY3
            // 
            this.numericUpDownY3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownY3.DecimalPlaces = 1;
            this.numericUpDownY3.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownY3.Location = new System.Drawing.Point(949, 653);
            this.numericUpDownY3.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownY3.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numericUpDownY3.Name = "numericUpDownY3";
            this.numericUpDownY3.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownY3.TabIndex = 12;
            this.numericUpDownY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownY3.ValueChanged += new System.EventHandler(this.numericUpDownY3_ValueChanged);
            // 
            // numericUpDownX4
            // 
            this.numericUpDownX4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownX4.DecimalPlaces = 1;
            this.numericUpDownX4.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownX4.Location = new System.Drawing.Point(949, 684);
            this.numericUpDownX4.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownX4.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numericUpDownX4.Name = "numericUpDownX4";
            this.numericUpDownX4.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownX4.TabIndex = 13;
            this.numericUpDownX4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownX4.ValueChanged += new System.EventHandler(this.numericUpDownX4_ValueChanged);
            // 
            // numericUpDownY4
            // 
            this.numericUpDownY4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownY4.DecimalPlaces = 1;
            this.numericUpDownY4.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownY4.Location = new System.Drawing.Point(949, 710);
            this.numericUpDownY4.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownY4.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numericUpDownY4.Name = "numericUpDownY4";
            this.numericUpDownY4.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownY4.TabIndex = 14;
            this.numericUpDownY4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownY4.ValueChanged += new System.EventHandler(this.numericUpDownY4_ValueChanged);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(918, 516);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(20, 13);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "X1";
            // 
            // labelY1
            // 
            this.labelY1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(918, 542);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(20, 13);
            this.labelY1.TabIndex = 16;
            this.labelY1.Text = "Y1";
            // 
            // labelY2
            // 
            this.labelY2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(918, 596);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(20, 13);
            this.labelY2.TabIndex = 17;
            this.labelY2.Text = "Y2";
            // 
            // labelY3
            // 
            this.labelY3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelY3.AutoSize = true;
            this.labelY3.Location = new System.Drawing.Point(918, 655);
            this.labelY3.Name = "labelY3";
            this.labelY3.Size = new System.Drawing.Size(20, 13);
            this.labelY3.TabIndex = 18;
            this.labelY3.Text = "Y3";
            // 
            // labelY4
            // 
            this.labelY4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelY4.AutoSize = true;
            this.labelY4.Location = new System.Drawing.Point(918, 712);
            this.labelY4.Name = "labelY4";
            this.labelY4.Size = new System.Drawing.Size(20, 13);
            this.labelY4.TabIndex = 19;
            this.labelY4.Text = "Y4";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(918, 570);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(20, 13);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "X2";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(918, 629);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(20, 13);
            this.labelX3.TabIndex = 21;
            this.labelX3.Text = "X3";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(918, 686);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(20, 13);
            this.labelX4.TabIndex = 22;
            this.labelX4.Text = "X4";
            // 
            // buttonEraseCurve
            // 
            this.buttonEraseCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEraseCurve.Location = new System.Drawing.Point(902, 43);
            this.buttonEraseCurve.Name = "buttonEraseCurve";
            this.buttonEraseCurve.Size = new System.Drawing.Size(103, 25);
            this.buttonEraseCurve.TabIndex = 23;
            this.buttonEraseCurve.Text = "Erase Curve(s)";
            this.buttonEraseCurve.UseVisualStyleBackColor = true;
            this.buttonEraseCurve.Click += new System.EventHandler(this.buttonEraseCurve_Click);
            // 
            // labelControlPoints
            // 
            this.labelControlPoints.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControlPoints.AutoSize = true;
            this.labelControlPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlPoints.Location = new System.Drawing.Point(918, 495);
            this.labelControlPoints.Name = "labelControlPoints";
            this.labelControlPoints.Size = new System.Drawing.Size(72, 13);
            this.labelControlPoints.TabIndex = 24;
            this.labelControlPoints.Text = "Control Points";
            this.labelControlPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 762);
            this.Controls.Add(this.labelControlPoints);
            this.Controls.Add(this.buttonEraseCurve);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY4);
            this.Controls.Add(this.labelY3);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.numericUpDownY4);
            this.Controls.Add(this.numericUpDownX4);
            this.Controls.Add(this.numericUpDownY3);
            this.Controls.Add(this.numericUpDownX3);
            this.Controls.Add(this.numericUpDownY2);
            this.Controls.Add(this.numericUpDownX2);
            this.Controls.Add(this.numericUpDownY1);
            this.Controls.Add(this.numericUpDownX1);
            this.Controls.Add(this.labelSlow);
            this.Controls.Add(this.labelNormal);
            this.Controls.Add(this.labelFast);
            this.Controls.Add(this.labelAnimSpeed);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.trackBarAnimSpeed);
            this.Controls.Add(this.buttonDrawCurve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Cubic Bezier Curve --- Adeel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnimSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawCurve;
        private System.Windows.Forms.TrackBar trackBarAnimSpeed;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelAnimSpeed;
        private System.Windows.Forms.Label labelFast;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Label labelSlow;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.NumericUpDown numericUpDownX3;
        private System.Windows.Forms.NumericUpDown numericUpDownY3;
        private System.Windows.Forms.NumericUpDown numericUpDownX4;
        private System.Windows.Forms.NumericUpDown numericUpDownY4;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelY3;
        private System.Windows.Forms.Label labelY4;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelX4;
        private System.Windows.Forms.Button buttonEraseCurve;
        private System.Windows.Forms.Label labelControlPoints;
    }
}

