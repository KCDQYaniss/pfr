namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal sealed class IEnumerableCallSite : ServiceCallSite
{
	[CompilerGenerated]
	private readonly Type <ItemType>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly ServiceCallSite[] <ServiceCallSites>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly CallSiteKind <Kind>k__BackingField; //Field offset: 0x50

	[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "When ServiceProvider.VerifyAotCompatibility is true, which it is by default when PublishAot=true, CallSiteFactory ensures ItemType is not a ValueType.")]
	public virtual Type ImplementationType
	{
		 get { } //Length: 42
	}

	internal Type ItemType
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public virtual CallSiteKind Kind
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	internal ServiceCallSite[] ServiceCallSites
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "When ServiceProvider.VerifyAotCompatibility is true, which it is by default when PublishAot=true, CallSiteFactory ensures ItemType is not a ValueType.")]
	public virtual Type ServiceType
	{
		 get { } //Length: 342
	}

	public IEnumerableCallSite(ResultCache cache, Type itemType, ServiceCallSite[] serviceCallSites) { }

	public virtual Type get_ImplementationType() { }

	[CompilerGenerated]
	internal Type get_ItemType() { }

	[CompilerGenerated]
	public virtual CallSiteKind get_Kind() { }

	[CompilerGenerated]
	internal ServiceCallSite[] get_ServiceCallSites() { }

	public virtual Type get_ServiceType() { }

}

