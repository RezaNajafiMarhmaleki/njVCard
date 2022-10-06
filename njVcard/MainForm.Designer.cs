namespace njVcard
{
    partial class MainForm
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
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teltextBox = new System.Windows.Forms.TextBox();
            this.consttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(631, 55);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nametextBox.Size = new System.Drawing.Size(185, 239);
            this.nametextBox.TabIndex = 0;
            this.nametextBox.Text = "نام1\r\nنام2\r\nنام3";
            this.nametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی";
            // 
            // lastnametextBox
            // 
            this.lastnametextBox.Location = new System.Drawing.Point(416, 55);
            this.lastnametextBox.Multiline = true;
            this.lastnametextBox.Name = "lastnametextBox";
            this.lastnametextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lastnametextBox.Size = new System.Drawing.Size(185, 239);
            this.lastnametextBox.TabIndex = 2;
            this.lastnametextBox.Text = "نام خانوادگی1\r\nنام خانوادگی2";
            this.lastnametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره تماس";
            // 
            // teltextBox
            // 
            this.teltextBox.Location = new System.Drawing.Point(231, 55);
            this.teltextBox.Multiline = true;
            this.teltextBox.Name = "teltextBox";
            this.teltextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teltextBox.Size = new System.Drawing.Size(142, 239);
            this.teltextBox.TabIndex = 4;
            this.teltextBox.Text = "12345678922\r\n12345678900\r\n12345678911";
            // 
            // consttextBox
            // 
            this.consttextBox.Location = new System.Drawing.Point(36, 55);
            this.consttextBox.Name = "consttextBox";
            this.consttextBox.Size = new System.Drawing.Size(141, 21);
            this.consttextBox.TabIndex = 6;
            this.consttextBox.Text = "دانشجویان1";
            this.consttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.consttextBox.TextChanged += new System.EventHandler(this.consttextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "کلمه مشترک";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "تولید فایل قابل انتقال به تلفن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.vcf";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "جدید";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teltextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastnametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametextBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "تولید فایل vcf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teltextBox;
        private System.Windows.Forms.TextBox consttextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

