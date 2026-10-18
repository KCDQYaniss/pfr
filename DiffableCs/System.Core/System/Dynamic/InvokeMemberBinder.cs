namespace System.Dynamic;

public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly CallInfo <CallInfo>k__BackingField; //Field offset: 0x28

	public bool IgnoreCase
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal virtual bool IsStandardBinder
	{
		internal get { } //Length: 3
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 175
	}

	protected InvokeMemberBinder(string name, bool ignoreCase, CallInfo callInfo) { }

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public bool get_IgnoreCase() { }

	internal virtual bool get_IsStandardBinder() { }

	[CompilerGenerated]
	public string get_Name() { }

	public virtual Type get_ReturnType() { }

}

