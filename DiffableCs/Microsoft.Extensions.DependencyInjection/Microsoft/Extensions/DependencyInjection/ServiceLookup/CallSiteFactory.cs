namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal sealed class CallSiteFactory : IServiceProviderIsService, IServiceProviderIsKeyedService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8
		public static Comparison <>9__19_0; //Field offset: 0x10
		public static Comparison <>9__23_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal object <CreateCallSite>b__16_0(ServiceIdentifier _) { }

		internal int <CreateConstructorCallSite>b__23_0(ConstructorInfo a, ConstructorInfo b) { }

		internal int <TryCreateEnumerable>b__19_0(KeyValuePair a, KeyValuePair b) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass19_0
	{
		public CallSiteResultCacheLocation cacheLocation; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass19_1
	{
		public int slot; //Field offset: 0x0
		public List callSitesByIndex; //Field offset: 0x8

	}

	[DefaultMember("Item")]
	private struct ServiceDescriptorCacheItem
	{
		[DisallowNull]
		private ServiceDescriptor _item; //Field offset: 0x0
		[DisallowNull]
		private List _items; //Field offset: 0x8

		public int Count
		{
			 get { } //Length: 84
		}

		public ServiceDescriptor Item
		{
			 get { } //Length: 279
		}

		public ServiceDescriptor Last
		{
			 get { } //Length: 147
		}

		public ServiceDescriptorCacheItem Add(ServiceDescriptor descriptor) { }

		public int get_Count() { }

		public ServiceDescriptor get_Item(int index) { }

		public ServiceDescriptor get_Last() { }

		public int GetSlot(ServiceDescriptor descriptor) { }

	}

	private readonly ServiceDescriptor[] _descriptors; //Field offset: 0x10
	private readonly ConcurrentDictionary _callSiteCache; //Field offset: 0x18
	private readonly Dictionary _descriptorLookup; //Field offset: 0x20
	private readonly ConcurrentDictionary _callSiteLocks; //Field offset: 0x28
	private readonly StackGuard _stackGuard; //Field offset: 0x30

	internal ServiceDescriptor[] Descriptors
	{
		internal get { } //Length: 5
	}

	public CallSiteFactory(ICollection descriptors) { }

	[CompilerGenerated]
	internal static void <TryCreateEnumerable>g__AddCallSite|19_1(ServiceCallSite callSite, int index, ref <>c__DisplayClass19_0 unnamed_param_2, ref <>c__DisplayClass19_1 unnamed_param_3) { }

	public void Add(ServiceIdentifier serviceIdentifier, ServiceCallSite serviceCallSite) { }

	private static bool AreCompatible(DynamicallyAccessedMemberTypes serviceDynamicallyAccessedMembers, DynamicallyAccessedMemberTypes implementationDynamicallyAccessedMembers) { }

	private ServiceCallSite[] CreateArgumentCallSites(ServiceIdentifier serviceIdentifier, Type implementationType, CallSiteChain callSiteChain, ParameterInfo[] parameters, bool throwIfCallSiteNotFound) { }

	private ServiceCallSite CreateCallSite(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain) { }

	private ConstructorCallSite CreateConstructorCallSite(ResultCache lifetime, ServiceIdentifier serviceIdentifier, Type implementationType, CallSiteChain callSiteChain) { }

	internal ServiceDescriptor[] get_Descriptors() { }

	internal ServiceCallSite GetCallSite(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain) { }

	internal ServiceCallSite GetCallSite(ServiceDescriptor serviceDescriptor, CallSiteChain callSiteChain) { }

	private static CallSiteResultCacheLocation GetCommonCacheLocation(CallSiteResultCacheLocation locationA, CallSiteResultCacheLocation locationB) { }

	private static DynamicallyAccessedMemberTypes GetDynamicallyAccessedMemberTypes(Type serviceGenericType) { }

	private static bool KeysMatch(object key1, object key2) { }

	private void Populate() { }

	private ServiceCallSite TryCreateEnumerable(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain) { }

	private ServiceCallSite TryCreateExact(ServiceDescriptor descriptor, ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain, int slot) { }

	private ServiceCallSite TryCreateExact(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain) { }

	[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "When ServiceProvider.VerifyAotCompatibility is true, which it is by default when PublishAot=true, this method ensures the generic types being created aren't using ValueTypes.")]
	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:MakeGenericType", Justification = "MakeGenericType here is used to create a closed generic implementation type given the closed service type. Trimming annotations on the generic types are verified when 'Microsoft.Extensions.DependencyInjection.VerifyOpenGenericServiceTrimmability' is set, which is set by default when PublishTrimmed=true. That check informs developers when these generic types don't have compatible trimming annotations.")]
	private ServiceCallSite TryCreateOpenGeneric(ServiceDescriptor descriptor, ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain, int slot, bool throwOnConstraintViolation) { }

	private ServiceCallSite TryCreateOpenGeneric(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain) { }

	private static void ValidateTrimmingAnnotations(Type serviceType, Type[] serviceTypeGenericArguments, Type implementationType, Type[] implementationTypeGenericArguments) { }

	private static void VerifyOpenGenericAotCompatibility(Type serviceType, Type[] genericTypeArguments) { }

}

