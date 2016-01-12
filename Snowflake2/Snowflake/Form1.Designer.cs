namespace Snowflake
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
            this.pbxDisplay2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbxBackgroundColour = new System.Windows.Forms.PictureBox();
            this.nudSymmetryOrder = new System.Windows.Forms.NumericUpDown();
            this.btnForegroundColour = new System.Windows.Forms.Button();
            this.pbxForegroundColour = new System.Windows.Forms.PictureBox();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnBackgroundColour = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMaxDepth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudThicknessShrink = new System.Windows.Forms.NumericUpDown();
            this.nudThickness = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.nudShrinkFactor = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfArms = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudArmAngle = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisplay2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymmetryOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForegroundColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThicknessShrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShrinkFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfArms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDisplay2
            // 
            this.pbxDisplay2.BackColor = System.Drawing.Color.Black;
            this.pbxDisplay2.Location = new System.Drawing.Point(6, 6);
            this.pbxDisplay2.Name = "pbxDisplay2";
            this.pbxDisplay2.Size = new System.Drawing.Size(512, 512);
            this.pbxDisplay2.TabIndex = 0;
            this.pbxDisplay2.TabStop = false;
            this.pbxDisplay2.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxDisplay);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pbxBackgroundColour);
            this.groupBox1.Controls.Add(this.nudSymmetryOrder);
            this.groupBox1.Controls.Add(this.btnForegroundColour);
            this.groupBox1.Controls.Add(this.pbxForegroundColour);
            this.groupBox1.Controls.Add(this.btnLoadSettings);
            this.groupBox1.Controls.Add(this.btnBackgroundColour);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnSaveSettings);
            this.groupBox1.Location = new System.Drawing.Point(523, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 512);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Snowflake Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Symmetry";
            // 
            // pbxBackgroundColour
            // 
            this.pbxBackgroundColour.Location = new System.Drawing.Point(79, 410);
            this.pbxBackgroundColour.Name = "pbxBackgroundColour";
            this.pbxBackgroundColour.Size = new System.Drawing.Size(46, 21);
            this.pbxBackgroundColour.TabIndex = 20;
            this.pbxBackgroundColour.TabStop = false;
            // 
            // nudSymmetryOrder
            // 
            this.nudSymmetryOrder.Location = new System.Drawing.Point(135, 39);
            this.nudSymmetryOrder.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudSymmetryOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSymmetryOrder.Name = "nudSymmetryOrder";
            this.nudSymmetryOrder.Size = new System.Drawing.Size(74, 20);
            this.nudSymmetryOrder.TabIndex = 0;
            this.nudSymmetryOrder.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudSymmetryOrder.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // btnForegroundColour
            // 
            this.btnForegroundColour.Location = new System.Drawing.Point(137, 379);
            this.btnForegroundColour.Name = "btnForegroundColour";
            this.btnForegroundColour.Size = new System.Drawing.Size(75, 23);
            this.btnForegroundColour.TabIndex = 17;
            this.btnForegroundColour.Text = "Foreground";
            this.btnForegroundColour.UseVisualStyleBackColor = true;
            this.btnForegroundColour.Click += new System.EventHandler(this.btnForegroundColour_Click);
            // 
            // pbxForegroundColour
            // 
            this.pbxForegroundColour.Location = new System.Drawing.Point(79, 381);
            this.pbxForegroundColour.Name = "pbxForegroundColour";
            this.pbxForegroundColour.Size = new System.Drawing.Size(46, 21);
            this.pbxForegroundColour.TabIndex = 19;
            this.pbxForegroundColour.TabStop = false;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(6, 449);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(107, 23);
            this.btnLoadSettings.TabIndex = 16;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnBackgroundColour
            // 
            this.btnBackgroundColour.Location = new System.Drawing.Point(137, 408);
            this.btnBackgroundColour.Name = "btnBackgroundColour";
            this.btnBackgroundColour.Size = new System.Drawing.Size(75, 23);
            this.btnBackgroundColour.TabIndex = 18;
            this.btnBackgroundColour.Text = "Background";
            this.btnBackgroundColour.UseVisualStyleBackColor = true;
            this.btnBackgroundColour.Click += new System.EventHandler(this.btnBackgroundColour_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(124, 449);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(88, 23);
            this.btnSaveSettings.TabIndex = 15;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Recursion Depth";
            // 
            // nudMaxDepth
            // 
            this.nudMaxDepth.Location = new System.Drawing.Point(658, 346);
            this.nudMaxDepth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMaxDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDepth.Name = "nudMaxDepth";
            this.nudMaxDepth.Size = new System.Drawing.Size(74, 20);
            this.nudMaxDepth.TabIndex = 12;
            this.nudMaxDepth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMaxDepth.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thickness Shrink %";
            // 
            // nudThicknessShrink
            // 
            this.nudThicknessShrink.Location = new System.Drawing.Point(660, 302);
            this.nudThicknessShrink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThicknessShrink.Name = "nudThicknessShrink";
            this.nudThicknessShrink.Size = new System.Drawing.Size(72, 20);
            this.nudThicknessShrink.TabIndex = 10;
            this.nudThicknessShrink.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudThicknessShrink.ValueChanged += new System.EventHandler(this.nudThicknessShrink_ValueChanged);
            // 
            // nudThickness
            // 
            this.nudThickness.Location = new System.Drawing.Point(659, 260);
            this.nudThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThickness.Name = "nudThickness";
            this.nudThickness.Size = new System.Drawing.Size(73, 20);
            this.nudThickness.TabIndex = 9;
            this.nudThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThickness.ValueChanged += new System.EventHandler(this.nudThickness_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thickness";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(660, 220);
            this.nudLength.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(72, 20);
            this.nudLength.TabIndex = 7;
            this.nudLength.Value = new decimal(new int[] {
            144,
            0,
            0,
            0});
            this.nudLength.ValueChanged += new System.EventHandler(this.nudLength_ValueChanged);
            // 
            // nudShrinkFactor
            // 
            this.nudShrinkFactor.Location = new System.Drawing.Point(660, 171);
            this.nudShrinkFactor.Name = "nudShrinkFactor";
            this.nudShrinkFactor.Size = new System.Drawing.Size(72, 20);
            this.nudShrinkFactor.TabIndex = 6;
            this.nudShrinkFactor.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudShrinkFactor.ValueChanged += new System.EventHandler(this.nudShrinkFactor_ValueChanged);
            // 
            // nudNumberOfArms
            // 
            this.nudNumberOfArms.Location = new System.Drawing.Point(659, 133);
            this.nudNumberOfArms.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudNumberOfArms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfArms.Name = "nudNumberOfArms";
            this.nudNumberOfArms.Size = new System.Drawing.Size(72, 20);
            this.nudNumberOfArms.TabIndex = 5;
            this.nudNumberOfArms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfArms.ValueChanged += new System.EventHandler(this.nudNumberOfArms_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shrink Factor %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Arms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arm Angle";
            // 
            // nudArmAngle
            // 
            this.nudArmAngle.Location = new System.Drawing.Point(658, 89);
            this.nudArmAngle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudArmAngle.Name = "nudArmAngle";
            this.nudArmAngle.Size = new System.Drawing.Size(74, 20);
            this.nudArmAngle.TabIndex = 0;
            this.nudArmAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudArmAngle.ValueChanged += new System.EventHandler(this.nudArmAngle_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudMaxDepth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudThicknessShrink);
            this.Controls.Add(this.nudThickness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.nudShrinkFactor);
            this.Controls.Add(this.nudNumberOfArms);
            this.Controls.Add(this.pbxDisplay2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudArmAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisplay2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymmetryOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForegroundColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThicknessShrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShrinkFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfArms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDisplay2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudArmAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.NumericUpDown nudShrinkFactor;
        private System.Windows.Forms.NumericUpDown nudNumberOfArms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudThickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudThicknessShrink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMaxDepth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnForegroundColour;
        private System.Windows.Forms.Button btnBackgroundColour;
        private System.Windows.Forms.PictureBox pbxForegroundColour;
        private System.Windows.Forms.PictureBox pbxBackgroundColour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSymmetryOrder;
    }
}

