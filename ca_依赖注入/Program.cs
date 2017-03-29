using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace ca_依赖注入
{
	class Program
	{
		static void Main(string[] args)
		{
			//创建容器  
			//IUnityContainer container = new UnityContainer();
			////注册映射  
			//container.RegisterType<IKiss, Boy>();
			////得到Boy的实例  
			//var boy = container.Resolve<IKiss>();

			//Lily lily = new Lily(boy);
			//lily.kiss();
			//System.Console.ReadKey();


			IUnityContainer container = new UnityContainer();
			UnityConfigurationSection configuration = ConfigurationManager.GetSection(UnityConfigurationSection.SectionName) as UnityConfigurationSection;
			configuration.Configure(container, "defaultContainer");
			var boy = container.Resolve<IKiss>();
			Lily lily = new Lily(boy);
			lily.kiss();
			lily.Bed();
			System.Console.ReadKey();

		}
	}
}
