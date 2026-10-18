namespace Microsoft.Extensions.DependencyInjection.Extensions;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class ServiceCollectionDescriptorExtensions
{

	[Extension]
	public static IServiceCollection RemoveAll(IServiceCollection collection) { }

	[Extension]
	public static IServiceCollection RemoveAll(IServiceCollection collection, Type serviceType) { }

	[Extension]
	public static void TryAdd(IServiceCollection collection, ServiceDescriptor descriptor) { }

	[Extension]
	public static void TryAddEnumerable(IServiceCollection services, ServiceDescriptor descriptor) { }

}

