namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal sealed class RuntimeServiceProviderEngine : ServiceProviderEngine
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ServiceCallSite callSite; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal object <RealizeService>b__0(ServiceProviderEngineScope scope) { }

	}

	[CompilerGenerated]
	private static readonly RuntimeServiceProviderEngine <Instance>k__BackingField; //Field offset: 0x0

	public static RuntimeServiceProviderEngine Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static RuntimeServiceProviderEngine() { }

	private RuntimeServiceProviderEngine() { }

	[CompilerGenerated]
	public static RuntimeServiceProviderEngine get_Instance() { }

	public virtual Func RealizeService(ServiceCallSite callSite) { }

}

