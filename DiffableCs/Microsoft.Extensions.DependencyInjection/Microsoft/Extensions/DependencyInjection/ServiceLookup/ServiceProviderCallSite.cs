namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal sealed class ServiceProviderCallSite : ServiceCallSite
{
	[CompilerGenerated]
	private readonly Type <ServiceType>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Type <ImplementationType>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly CallSiteKind <Kind>k__BackingField; //Field offset: 0x50

	public virtual Type ImplementationType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual CallSiteKind Kind
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual Type ServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ServiceProviderCallSite() { }

	[CompilerGenerated]
	public virtual Type get_ImplementationType() { }

	[CompilerGenerated]
	public virtual CallSiteKind get_Kind() { }

	[CompilerGenerated]
	public virtual Type get_ServiceType() { }

}

