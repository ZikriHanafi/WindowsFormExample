namespace WindowsFormExample
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
            this.btnStrikeThru = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupEffect = new System.Windows.Forms.GroupBox();
            this.btnUnderline = new System.Windows.Forms.CheckBox();
            this.groupStyle = new System.Windows.Forms.GroupBox();
            this.btnBoldItalic = new System.Windows.Forms.RadioButton();
            this.btnBold = new System.Windows.Forms.RadioButton();
            this.btnItalic = new System.Windows.Forms.RadioButton();
            this.btnRegular = new System.Windows.Forms.RadioButton();
            this.groupEffect.SuspendLayout();
            this.groupStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStrikeThru
            // 
            this.btnStrikeThru.AutoSize = true;
            this.btnStrikeThru.Location = new System.Drawing.Point(6, 21);
            this.btnStrikeThru.Name = "btnStrikeThru";
            this.btnStrikeThru.Size = new System.Drawing.Size(90, 20);
            this.btnStrikeThru.TabIndex = 0;
            this.btnStrikeThru.Text = "StrikeThru";
            this.btnStrikeThru.UseVisualStyleBackColor = true;
            this.btnStrikeThru.CheckedChanged += new System.EventHandler(this.btnStrikeThru_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "This is the Text";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupEffect
            // 
            this.groupEffect.Controls.Add(this.btnUnderline);
            this.groupEffect.Controls.Add(this.btnStrikeThru);
            this.groupEffect.Location = new System.Drawing.Point(127, 244);
            this.groupEffect.Name = "groupEffect";
            this.groupEffect.Size = new System.Drawing.Size(200, 135);
            this.groupEffect.TabIndex = 2;
            this.groupEffect.TabStop = false;
            this.groupEffect.Text = "Effect";
            this.groupEffect.Enter += new System.EventHandler(this.groupEffect_Enter);
            // 
            // btnUnderline
            // 
            this.btnUnderline.AutoSize = true;
            this.btnUnderline.Location = new System.Drawing.Point(6, 47);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(87, 20);
            this.btnUnderline.TabIndex = 1;
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.CheckedChanged += new System.EventHandler(this.btnUnderline_CheckedChanged);
            // 
            // groupStyle
            // 
            this.groupStyle.Controls.Add(this.btnBoldItalic);
            this.groupStyle.Controls.Add(this.btnBold);
            this.groupStyle.Controls.Add(this.btnItalic);
            this.groupStyle.Controls.Add(this.btnRegular);
            this.groupStyle.Location = new System.Drawing.Point(490, 244);
            this.groupStyle.Name = "groupStyle";
            this.groupStyle.Size = new System.Drawing.Size(200, 135);
            this.groupStyle.TabIndex = 3;
            this.groupStyle.TabStop = false;
            this.groupStyle.Text = "Font Style";
            this.groupStyle.Enter += new System.EventHandler(this.groupStyle_Enter);
            // 
            // btnBoldItalic
            // 
            this.btnBoldItalic.AutoSize = true;
            this.btnBoldItalic.Location = new System.Drawing.Point(7, 98);
            this.btnBoldItalic.Name = "btnBoldItalic";
            this.btnBoldItalic.Size = new System.Drawing.Size(83, 20);
            this.btnBoldItalic.TabIndex = 3;
            this.btnBoldItalic.TabStop = true;
            this.btnBoldItalic.Text = "BoldItalic";
            this.btnBoldItalic.UseVisualStyleBackColor = true;
            this.btnBoldItalic.CheckedChanged += new System.EventHandler(this.btnBoldItalic_CheckedChanged);
            // 
            // btnBold
            // 
            this.btnBold.AutoSize = true;
            this.btnBold.Location = new System.Drawing.Point(7, 72);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(56, 20);
            this.btnBold.TabIndex = 2;
            this.btnBold.TabStop = true;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.CheckedChanged += new System.EventHandler(this.btnBold_CheckedChanged);
            // 
            // btnItalic
            // 
            this.btnItalic.AutoSize = true;
            this.btnItalic.Location = new System.Drawing.Point(7, 46);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(55, 20);
            this.btnItalic.TabIndex = 1;
            this.btnItalic.TabStop = true;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.CheckedChanged += new System.EventHandler(this.btnItalic_CheckedChanged);
            // 
            // btnRegular
            // 
            this.btnRegular.AutoSize = true;
            this.btnRegular.Location = new System.Drawing.Point(7, 22);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(76, 20);
            this.btnRegular.TabIndex = 0;
            this.btnRegular.TabStop = true;
            this.btnRegular.Text = "Regular";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.CheckedChanged += new System.EventHandler(this.btnRegular_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupStyle);
            this.Controls.Add(this.groupEffect);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupEffect.ResumeLayout(false);
            this.groupEffect.PerformLayout();
            this.groupStyle.ResumeLayout(false);
            this.groupStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox btnStrikeThru;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupEffect;
        private System.Windows.Forms.CheckBox btnUnderline;
        private System.Windows.Forms.GroupBox groupStyle;
        private System.Windows.Forms.RadioButton btnBoldItalic;
        private System.Windows.Forms.RadioButton btnBold;
        private System.Windows.Forms.RadioButton btnItalic;
        private System.Windows.Forms.RadioButton btnRegular;
    }
}

