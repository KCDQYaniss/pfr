namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal sealed class DynamicServiceProviderEngine : CompiledServiceProviderEngine
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ServiceCallSite callSite; //Field offset: 0x10
		public int callCount; //Field offset: 0x18
		public DynamicServiceProviderEngine <>4__this; //Field offset: 0x20
		public WaitCallback <>9__1; //Field offset: 0x28

		public <>c__DisplayClass2_0() { }

		internal object <RealizeService>b__0(ServiceProviderEngineScope scope) { }

		internal void <RealizeService>b__1(object _) { }

	}

	private readonly ServiceProvider _serviceProvider; //Field offset: 0x18

	[RequiresDynamicCode("Creates DynamicMethods")]
	public DynamicServiceProviderEngine(ServiceProvider serviceProvider) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Func <>n__0(ServiceCallSite callSite) { }

	public virtual Func RealizeService(ServiceCallSite callSite) { }

}

