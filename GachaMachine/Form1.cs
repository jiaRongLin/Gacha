using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GachaMachine
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int sum; //總金額
		int ship = 50; //商品金額
		/// <summary>
		/// 扭蛋機程式
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btncoin_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtmoney.Text, out int money); //投入金額
			
			if (!isInt || money<=0)
			{
				MessageBox.Show("請輸入正確金額!!");
				txtmoney.Clear();
				return;
			}
			sum += money;

			result();
		}

		private void btnreturnMoney_Click(object sender, EventArgs e)
		{
			sum = 0;

			result();
			MessageBox.Show("已完成退幣作業");
		}

		private void btnship_Click(object sender, EventArgs e)
		{
			sum -= ship;			

			result();
			MessageBox.Show("已出貨");
		}

		public string result()
		{
			txtpanel.Clear();
			if (sum >= ship)
			{
				btnship.Enabled = true;
				btnreturnMoney.Enabled = true;

				txtpanel.Text += $"State:投入足夠金額，等待客人指令就出貨\r\nMoney:{sum}";
			}
			else if (sum == 0)
			{
				btnship.Enabled = false;
				btnreturnMoney.Enabled = false;

				txtpanel.Text += "State:StandbyState 機器沒在工作，等待下一個客人操作\r\nMoney: 0";
			}
			else
			{
				btnship.Enabled = false;
				btnreturnMoney.Enabled = true;

				txtpanel.Text += $"State:有投幣，但金額還不足\r\nMoney:{sum}";
			}
			return txtpanel.Text;
		}
	}
}
