namespace System.Dynamic;

public abstract class ConvertBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <Explicit>k__BackingField; //Field offset: 0x20

	public bool Explicit
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal virtual bool IsStandardBinder
	{
		internal get { } //Length: 3
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 5
	}

	public Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected ConvertBinder(Type type, bool explicit) { }

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public bool get_Explicit() { }

	internal virtual bool get_IsStandardBinder() { }

	public virtual Type get_ReturnType() { }

	[CompilerGenerated]
	public Type get_Type() { }

}

