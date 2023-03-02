namespace Task3
{
    partial class Form1
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
            this.numericUpDownBeginRange = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndRange = new System.Windows.Forms.NumericUpDown();
            this.labelBeginRange = new System.Windows.Forms.Label();
            this.labelEndRange = new System.Windows.Forms.Label();
            this.listBoxNumberFibonachi = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelNumberFibonachi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndRange)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownBeginRange
            // 
            this.numericUpDownBeginRange.Location = new System.Drawing.Point(136, 22);
            this.numericUpDownBeginRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBeginRange.Name = "numericUpDownBeginRange";
            this.numericUpDownBeginRange.Size = new System.Drawing.Size(105, 23);
            this.numericUpDownBeginRange.TabIndex = 0;
            // 
            // numericUpDownEndRange
            // 
            this.numericUpDownEndRange.Location = new System.Drawing.Point(136, 56);
            this.numericUpDownEndRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEndRange.Name = "numericUpDownEndRange";
            this.numericUpDownEndRange.Size = new System.Drawing.Size(105, 23);
            this.numericUpDownEndRange.TabIndex = 1;
            this.numericUpDownEndRange.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelBeginRange
            // 
            this.labelBeginRange.AutoSize = true;
            this.labelBeginRange.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBeginRange.Location = new System.Drawing.Point(-2, 22);
            this.labelBeginRange.Name = "labelBeginRange";
            this.labelBeginRange.Size = new System.Drawing.Size(132, 17);
            this.labelBeginRange.TabIndex = 2;
            this.labelBeginRange.Text = "Нaчaлo диaпaзoнa:";
            // 
            // labelEndRange
            // 
            this.labelEndRange.AutoSize = true;
            this.labelEndRange.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndRange.Location = new System.Drawing.Point(-2, 62);
            this.labelEndRange.Name = "labelEndRange";
            this.labelEndRange.Size = new System.Drawing.Size(123, 17);
            this.labelEndRange.TabIndex = 3;
            this.labelEndRange.Text = "Кoнeц диaпaзoнa:";
            // 
            // listBoxNumberFibonachi
            // 
            this.listBoxNumberFibonachi.FormattingEnabled = true;
            this.listBoxNumberFibonachi.ItemHeight = 15;
            this.listBoxNumberFibonachi.Location = new System.Drawing.Point(259, 37);
            this.listBoxNumberFibonachi.Name = "listBoxNumberFibonachi";
            this.listBoxNumberFibonachi.ScrollAlwaysVisible = true;
            this.listBoxNumberFibonachi.Size = new System.Drawing.Size(167, 214);
            this.listBoxNumberFibonachi.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(14, 97);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 47);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // labelNumberFibonachi
            // 
            this.labelNumberFibonachi.AutoSize = true;
            this.labelNumberFibonachi.Location = new System.Drawing.Point(256, 18);
            this.labelNumberFibonachi.Name = "labelNumberFibonachi";
            this.labelNumberFibonachi.Size = new System.Drawing.Size(111, 15);
            this.labelNumberFibonachi.TabIndex = 6;
            this.labelNumberFibonachi.Text = "Числа Фибоначчи:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 271);
            this.Controls.Add(this.labelNumberFibonachi);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxNumberFibonachi);
            this.Controls.Add(this.labelEndRange);
            this.Controls.Add(this.labelBeginRange);
            this.Controls.Add(this.numericUpDownEndRange);
            this.Controls.Add(this.numericUpDownBeginRange);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Асинхронность";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownBeginRange;
        private System.Windows.Forms.NumericUpDown numericUpDownEndRange;
        private System.Windows.Forms.Label labelBeginRange;
        private System.Windows.Forms.Label labelEndRange;
        private System.Windows.Forms.ListBox listBoxNumberFibonachi;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelNumberFibonachi;
    }
}