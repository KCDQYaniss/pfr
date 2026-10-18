namespace Microsoft.Extensions.DependencyInjection;

[EventSource(Name = "Microsoft-Extensions-DependencyInjection")]
[Nullable(0)]
[NullableContext(1)]
internal sealed class DependencyInjectionEventSource : EventSource
{
	[NullableContext(0)]
	internal static class Keywords
	{
		public const EventKeywords ServiceProviderInitialized = 1; //Field offset: 0x0

	}

	public static readonly DependencyInjectionEventSource Log; //Field offset: 0x0
	private readonly List _providers; //Field offset: 0x20

	private static DependencyInjectionEventSource() { }

	private DependencyInjectionEventSource() { }

	[NonEvent]
	private static void AppendServiceDescriptor(StringBuilder builder, ServiceDescriptor descriptor) { }

	[NonEvent]
	public void CallSiteBuilt(ServiceProvider provider, Type serviceType, ServiceCallSite callSite) { }

	[Event(1, Level = EventLevel::Verbose (5))]
	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Parameters to this method are primitive and are trimmer safe.")]
	private void CallSiteBuilt(string serviceType, string callSite, int chunkIndex, int chunkCount, int serviceProviderHashCode) { }

	[Event(4, Level = EventLevel::Verbose (5))]
	public void DynamicMethodBuilt(string serviceType, int methodSize, int serviceProviderHashCode) { }

	[NonEvent]
	public void DynamicMethodBuilt(ServiceProvider provider, Type serviceType, int methodSize) { }

	[Event(5, Level = EventLevel::Verbose (5))]
	public void ScopeDisposed(int serviceProviderHashCode, int scopedServicesResolved, int disposableServices) { }

	[Event(7, Level = EventLevel::Informational (4), Keywords = 1)]
	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Parameters to this method are primitive and are trimmer safe.")]
	private void ServiceProviderBuilt(int serviceProviderHashCode, int singletonServices, int scopedServices, int transientServices, int closedGenericsServices, int openGenericsServices) { }

	[NonEvent]
	public void ServiceProviderBuilt(ServiceProvider provider) { }

	[Event(8, Level = EventLevel::Informational (4), Keywords = 1)]
	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Parameters to this method are primitive and are trimmer safe.")]
	private void ServiceProviderDescriptors(int serviceProviderHashCode, string descriptors, int chunkIndex, int chunkCount) { }

	[NonEvent]
	public void ServiceProviderDisposed(ServiceProvider provider) { }

	[Event(6, Level = EventLevel::Error (2))]
	[NullableContext(2)]
	public void ServiceRealizationFailed(string exceptionMessage, int serviceProviderHashCode) { }

	[NonEvent]
	public void ServiceRealizationFailed(Exception exception, int serviceProviderHashCode) { }

	[Event(2, Level = EventLevel::Verbose (5))]
	public void ServiceResolved(string serviceType, int serviceProviderHashCode) { }

	[NonEvent]
	public void ServiceResolved(ServiceProvider provider, Type serviceType) { }

	[NonEvent]
	private void WriteServiceProviderBuilt(ServiceProvider provider) { }

}

