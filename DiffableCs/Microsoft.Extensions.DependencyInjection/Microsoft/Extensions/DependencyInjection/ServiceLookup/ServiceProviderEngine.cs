namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

internal abstract class ServiceProviderEngine
{

	protected ServiceProviderEngine() { }

	[NullableContext(1)]
	public abstract Func RealizeService(ServiceCallSite callSite) { }

}

