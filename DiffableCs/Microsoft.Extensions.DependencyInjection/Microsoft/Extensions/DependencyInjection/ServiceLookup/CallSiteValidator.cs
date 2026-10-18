namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
[NullableContext(1)]
internal sealed class CallSiteValidator : CallSiteVisitor
{
	[Nullable(0)]
	[NullableContext(2)]
	public struct CallSiteValidatorState
	{
		[CompilerGenerated]
		private ServiceCallSite <Singleton>k__BackingField; //Field offset: 0x0

		public ServiceCallSite Singleton
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[CompilerGenerated]
		[IsReadOnly]
		public ServiceCallSite get_Singleton() { }

		[CompilerGenerated]
		public void set_Singleton(ServiceCallSite value) { }

	}

	private readonly ConcurrentDictionary _scopedServices; //Field offset: 0x18

	public CallSiteValidator() { }

	public void ValidateCallSite(ServiceCallSite callSite) { }

	public void ValidateResolution(ServiceCallSite callSite, IServiceScope scope, IServiceScope rootScope) { }

	protected virtual Type VisitCallSite(ServiceCallSite callSite, CallSiteValidatorState argument) { }

	protected virtual Type VisitConstant(ConstantCallSite constantCallSite, CallSiteValidatorState state) { }

	protected virtual Type VisitConstructor(ConstructorCallSite constructorCallSite, CallSiteValidatorState state) { }

	protected virtual Type VisitFactory(FactoryCallSite factoryCallSite, CallSiteValidatorState state) { }

	protected virtual Type VisitIEnumerable(IEnumerableCallSite enumerableCallSite, CallSiteValidatorState state) { }

	protected virtual Type VisitRootCache(ServiceCallSite singletonCallSite, CallSiteValidatorState state) { }

	protected virtual Type VisitScopeCache(ServiceCallSite scopedCallSite, CallSiteValidatorState state) { }

	protected virtual Type VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, CallSiteValidatorState state) { }

}

