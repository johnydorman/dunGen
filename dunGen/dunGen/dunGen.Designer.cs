namespace dunGen
{
    partial class dunGen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.iterationsUpDown = new System.Windows.Forms.NumericUpDown();
            this.previewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.dungeonPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dungeon height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dungeon width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iterations";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(12, 29);
            this.heightUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(84, 20);
            this.heightUpDown.TabIndex = 7;
            this.heightUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(112, 29);
            this.widthUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(84, 20);
            this.widthUpDown.TabIndex = 8;
            this.widthUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // iterationsUpDown
            // 
            this.iterationsUpDown.Location = new System.Drawing.Point(211, 29);
            this.iterationsUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.iterationsUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.iterationsUpDown.Name = "iterationsUpDown";
            this.iterationsUpDown.Size = new System.Drawing.Size(84, 20);
            this.iterationsUpDown.TabIndex = 9;
            this.iterationsUpDown.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(12, 65);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 11;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(116, 65);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // defaultButton
            // 
            this.defaultButton.Location = new System.Drawing.Point(220, 65);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(75, 23);
            this.defaultButton.TabIndex = 13;
            this.defaultButton.Text = "Reset";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // dungeonPreview
            // 
            this.dungeonPreview.Location = new System.Drawing.Point(13, 94);
            this.dungeonPreview.Name = "dungeonPreview";
            this.dungeonPreview.Size = new System.Drawing.Size(282, 200);
            this.dungeonPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dungeonPreview.TabIndex = 14;
            this.dungeonPreview.TabStop = false;
            // 
            // dunGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 310);
            this.Controls.Add(this.dungeonPreview);
            this.Controls.Add(this.defaultButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.iterationsUpDown);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dunGen";
            this.Text = "dunGen";
            this.Load += new System.EventHandler(this.dunGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.NumericUpDown iterationsUpDown;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.PictureBox dungeonPreview;
    }
}

