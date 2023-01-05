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
		/// 扭蛋機程式 爛透了版本
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btncoin_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtmoney.Text, out int money);
			
			if (!isInt || money<=0)
			{
				MessageBox.Show("請輸入正確金額!!");
				txtmoney.Clear();
				return;
			}
			sum += money;

			txtpanel.Clear();
			
			if (sum >= 50)
			{
				btnreturnMoney.Enabled = true;
				btnship.Enabled = true;
				txtpanel.Text += $"State:投入足夠金額，等待客人指令就出貨\r\nmoney:{sum}";
			}
			else
			{
				btnreturnMoney.Enabled = true;
				txtpanel.Text += $"State:有投幣，但金額還不足\r\nmoney:{sum}";
			}
		}

		private void btnreturnMoney_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtmoney.Text, out int money);
			if (!isInt || money <= 0)
			{
				MessageBox.Show("請輸入正確金額!!");
				txtmoney.Clear();
				return;
			}

			if (sum >= money)
			{
				sum -= money;
			}
			else 
			{
				MessageBox.Show("請輸入正確金額!!");
				txtmoney.Clear();
				return; 
			}
				
			txtpanel.Clear();

			if (sum >= 50)
			{				
				txtpanel.Text += $"State:投入足夠金額，等待客人指令就出貨\r\nmoney:{sum}";
			}
			else if(sum == 0)
			{
				btnship.Enabled = false;
				txtpanel.Text += "State:StandbyState 機器沒在工作，等待下一個客人操作\r\nMoney: 0";

			}
			else
			{
				btnship.Enabled = false;
				txtpanel.Text += $"State:有投幣，但金額還不足\r\nmoney:{sum}";
			}
			MessageBox.Show("已完成退幣作業");
		}

		private void btnship_Click(object sender, EventArgs e)
		{
			sum -= ship;
			txtpanel.Clear();
			if (sum >= 50)
			{
				txtpanel.Text += $"State:投入足夠金額，等待客人指令就出貨\r\nmoney:{sum}";
			}
			else if (sum == 0)
			{
				btnship.Enabled = false;
				txtpanel.Text += "State:StandbyState 機器沒在工作，等待下一個客人操作\r\nMoney: 0";

			}
			else
			{
				btnship.Enabled = false;
				txtpanel.Text += $"State:有投幣，但金額還不足\r\nmoney:{sum}";
			}
			MessageBox.Show("已出貨");
		}
	}
}
