
namespace Csharp_HW
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMilkTea = new System.Windows.Forms.Button();
            this.btnLemonade = new System.Windows.Forms.Button();
            this.btnGreenTea = new System.Windows.Forms.Button();
            this.btnBlackTea = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtlist = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMilkTea);
            this.groupBox1.Controls.Add(this.btnLemonade);
            this.groupBox1.Controls.Add(this.btnGreenTea);
            this.groupBox1.Controls.Add(this.btnBlackTea);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單Menu";
            // 
            // btnMilkTea
            // 
            this.btnMilkTea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMilkTea.BackgroundImage")));
            this.btnMilkTea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMilkTea.ForeColor = System.Drawing.Color.Black;
            this.btnMilkTea.Location = new System.Drawing.Point(17, 227);
            this.btnMilkTea.Name = "btnMilkTea";
            this.btnMilkTea.Size = new System.Drawing.Size(122, 160);
            this.btnMilkTea.TabIndex = 4;
            this.btnMilkTea.Text = "威士忌\r\nWhisky\r\nNT $350";
            this.btnMilkTea.UseVisualStyleBackColor = true;
            this.btnMilkTea.Click += new System.EventHandler(this.btnMilkTea_Click);
            // 
            // btnLemonade
            // 
            this.btnLemonade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLemonade.BackgroundImage")));
            this.btnLemonade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLemonade.ForeColor = System.Drawing.Color.Black;
            this.btnLemonade.Location = new System.Drawing.Point(159, 227);
            this.btnLemonade.Name = "btnLemonade";
            this.btnLemonade.Size = new System.Drawing.Size(122, 160);
            this.btnLemonade.TabIndex = 3;
            this.btnLemonade.Text = "紅酒\r\nWine\r\nNT $320";
            this.btnLemonade.UseVisualStyleBackColor = true;
            this.btnLemonade.Click += new System.EventHandler(this.btnLemonade_Click);
            // 
            // btnGreenTea
            // 
            this.btnGreenTea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGreenTea.BackgroundImage")));
            this.btnGreenTea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGreenTea.ForeColor = System.Drawing.Color.Black;
            this.btnGreenTea.Location = new System.Drawing.Point(159, 42);
            this.btnGreenTea.Name = "btnGreenTea";
            this.btnGreenTea.Size = new System.Drawing.Size(122, 160);
            this.btnGreenTea.TabIndex = 2;
            this.btnGreenTea.Text = "龍舌蘭\r\nTequila\r\nNT $180";
            this.btnGreenTea.UseVisualStyleBackColor = true;
            this.btnGreenTea.Click += new System.EventHandler(this.btnGreenTea_Click);
            // 
            // btnBlackTea
            // 
            this.btnBlackTea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlackTea.BackgroundImage")));
            this.btnBlackTea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlackTea.ForeColor = System.Drawing.Color.Black;
            this.btnBlackTea.Location = new System.Drawing.Point(17, 42);
            this.btnBlackTea.Name = "btnBlackTea";
            this.btnBlackTea.Size = new System.Drawing.Size(122, 160);
            this.btnBlackTea.TabIndex = 1;
            this.btnBlackTea.Text = "啤酒\r\nBeer\r\nNT $120";
            this.btnBlackTea.UseVisualStyleBackColor = true;
            this.btnBlackTea.Click += new System.EventHandler(this.btnBlackTea_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalPrice);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額Total Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.Black;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(63, 42);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(223, 33);
            this.txtTotalPrice.TabIndex = 0;
            this.txtTotalPrice.Text = "NT $0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnCreditCard);
            this.groupBox3.Controls.Add(this.btnCash);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(338, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(154, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "信用卡享九折!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.MistyRose;
            this.btnCreditCard.ForeColor = System.Drawing.Color.Black;
            this.btnCreditCard.Location = new System.Drawing.Point(179, 32);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(107, 71);
            this.btnCreditCard.TabIndex = 6;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.MistyRose;
            this.btnCash.ForeColor = System.Drawing.Color.Black;
            this.btnCash.Location = new System.Drawing.Point(26, 32);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(107, 71);
            this.btnCash.TabIndex = 5;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtlist);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(658, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 424);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單 List";
            // 
            // txtlist
            // 
            this.txtlist.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtlist.ForeColor = System.Drawing.Color.Black;
            this.txtlist.Location = new System.Drawing.Point(20, 32);
            this.txtlist.Multiline = true;
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(203, 242);
            this.txtlist.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(88, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 55);
            this.button5.TabIndex = 8;
            this.button5.Text = "清除清單";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(909, 465);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "POS";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBlackTea;
        private System.Windows.Forms.Button btnMilkTea;
        private System.Windows.Forms.Button btnLemonade;
        private System.Windows.Forms.Button btnGreenTea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtlist;
    }
}