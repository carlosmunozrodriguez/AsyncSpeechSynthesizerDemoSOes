namespace AsyncForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.VozLabel = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new System.Windows.Forms.Button();
            this.bunifuTrackbar1 = new System.Windows.Forms.TrackBar();
            this.VolumenLabel = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new System.Windows.Forms.Button();
            this.RateLabel = new System.Windows.Forms.Label();
            this.bunifuTrackbar2 = new System.Windows.Forms.TrackBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuTrackbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuTrackbar2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // VozLabel
            // 
            this.VozLabel.AutoSize = true;
            this.VozLabel.Location = new System.Drawing.Point(61, 44);
            this.VozLabel.Name = "VozLabel";
            this.VozLabel.Size = new System.Drawing.Size(87, 13);
            this.VozLabel.TabIndex = 1;
            this.VozLabel.Text = "Escoge una voz:";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Location = new System.Drawing.Point(310, 44);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(75, 23);
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.Text = "Habla";
            this.bunifuImageButton1.UseVisualStyleBackColor = true;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuTrackbar1
            // 
            this.bunifuTrackbar1.Location = new System.Drawing.Point(154, 72);
            this.bunifuTrackbar1.Name = "bunifuTrackbar1";
            this.bunifuTrackbar1.Size = new System.Drawing.Size(150, 45);
            this.bunifuTrackbar1.TabIndex = 3;
            // 
            // VolumenLabel
            // 
            this.VolumenLabel.AutoSize = true;
            this.VolumenLabel.Location = new System.Drawing.Point(97, 72);
            this.VolumenLabel.Name = "VolumenLabel";
            this.VolumenLabel.Size = new System.Drawing.Size(51, 13);
            this.VolumenLabel.TabIndex = 1;
            this.VolumenLabel.Text = "Volumen:";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Enabled = false;
            this.bunifuImageButton2.Location = new System.Drawing.Point(392, 44);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(75, 23);
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.Text = "Detener";
            this.bunifuImageButton2.UseVisualStyleBackColor = true;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(115, 123);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(33, 13);
            this.RateLabel.TabIndex = 1;
            this.RateLabel.Text = "Rate:";
            // 
            // bunifuTrackbar2
            // 
            this.bunifuTrackbar2.Location = new System.Drawing.Point(154, 123);
            this.bunifuTrackbar2.Name = "bunifuTrackbar2";
            this.bunifuTrackbar2.Size = new System.Drawing.Size(150, 45);
            this.bunifuTrackbar2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(154, 175);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 88);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // TextoLabel
            // 
            this.TextoLabel.AutoSize = true;
            this.TextoLabel.Location = new System.Drawing.Point(66, 175);
            this.TextoLabel.Name = "TextoLabel";
            this.TextoLabel.Size = new System.Drawing.Size(82, 13);
            this.TextoLabel.TabIndex = 1;
            this.TextoLabel.Text = "Ingresa el texto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 320);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuTrackbar2);
            this.Controls.Add(this.bunifuTrackbar1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.TextoLabel);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.VolumenLabel);
            this.Controls.Add(this.VozLabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuTrackbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuTrackbar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label VozLabel;
        private System.Windows.Forms.Button bunifuImageButton1;
        private System.Windows.Forms.TrackBar bunifuTrackbar1;
        private System.Windows.Forms.Label VolumenLabel;
        private System.Windows.Forms.Button bunifuImageButton2;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.TrackBar bunifuTrackbar2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label TextoLabel;
    }
}

