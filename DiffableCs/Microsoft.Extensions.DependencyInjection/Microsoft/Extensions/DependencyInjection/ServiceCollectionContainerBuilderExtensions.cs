namespace Microsoft.Extensions.DependencyInjection;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class ServiceCollectionContainerBuilderExtensions
{

	[Extension]
	public static ServiceProvider BuildServiceProvider(IServiceCollection services) { }

	[Extension]
	public static ServiceProvider BuildServiceProvider(IServiceCollection services, ServiceProviderOptions options) { }

}

