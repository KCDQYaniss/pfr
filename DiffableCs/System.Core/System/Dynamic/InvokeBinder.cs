namespace System.Dynamic;

public abstract class InvokeBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly CallInfo <CallInfo>k__BackingField; //Field offset: 0x18

	internal virtual bool IsStandardBinder
	{
		internal get { } //Length: 3
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 175
	}

	protected InvokeBinder(CallInfo callInfo) { }

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	internal virtual bool get_IsStandardBinder() { }

	public virtual Type get_ReturnType() { }

}

