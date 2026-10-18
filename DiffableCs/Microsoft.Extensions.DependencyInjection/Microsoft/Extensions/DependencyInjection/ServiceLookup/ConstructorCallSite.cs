namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal sealed class ConstructorCallSite : ServiceCallSite
{
	[CompilerGenerated]
	private readonly ConstructorInfo <ConstructorInfo>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly ServiceCallSite[] <ParameterCallSites>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly Type <ServiceType>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly CallSiteKind <Kind>k__BackingField; //Field offset: 0x58

	internal ConstructorInfo ConstructorInfo
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	[Nullable(2)]
	public virtual Type ImplementationType
	{
		[NullableContext(2)]
		 get { } //Length: 42
	}

	public virtual CallSiteKind Kind
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	internal ServiceCallSite[] ParameterCallSites
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public virtual Type ServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ConstructorCallSite(ResultCache cache, Type serviceType, ConstructorInfo constructorInfo) { }

	public ConstructorCallSite(ResultCache cache, Type serviceType, ConstructorInfo constructorInfo, ServiceCallSite[] parameterCallSites) { }

	[CompilerGenerated]
	internal ConstructorInfo get_ConstructorInfo() { }

	[NullableContext(2)]
	public virtual Type get_ImplementationType() { }

	[CompilerGenerated]
	public virtual CallSiteKind get_Kind() { }

	[CompilerGenerated]
	internal ServiceCallSite[] get_ParameterCallSites() { }

	[CompilerGenerated]
	public virtual Type get_ServiceType() { }

}

