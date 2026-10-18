namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class ServiceDescriptorExtensions
{

	[Extension]
	public static object GetImplementationInstance(ServiceDescriptor serviceDescriptor) { }

	[Extension]
	public static Type GetImplementationType(ServiceDescriptor serviceDescriptor) { }

	[Extension]
	public static bool HasImplementationInstance(ServiceDescriptor serviceDescriptor) { }

	[Extension]
	public static bool HasImplementationType(ServiceDescriptor serviceDescriptor) { }

	[Extension]
	public static bool TryGetImplementationType(ServiceDescriptor serviceDescriptor, out Type type) { }

}

