using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_依赖注入
{
	public class Boy : IKiss, IBed
	{
		public void kiss()
		{
			Console.WriteLine("boy kissing");
		}

		public void Bed()
		{
			Console.WriteLine("boy Bed");
		}
	}
}
