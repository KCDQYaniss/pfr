namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal abstract class CallSiteVisitor`2
{
	private readonly StackGuard _stackGuard; //Field offset: 0x0

	protected CallSiteVisitor`2() { }

	protected override TResult VisitCallSite(ServiceCallSite callSite, TArgument argument) { }

	protected override TResult VisitCallSiteMain(ServiceCallSite callSite, TArgument argument) { }

	protected abstract TResult VisitConstant(ConstantCallSite constantCallSite, TArgument argument) { }

	protected abstract TResult VisitConstructor(ConstructorCallSite constructorCallSite, TArgument argument) { }

	protected override TResult VisitDisposeCache(ServiceCallSite callSite, TArgument argument) { }

	protected abstract TResult VisitFactory(FactoryCallSite factoryCallSite, TArgument argument) { }

	protected abstract TResult VisitIEnumerable(IEnumerableCallSite enumerableCallSite, TArgument argument) { }

	protected override TResult VisitNoCache(ServiceCallSite callSite, TArgument argument) { }

	protected override TResult VisitRootCache(ServiceCallSite callSite, TArgument argument) { }

	protected override TResult VisitScopeCache(ServiceCallSite callSite, TArgument argument) { }

	protected abstract TResult VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, TArgument argument) { }

}

