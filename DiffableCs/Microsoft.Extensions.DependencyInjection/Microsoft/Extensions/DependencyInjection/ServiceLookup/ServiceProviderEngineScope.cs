namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[DebuggerDisplay("{DebuggerToString(),nq}")]
[DebuggerTypeProxy(typeof(ServiceProviderEngineScopeDebugView))]
[Nullable(0)]
[NullableContext(1)]
internal sealed class ServiceProviderEngineScope : IServiceScope, IDisposable, IServiceProvider, IKeyedServiceProvider, IAsyncDisposable, IServiceScopeFactory
{
	[CompilerGenerated]
	private struct <<DisposeAsync>g__Await|26_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ValueTask vt; //Field offset: 0x28
		public int i; //Field offset: 0x38
		public List toDispose; //Field offset: 0x40
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public object localService; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal Task <CaptureDisposable>b__0() { }

	}

	private sealed class ServiceProviderEngineScopeDebugView
	{

	}

	private bool _disposed; //Field offset: 0x10
	private List _disposables; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Dictionary <ResolvedServices>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <IsRootScope>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly ServiceProvider <RootProvider>k__BackingField; //Field offset: 0x30

	public bool IsRootScope
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	internal Dictionary ResolvedServices
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal ServiceProvider RootProvider
	{
		[CompilerGenerated]
		internal get { } //Length: 76
	}

	internal object Sync
	{
		internal get { } //Length: 5
	}

	public ServiceProviderEngineScope(ServiceProvider provider, bool isRootScope) { }

	[AsyncStateMachine(typeof(<<DisposeAsync>g__Await|26_0>d))]
	[CompilerGenerated]
	internal static ValueTask <DisposeAsync>g__Await|26_0(int i, ValueTask vt, List toDispose) { }

	private List BeginDispose() { }

	[NullableContext(2)]
	internal object CaptureDisposable(object service) { }

	public override void Dispose() { }

	public override ValueTask DisposeAsync() { }

	[CompilerGenerated]
	public bool get_IsRootScope() { }

	[CompilerGenerated]
	internal Dictionary get_ResolvedServices() { }

	[CompilerGenerated]
	internal ServiceProvider get_RootProvider() { }

	internal object get_Sync() { }

	public override object GetRequiredKeyedService(Type serviceType, object serviceKey) { }

	public override object GetService(Type serviceType) { }

}

