namespace Microsoft.Extensions.DependencyInjection;

[DebuggerDisplay("{DebuggerToString(),nq}")]
[DebuggerTypeProxy(typeof(ServiceProviderDebugView))]
[Nullable(0)]
[NullableContext(1)]
public sealed class ServiceProvider : IServiceProvider, IKeyedServiceProvider, IDisposable, IAsyncDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__33_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal object <CreateServiceAccessor>b__33_1(ServiceProviderEngineScope _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public object value; //Field offset: 0x10

		public <>c__DisplayClass33_0() { }

		internal object <CreateServiceAccessor>b__0(ServiceProviderEngineScope scope) { }

	}

	private sealed class ServiceAccessor
	{
		[CompilerGenerated]
		private ServiceCallSite <CallSite>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Func <RealizedService>k__BackingField; //Field offset: 0x18

		public ServiceCallSite CallSite
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Func RealizedService
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public ServiceAccessor() { }

		[CompilerGenerated]
		public ServiceCallSite get_CallSite() { }

		[CompilerGenerated]
		public Func get_RealizedService() { }

		[CompilerGenerated]
		public void set_CallSite(ServiceCallSite value) { }

		[CompilerGenerated]
		public void set_RealizedService(Func value) { }

	}

	[Nullable(0)]
	public sealed class ServiceProviderDebugView
	{

	}

	[CompilerGenerated]
	private static readonly bool <VerifyOpenGenericServiceTrimmability>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly bool <DisableDynamicEngine>k__BackingField; //Field offset: 0x1
	private readonly CallSiteValidator _callSiteValidator; //Field offset: 0x10
	private readonly Func _createServiceAccessor; //Field offset: 0x18
	internal ServiceProviderEngine _engine; //Field offset: 0x20
	private bool _disposed; //Field offset: 0x28
	private readonly ConcurrentDictionary _serviceAccessors; //Field offset: 0x30
	[CompilerGenerated]
	private readonly CallSiteFactory <CallSiteFactory>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly ServiceProviderEngineScope <Root>k__BackingField; //Field offset: 0x40

	internal CallSiteFactory CallSiteFactory
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal static bool DisableDynamicEngine
	{
		[CompilerGenerated]
		internal get { } //Length: 84
	}

	internal ServiceProviderEngineScope Root
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal static bool VerifyAotCompatibility
	{
		internal get { } //Length: 3
	}

	internal static bool VerifyOpenGenericServiceTrimmability
	{
		[CompilerGenerated]
		internal get { } //Length: 83
	}

	private static ServiceProvider() { }

	internal ServiceProvider(ICollection serviceDescriptors, ServiceProviderOptions options) { }

	[CompilerGenerated]
	[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "CreateDynamicEngine won't be called when using NativeAOT.")]
	private ServiceProviderEngine <GetEngine>g__CreateDynamicEngine|36_0() { }

	private ServiceAccessor CreateServiceAccessor(ServiceIdentifier serviceIdentifier) { }

	public override void Dispose() { }

	public override ValueTask DisposeAsync() { }

	private void DisposeCore() { }

	[CompilerGenerated]
	internal CallSiteFactory get_CallSiteFactory() { }

	[CompilerGenerated]
	internal static bool get_DisableDynamicEngine() { }

	[CompilerGenerated]
	internal ServiceProviderEngineScope get_Root() { }

	internal static bool get_VerifyAotCompatibility() { }

	[CompilerGenerated]
	internal static bool get_VerifyOpenGenericServiceTrimmability() { }

	private ServiceProviderEngine GetEngine() { }

	internal object GetKeyedService(Type serviceType, object serviceKey, ServiceProviderEngineScope serviceProviderEngineScope) { }

	public override object GetRequiredKeyedService(Type serviceType, object serviceKey) { }

	internal object GetRequiredKeyedService(Type serviceType, object serviceKey, ServiceProviderEngineScope serviceProviderEngineScope) { }

	public override object GetService(Type serviceType) { }

	internal object GetService(ServiceIdentifier serviceIdentifier, ServiceProviderEngineScope serviceProviderEngineScope) { }

	internal bool IsDisposed() { }

	private void OnCreate(ServiceCallSite callSite) { }

	private void OnResolve(ServiceCallSite callSite, IServiceScope scope) { }

	internal void ReplaceServiceAccessor(ServiceCallSite callSite, Func accessor) { }

	private void ValidateService(ServiceDescriptor descriptor) { }

}

