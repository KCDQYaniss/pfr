namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal sealed class FactoryCallSite : ServiceCallSite
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Func factory; //Field offset: 0x10
		public object serviceKey; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal object <.ctor>b__0(IServiceProvider sp) { }

	}

	[CompilerGenerated]
	private readonly Func <Factory>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Type <ServiceType>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly CallSiteKind <Kind>k__BackingField; //Field offset: 0x50

	public Func Factory
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public virtual Type ImplementationType
	{
		[NullableContext(2)]
		 get { } //Length: 3
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

	public FactoryCallSite(ResultCache cache, Type serviceType, Func factory) { }

	public FactoryCallSite(ResultCache cache, Type serviceType, object serviceKey, Func factory) { }

	[CompilerGenerated]
	public Func get_Factory() { }

	[NullableContext(2)]
	public virtual Type get_ImplementationType() { }

	[CompilerGenerated]
	public virtual CallSiteKind get_Kind() { }

	[CompilerGenerated]
	public virtual Type get_ServiceType() { }

}

