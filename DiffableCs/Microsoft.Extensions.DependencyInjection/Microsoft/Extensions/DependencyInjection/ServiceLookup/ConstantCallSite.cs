namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal sealed class ConstantCallSite : ServiceCallSite
{
	private readonly Type _serviceType; //Field offset: 0x40
	[CompilerGenerated]
	private readonly CallSiteKind <Kind>k__BackingField; //Field offset: 0x48

	[Nullable(2)]
	internal object DefaultValue
	{
		[NullableContext(2)]
		internal get { } //Length: 76
	}

	public virtual Type ImplementationType
	{
		 get { } //Length: 45
	}

	public virtual CallSiteKind Kind
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual Type ServiceType
	{
		 get { } //Length: 5
	}

	public ConstantCallSite(Type serviceType, object defaultValue) { }

	[NullableContext(2)]
	internal object get_DefaultValue() { }

	public virtual Type get_ImplementationType() { }

	[CompilerGenerated]
	public virtual CallSiteKind get_Kind() { }

	public virtual Type get_ServiceType() { }

}

