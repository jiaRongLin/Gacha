using GachaState;
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
		const int ship = 50; //商品金額
		GachaResult gacha = new GachaResult();
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

			txtpanel.Text = gacha.GachaCal(sum,ship);
			BtnEnble();
		}

		private void btnreturnMoney_Click(object sender, EventArgs e)
		{
			sum = 0;

			txtpanel.Text = gacha.GachaCal(sum, ship);
			BtnEnble();
			MessageBox.Show("已完成退幣作業");
		}

		private void btnship_Click(object sender, EventArgs e)
		{
			sum -= ship;

			txtpanel.Text = gacha.GachaCal(sum, ship);
			BtnEnble();
			MessageBox.Show("已出貨");
		}
		private void BtnEnble()
		{
			btnreturnMoney.Enabled = (sum > 0);
			btnship.Enabled = (sum>ship);

			//if (sum > 0) btnreturnMoney.Enabled = true;
			//if (sum > ship) btnship.Enabled = true;
		}

	}
}
