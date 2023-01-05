namespace GachaMachine
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btncoin = new System.Windows.Forms.Button();
			this.btnreturnMoney = new System.Windows.Forms.Button();
			this.btnship = new System.Windows.Forms.Button();
			this.txtmoney = new System.Windows.Forms.TextBox();
			this.txtpanel = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btncoin
			// 
			this.btncoin.Location = new System.Drawing.Point(615, 43);
			this.btncoin.Name = "btncoin";
			this.btncoin.Size = new System.Drawing.Size(132, 35);
			this.btncoin.TabIndex = 1;
			this.btncoin.Text = "投幣";
			this.btncoin.UseVisualStyleBackColor = true;
			this.btncoin.Click += new System.EventHandler(this.btncoin_Click);
			// 
			// btnreturnMoney
			// 
			this.btnreturnMoney.Enabled = false;
			this.btnreturnMoney.Location = new System.Drawing.Point(474, 392);
			this.btnreturnMoney.Name = "btnreturnMoney";
			this.btnreturnMoney.Size = new System.Drawing.Size(132, 35);
			this.btnreturnMoney.TabIndex = 2;
			this.btnreturnMoney.Text = "退幣";
			this.btnreturnMoney.UseVisualStyleBackColor = true;
			this.btnreturnMoney.Click += new System.EventHandler(this.btnreturnMoney_Click);
			// 
			// btnship
			// 
			this.btnship.Enabled = false;
			this.btnship.Location = new System.Drawing.Point(626, 392);
			this.btnship.Name = "btnship";
			this.btnship.Size = new System.Drawing.Size(132, 35);
			this.btnship.TabIndex = 3;
			this.btnship.Text = "出貨";
			this.btnship.UseVisualStyleBackColor = true;
			this.btnship.Click += new System.EventHandler(this.btnship_Click);
			// 
			// txtmoney
			// 
			this.txtmoney.Location = new System.Drawing.Point(26, 43);
			this.txtmoney.Name = "txtmoney";
			this.txtmoney.Size = new System.Drawing.Size(570, 30);
			this.txtmoney.TabIndex = 0;
			// 
			// txtpanel
			// 
			this.txtpanel.BackColor = System.Drawing.Color.White;
			this.txtpanel.ForeColor = System.Drawing.Color.Black;
			this.txtpanel.Location = new System.Drawing.Point(26, 98);
			this.txtpanel.Multiline = true;
			this.txtpanel.Name = "txtpanel";
			this.txtpanel.ReadOnly = true;
			this.txtpanel.Size = new System.Drawing.Size(721, 279);
			this.txtpanel.TabIndex = 4;
			this.txtpanel.Text = "State:StandbyState 機器沒在工作，等待下一個客人操作\r\nMoney:0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtpanel);
			this.Controls.Add(this.txtmoney);
			this.Controls.Add(this.btnship);
			this.Controls.Add(this.btnreturnMoney);
			this.Controls.Add(this.btncoin);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btncoin;
		private System.Windows.Forms.Button btnreturnMoney;
		private System.Windows.Forms.Button btnship;
		private System.Windows.Forms.TextBox txtmoney;
		private System.Windows.Forms.TextBox txtpanel;
	}
}

