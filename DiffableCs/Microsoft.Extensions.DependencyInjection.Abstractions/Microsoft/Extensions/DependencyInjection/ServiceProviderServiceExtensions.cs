namespace Microsoft.Extensions.DependencyInjection;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class ServiceProviderServiceExtensions
{

	[Extension]
	public static object GetRequiredService(IServiceProvider provider, Type serviceType) { }

	[Extension]
	public static T GetRequiredService(IServiceProvider provider) { }

}

