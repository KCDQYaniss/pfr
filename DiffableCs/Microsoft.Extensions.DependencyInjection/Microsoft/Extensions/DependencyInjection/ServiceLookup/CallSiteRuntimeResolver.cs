namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
[NullableContext(1)]
internal sealed class CallSiteRuntimeResolver : CallSiteVisitor
{
	[CompilerGenerated]
	private static readonly CallSiteRuntimeResolver <Instance>k__BackingField; //Field offset: 0x0

	public static CallSiteRuntimeResolver Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static CallSiteRuntimeResolver() { }

	private CallSiteRuntimeResolver() { }

	[CompilerGenerated]
	[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "VerifyAotCompatibility ensures elementType is not a ValueType")]
	internal static Array <VisitIEnumerable>g__CreateArray|12_0(Type elementType, int length) { }

	[CompilerGenerated]
	public static CallSiteRuntimeResolver get_Instance() { }

	public object Resolve(ServiceCallSite callSite, ServiceProviderEngineScope scope) { }

	private object VisitCache(ServiceCallSite callSite, RuntimeResolverContext context, ServiceProviderEngineScope serviceProviderEngine, RuntimeResolverLock lockType) { }

	protected virtual object VisitConstant(ConstantCallSite constantCallSite, RuntimeResolverContext context) { }

	protected virtual object VisitConstructor(ConstructorCallSite constructorCallSite, RuntimeResolverContext context) { }

	protected virtual object VisitDisposeCache(ServiceCallSite transientCallSite, RuntimeResolverContext context) { }

	protected virtual object VisitFactory(FactoryCallSite factoryCallSite, RuntimeResolverContext context) { }

	protected virtual object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, RuntimeResolverContext context) { }

	protected virtual object VisitRootCache(ServiceCallSite callSite, RuntimeResolverContext context) { }

	protected virtual object VisitScopeCache(ServiceCallSite callSite, RuntimeResolverContext context) { }

	protected virtual object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, RuntimeResolverContext context) { }

}

