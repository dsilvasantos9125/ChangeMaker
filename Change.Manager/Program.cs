using Change.Library;
using Change.Manager;
using Microsoft.Extensions.DependencyInjection;

namespace ChangeMaker;
public class Program {
	public static void Main(string[] args) {
		using ServiceProvider container = RegisterServices();

		IAppManager controller = container.GetRequiredService<IAppManager>();

		controller.Run();
	}

	public static ServiceProvider RegisterServices() {
		var services = new ServiceCollection();

		services.AddTransient<IAppManager, AppManager>();
		services.AddTransient<IChangeCounter, ChangeCounter>();

		return services.BuildServiceProvider();
	}
}
