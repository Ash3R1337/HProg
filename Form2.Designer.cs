namespace ForLesson
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.inputOk = new System.Windows.Forms.Button();
            this.ResultPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPass = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.label1.Location = new System.Drawing.Point(263, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputOk
            // 
            this.inputOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputOk.BackColor = System.Drawing.Color.Black;
            this.inputOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputOk.Location = new System.Drawing.Point(433, 242);
            this.inputOk.Name = "inputOk";
            this.inputOk.Size = new System.Drawing.Size(32, 20);
            this.inputOk.TabIndex = 3;
            this.inputOk.Text = "OK";
            this.inputOk.UseVisualStyleBackColor = false;
            this.inputOk.Click += new System.EventHandler(this.inputOk_Click);
            // 
            // ResultPass
            // 
            this.ResultPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultPass.BackColor = System.Drawing.SystemColors.Window;
            this.ResultPass.Location = new System.Drawing.Point(213, 139);
            this.ResultPass.MinimumSize = new System.Drawing.Size(217, 20);
            this.ResultPass.Name = "ResultPass";
            this.ResultPass.ReadOnly = true;
            this.ResultPass.Size = new System.Drawing.Size(217, 20);
            this.ResultPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.label2.Location = new System.Drawing.Point(282, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат";
            // 
            // inputPass
            // 
            this.inputPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputPass.Location = new System.Drawing.Point(213, 242);
            this.inputPass.MaxLength = 100;
            this.inputPass.MinimumSize = new System.Drawing.Size(217, 20);
            this.inputPass.Name = "inputPass";
            this.inputPass.Size = new System.Drawing.Size(217, 20);
            this.inputPass.TabIndex = 6;
            this.inputPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputPass_KeyUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ForLesson.Properties.Resources.left;
            this.pictureBox2.Location = new System.Drawing.Point(32, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.ErrorImage = global::ForLesson.Properties.Resources._1200px_Anonymous_SVG_svg;
            this.pictureBox1.Image = global::ForLesson.Properties.Resources._1200px_Anonymous_SVG_svg;
            this.pictureBox1.Location = new System.Drawing.Point(283, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(11)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(642, 270);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultPass);
            this.Controls.Add(this.inputOk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(158)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зашифровать пароль";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button inputOk;
        private System.Windows.Forms.TextBox ResultPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}