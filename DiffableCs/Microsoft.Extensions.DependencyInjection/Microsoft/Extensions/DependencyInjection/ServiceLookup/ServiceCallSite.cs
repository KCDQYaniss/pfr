namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(2)]
internal abstract class ServiceCallSite
{
	[CompilerGenerated]
	private readonly ResultCache <Cache>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private object <Value>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private object <Key>k__BackingField; //Field offset: 0x38

	public ResultCache Cache
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public bool CaptureDisposable
	{
		 get { } //Length: 361
	}

	public abstract Type ImplementationType
	{
		 get { } //Length: 0
	}

	public object Key
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public abstract CallSiteKind Kind
	{
		 get { } //Length: 0
	}

	[Nullable(1)]
	public abstract Type ServiceType
	{
		[NullableContext(1)]
		 get { } //Length: 0
	}

	public object Value
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected ServiceCallSite(ResultCache cache) { }

	[CompilerGenerated]
	public ResultCache get_Cache() { }

	public bool get_CaptureDisposable() { }

	public abstract Type get_ImplementationType() { }

	[CompilerGenerated]
	public object get_Key() { }

	public abstract CallSiteKind get_Kind() { }

	[NullableContext(1)]
	public abstract Type get_ServiceType() { }

	[CompilerGenerated]
	public object get_Value() { }

	[CompilerGenerated]
	public void set_Key(object value) { }

	[CompilerGenerated]
	public void set_Value(object value) { }

}

