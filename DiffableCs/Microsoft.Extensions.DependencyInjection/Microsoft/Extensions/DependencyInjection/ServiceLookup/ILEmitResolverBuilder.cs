namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
[NullableContext(1)]
[RequiresDynamicCode("Creates DynamicMethods")]
internal sealed class ILEmitResolverBuilder : CallSiteVisitor
{
	private struct GeneratedMethod
	{
		public Func Lambda; //Field offset: 0x0
		public ILEmitResolverBuilderRuntimeContext Context; //Field offset: 0x8
		public DynamicMethod DynamicMethod; //Field offset: 0x10

	}

	private sealed class ILEmitResolverBuilderRuntimeContext
	{
		public object[] Constants; //Field offset: 0x10
		public Func[] Factories; //Field offset: 0x18

		public ILEmitResolverBuilderRuntimeContext() { }

	}

	private static readonly MethodInfo ResolvedServicesGetter; //Field offset: 0x0
	private static readonly MethodInfo ScopeLockGetter; //Field offset: 0x8
	private static readonly MethodInfo ScopeIsRootScope; //Field offset: 0x10
	private static readonly MethodInfo CallSiteRuntimeResolverResolveMethod; //Field offset: 0x18
	private static readonly MethodInfo CallSiteRuntimeResolverInstanceField; //Field offset: 0x20
	private static readonly FieldInfo FactoriesField; //Field offset: 0x28
	private static readonly FieldInfo ConstantsField; //Field offset: 0x30
	private static readonly MethodInfo GetTypeFromHandleMethod; //Field offset: 0x38
	private static readonly ConstructorInfo CacheKeyCtor; //Field offset: 0x40
	private readonly ServiceProviderEngineScope _rootScope; //Field offset: 0x18
	private readonly ConcurrentDictionary _scopeResolverCache; //Field offset: 0x20
	private readonly Func _buildTypeDelegate; //Field offset: 0x28

	private static ILEmitResolverBuilder() { }

	public ILEmitResolverBuilder(ServiceProvider serviceProvider) { }

	[CompilerGenerated]
	private GeneratedMethod <.ctor>b__14_0(ServiceCacheKey key, ServiceCallSite cs) { }

	private static void AddCacheKey(ILEmitResolverBuilderContext argument, ServiceCacheKey key) { }

	private static void AddConstant(ILEmitResolverBuilderContext argument, object value) { }

	private static void BeginCaptureDisposable(ILEmitResolverBuilderContext argument) { }

	public Func Build(ServiceCallSite callSite) { }

	private GeneratedMethod BuildType(ServiceCallSite callSite) { }

	private GeneratedMethod BuildTypeNoCache(ServiceCallSite callSite) { }

	private static void EndCaptureDisposable(ILEmitResolverBuilderContext argument) { }

	private ILEmitResolverBuilderRuntimeContext GenerateMethodBody(ServiceCallSite callSite, ILGenerator generator) { }

	protected virtual object VisitConstant(ConstantCallSite constantCallSite, ILEmitResolverBuilderContext argument) { }

	protected virtual object VisitConstructor(ConstructorCallSite constructorCallSite, ILEmitResolverBuilderContext argument) { }

	protected virtual object VisitDisposeCache(ServiceCallSite transientCallSite, ILEmitResolverBuilderContext argument) { }

	protected virtual object VisitFactory(FactoryCallSite factoryCallSite, ILEmitResolverBuilderContext argument) { }

	protected virtual object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, ILEmitResolverBuilderContext argument) { }

	protected virtual object VisitRootCache(ServiceCallSite callSite, ILEmitResolverBuilderContext argument) { }

	protected virtual object VisitScopeCache(ServiceCallSite scopedCallSite, ILEmitResolverBuilderContext argument) { }

	protected virtual object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, ILEmitResolverBuilderContext argument) { }

}

