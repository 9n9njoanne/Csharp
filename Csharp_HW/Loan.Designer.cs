
namespace Csharp_HW
{
    partial class Loan
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
            this.labprice = new System.Windows.Forms.Label();
            this.labyear = new System.Windows.Forms.Label();
            this.labrate = new System.Windows.Forms.Label();
            this.labFirstPrice = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtFirstMoney = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnSumpay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labprice
            // 
            this.labprice.AutoSize = true;
            this.labprice.BackColor = System.Drawing.Color.Transparent;
            this.labprice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labprice.ForeColor = System.Drawing.SystemColors.Control;
            this.labprice.Location = new System.Drawing.Point(47, 22);
            this.labprice.Name = "labprice";
            this.labprice.Size = new System.Drawing.Size(96, 24);
            this.labprice.TabIndex = 0;
            this.labprice.Text = "貸款金額: ";
            // 
            // labyear
            // 
            this.labyear.AutoSize = true;
            this.labyear.BackColor = System.Drawing.Color.Transparent;
            this.labyear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labyear.ForeColor = System.Drawing.SystemColors.Control;
            this.labyear.Location = new System.Drawing.Point(52, 69);
            this.labyear.Name = "labyear";
            this.labyear.Size = new System.Drawing.Size(91, 24);
            this.labyear.TabIndex = 0;
            this.labyear.Text = "期限(年): ";
            // 
            // labrate
            // 
            this.labrate.AutoSize = true;
            this.labrate.BackColor = System.Drawing.Color.Transparent;
            this.labrate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labrate.ForeColor = System.Drawing.SystemColors.Control;
            this.labrate.Location = new System.Drawing.Point(54, 116);
            this.labrate.Name = "labrate";
            this.labrate.Size = new System.Drawing.Size(89, 24);
            this.labrate.TabIndex = 0;
            this.labrate.Text = "利率(%): ";
            // 
            // labFirstPrice
            // 
            this.labFirstPrice.AutoSize = true;
            this.labFirstPrice.BackColor = System.Drawing.Color.Transparent;
            this.labFirstPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labFirstPrice.Location = new System.Drawing.Point(54, 163);
            this.labFirstPrice.Name = "labFirstPrice";
            this.labFirstPrice.Size = new System.Drawing.Size(77, 24);
            this.labFirstPrice.TabIndex = 0;
            this.labFirstPrice.Text = "頭期款: ";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(149, 14);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(190, 34);
            this.txtMoney.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(149, 61);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(190, 34);
            this.txtYear.TabIndex = 2;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(149, 108);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(190, 34);
            this.txtRate.TabIndex = 2;
            // 
            // txtFirstMoney
            // 
            this.txtFirstMoney.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstMoney.Location = new System.Drawing.Point(149, 155);
            this.txtFirstMoney.Name = "txtFirstMoney";
            this.txtFirstMoney.Size = new System.Drawing.Size(190, 34);
            this.txtFirstMoney.TabIndex = 2;
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMT.ForeColor = System.Drawing.Color.DimGray;
            this.btnPMT.Location = new System.Drawing.Point(38, 220);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(108, 42);
            this.btnPMT.TabIndex = 3;
            this.btnPMT.Text = "PMY(月付";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnSumpay
            // 
            this.btnSumpay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumpay.ForeColor = System.Drawing.Color.DimGray;
            this.btnSumpay.Location = new System.Drawing.Point(163, 221);
            this.btnSumpay.Name = "btnSumpay";
            this.btnSumpay.Size = new System.Drawing.Size(108, 42);
            this.btnSumpay.TabIndex = 3;
            this.btnSumpay.Text = "總付款";
            this.btnSumpay.UseVisualStyleBackColor = true;
            this.btnSumpay.Click += new System.EventHandler(this.btnSumpay_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(294, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(436, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSumpay);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtFirstMoney);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.labFirstPrice);
            this.Controls.Add(this.labrate);
            this.Controls.Add(this.labyear);
            this.Controls.Add(this.labprice);
            this.Name = "Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labprice;
        private System.Windows.Forms.Label labyear;
        private System.Windows.Forms.Label labrate;
        private System.Windows.Forms.Label labFirstPrice;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtFirstMoney;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnSumpay;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button1;
    }
}