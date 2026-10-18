namespace Microsoft.Extensions.DependencyInjection;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class ServiceCollectionServiceExtensions
{

	private static IServiceCollection Add(IServiceCollection collection, Type serviceType, Func implementationFactory, ServiceLifetime lifetime) { }

	private static IServiceCollection AddKeyed(IServiceCollection collection, Type serviceType, object serviceKey, Func implementationFactory, ServiceLifetime lifetime) { }

	[Extension]
	public static IServiceCollection AddKeyedSingleton(IServiceCollection services, Type serviceType, object serviceKey, Func implementationFactory) { }

	[Extension]
	public static IServiceCollection AddKeyedSingleton(IServiceCollection services, object serviceKey, Func implementationFactory) { }

	[Extension]
	public static IServiceCollection AddSingleton(IServiceCollection services, Type serviceType, Func implementationFactory) { }

	[Extension]
	public static IServiceCollection AddSingleton(IServiceCollection services, Func implementationFactory) { }

}

