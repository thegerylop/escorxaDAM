namespace Espectograf
{
    partial class uiEspectograf
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aGauge3 = new AGaugeApp.AGauge();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(201, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(133, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "5";
            // 
            // aGauge3
            // 
            this.aGauge3.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge3.BaseArcColor = System.Drawing.Color.Red;
            this.aGauge3.BaseArcRadius = 40;
            this.aGauge3.BaseArcStart = 180;
            this.aGauge3.BaseArcSweep = 180;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Cap_Idx = ((byte)(1));
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(55, 75);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(55, 75),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "",
        "MB per 100g",
        "",
        "",
        ""};
            this.aGauge3.CapText = "MB per 100g";
            this.aGauge3.Center = new System.Drawing.Point(90, 60);
            this.aGauge3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge3.Location = new System.Drawing.Point(50, 43);
            this.aGauge3.MaxValue = 10F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge3.NeedleRadius = 40;
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.Range_Idx = ((byte)(0));
            this.aGauge3.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge3.RangeEnabled = true;
            this.aGauge3.RangeEndValue = 3F;
            this.aGauge3.RangeInnerRadius = 40;
            this.aGauge3.RangeOuterRadius = 50;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        true,
        false,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        3F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        40,
        10,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        50,
        40,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        1F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 1F;
            this.aGauge3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 42;
            this.aGauge3.ScaleLinesInterOuterRadius = 50;
            this.aGauge3.ScaleLinesInterWidth = 2;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 40;
            this.aGauge3.ScaleLinesMajorOuterRadius = 50;
            this.aGauge3.ScaleLinesMajorStepValue = 50F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMinorInnerRadius = 43;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 50;
            this.aGauge3.ScaleLinesMinorWidth = 2;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 62;
            this.aGauge3.ScaleNumbersRotation = 90;
            this.aGauge3.ScaleNumbersStartScaleLine = 1;
            this.aGauge3.ScaleNumbersStepScaleLines = 10;
            this.aGauge3.Size = new System.Drawing.Size(187, 102);
            this.aGauge3.TabIndex = 20;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge2.BaseArcColor = System.Drawing.Color.Red;
            this.aGauge2.BaseArcRadius = 40;
            this.aGauge2.BaseArcStart = 180;
            this.aGauge2.BaseArcSweep = 180;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(70, 75);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(70, 75),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        " % O2",
        "",
        "",
        ""};
            this.aGauge2.CapText = " % O2";
            this.aGauge2.Center = new System.Drawing.Point(90, 60);
            this.aGauge2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge2.Location = new System.Drawing.Point(50, 166);
            this.aGauge2.MaxValue = 100F;
            this.aGauge2.MinValue = 50F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge2.NeedleRadius = 40;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(0));
            this.aGauge2.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 80F;
            this.aGauge2.RangeInnerRadius = 40;
            this.aGauge2.RangeOuterRadius = 50;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        false,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        80F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        40,
        10,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        50,
        40,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        65F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 65F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 42;
            this.aGauge2.ScaleLinesInterOuterRadius = 50;
            this.aGauge2.ScaleLinesInterWidth = 2;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 40;
            this.aGauge2.ScaleLinesMajorOuterRadius = 50;
            this.aGauge2.ScaleLinesMajorStepValue = 50F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMinorInnerRadius = 43;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 50;
            this.aGauge2.ScaleLinesMinorWidth = 2;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 62;
            this.aGauge2.ScaleNumbersRotation = 90;
            this.aGauge2.ScaleNumbersStartScaleLine = 1;
            this.aGauge2.ScaleNumbersStepScaleLines = 2;
            this.aGauge2.Size = new System.Drawing.Size(178, 102);
            this.aGauge2.TabIndex = 17;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Red;
            this.aGauge1.BaseArcRadius = 40;
            this.aGauge1.BaseArcStart = 180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(70, 75);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(70, 75),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        " % CO",
        "",
        "",
        ""};
            this.aGauge1.CapText = " % CO";
            this.aGauge1.Center = new System.Drawing.Point(90, 60);
            this.aGauge1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge1.Location = new System.Drawing.Point(372, 43);
            this.aGauge1.MaxValue = 50F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge1.NeedleRadius = 40;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(0));
            this.aGauge1.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 30F;
            this.aGauge1.RangeInnerRadius = 40;
            this.aGauge1.RangeOuterRadius = 50;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        false,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        30F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        40,
        10,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        50,
        40,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        20F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 20F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 42;
            this.aGauge1.ScaleLinesInterOuterRadius = 50;
            this.aGauge1.ScaleLinesInterWidth = 2;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 40;
            this.aGauge1.ScaleLinesMajorOuterRadius = 50;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMinorInnerRadius = 43;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 50;
            this.aGauge1.ScaleLinesMinorWidth = 2;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 62;
            this.aGauge1.ScaleNumbersRotation = 90;
            this.aGauge1.ScaleNumbersStartScaleLine = 1;
            this.aGauge1.ScaleNumbersStepScaleLines = 2;
            this.aGauge1.Size = new System.Drawing.Size(178, 102);
            this.aGauge1.TabIndex = 16;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // uiEspectograf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.aGauge1);
            this.Name = "uiEspectograf";
            this.Text = "uiEspectograf";
            this.ResumeLayout(false);

        }

        #endregion
        public AGaugeApp.AGauge aGauge1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public AGaugeApp.AGauge aGauge2;
        public AGaugeApp.AGauge aGauge3;
        private System.Windows.Forms.Timer timer1;
    }
}