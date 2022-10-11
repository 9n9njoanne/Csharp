
namespace Csharp_HW
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.labName = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labStarSign = new System.Windows.Forms.Label();
            this.labEnglishName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(56, 70);
            this.labName.Name = "labName";
            this.labName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labName.Size = new System.Drawing.Size(0, 24);
            this.labName.TabIndex = 0;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.Location = new System.Drawing.Point(66, 112);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(49, 20);
            this.labSex.TabIndex = 0;
            this.labSex.Text = "性別: ";
            // 
            // labStarSign
            // 
            this.labStarSign.AutoSize = true;
            this.labStarSign.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStarSign.Location = new System.Drawing.Point(66, 150);
            this.labStarSign.Name = "labStarSign";
            this.labStarSign.Size = new System.Drawing.Size(49, 20);
            this.labStarSign.TabIndex = 0;
            this.labStarSign.Text = "星座: ";
            // 
            // labEnglishName
            // 
            this.labEnglishName.AutoSize = true;
            this.labEnglishName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglishName.Location = new System.Drawing.Point(66, 74);
            this.labEnglishName.Name = "labEnglishName";
            this.labEnglishName.Size = new System.Drawing.Size(121, 20);
            this.labEnglishName.TabIndex = 0;
            this.labEnglishName.Text = "English Name: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(224, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSex.Location = new System.Drawing.Point(224, 107);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(125, 29);
            this.txtSex.TabIndex = 2;
            // 
            // txtStar
            // 
            this.txtStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStar.Location = new System.Drawing.Point(224, 145);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(125, 29);
            this.txtStar.TabIndex = 3;
            // 
            // txtEnName
            // 
            this.txtEnName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnName.Location = new System.Drawing.Point(224, 71);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(125, 29);
            this.txtEnName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名: ";
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSayHello.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSayHello.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHello.Image")));
            this.btnSayHello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayHello.Location = new System.Drawing.Point(60, 195);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(127, 57);
            this.btnSayHello.TabIndex = 5;
            this.btnSayHello.Text = "Say HELLO!";
            this.btnSayHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSayHi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSayHi.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHi.Image")));
            this.btnSayHi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayHi.Location = new System.Drawing.Point(224, 195);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(125, 57);
            this.btnSayHi.TabIndex = 5;
            this.btnSayHi.Text = "Say HI  !!!";
            this.btnSayHi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(422, 277);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labEnglishName);
            this.Controls.Add(this.labStarSign);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labName);
            this.DoubleBuffered = true;
            this.Name = "Hello";
            this.Text = "Hello C#!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labStarSign;
        private System.Windows.Forms.Label labEnglishName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
    }
}