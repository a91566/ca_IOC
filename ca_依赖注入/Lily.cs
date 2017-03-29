using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_依赖注入
{
	public class Lily : IKiss, IBed
	{
		public IKiss boy;

		public Lily(IKiss boy)
		{
			this.boy = boy;
		}
		public void kiss()
		{
			boy.kiss();
			Console.WriteLine("lily kissing");
		}

		public void Bed()
		{
			(boy as IBed).Bed();
			Console.WriteLine("lily Bed a");
		}
	}
}
