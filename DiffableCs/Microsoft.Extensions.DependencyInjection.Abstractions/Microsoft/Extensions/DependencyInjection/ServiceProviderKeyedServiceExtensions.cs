namespace Microsoft.Extensions.DependencyInjection;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class ServiceProviderKeyedServiceExtensions
{

	[Extension]
	public static object GetRequiredKeyedService(IServiceProvider provider, Type serviceType, object serviceKey) { }

	[Extension]
	public static T GetRequiredKeyedService(IServiceProvider provider, object serviceKey) { }

}

