using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaState
{
    public class GachaResult
    {
		public string GachaCal(int sum,int ship)
		{
			string result = string.Empty;
			if (sum >= ship)
			{
				result = $"State:投入足夠金額，等待客人指令就出貨\r\nMoney:{sum}";
			}
			else if (sum == 0)
			{
				result = "State:StandbyState 機器沒在工作，等待下一個客人操作\r\nMoney: 0";
			}
			else if(sum < 0)
			{
				throw new Exception("總金額不能小於0");
			}
			else
			{
				result = $"State:有投幣，但金額還不足\r\nMoney:{sum}";
			}
			return result;
		}
	}
}
