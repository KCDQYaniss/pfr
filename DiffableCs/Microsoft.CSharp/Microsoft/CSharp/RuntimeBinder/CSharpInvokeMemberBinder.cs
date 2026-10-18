namespace Microsoft.CSharp.RuntimeBinder;

internal sealed class CSharpInvokeMemberBinder : InvokeMemberBinder, ICSharpInvokeOrInvokeMemberBinder, ICSharpBinder
{
	[CompilerGenerated]
	private readonly CSharpCallFlags <Flags>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly Type <CallingContext>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly Type[] <TypeArguments>k__BackingField; //Field offset: 0x40
	private readonly CSharpArgumentInfo[] _argumentInfo; //Field offset: 0x48
	private readonly RuntimeBinder _binder; //Field offset: 0x50

	public override BindingFlag BindingFlags
	{
		 get { } //Length: 3
	}

	public Type CallingContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override CSharpCallFlags Flags
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override bool IsBinderThatCanHaveRefReceiver
	{
		 get { } //Length: 3
	}

	private override bool Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.ResultDiscarded
	{
		private get { } //Length: 8
	}

	private override bool Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.StaticCall
	{
		private get { } //Length: 58
	}

	public override Type[] TypeArguments
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CSharpInvokeMemberBinder(CSharpCallFlags flags, string name, Type callingContext, IEnumerable typeArguments, IEnumerable argumentInfo) { }

	public CSharpArgumentInfo[] ArgumentInfoArray() { }

	public override Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	public virtual DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	public virtual DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	public override BindingFlag get_BindingFlags() { }

	[CompilerGenerated]
	public Type get_CallingContext() { }

	[CompilerGenerated]
	public override CSharpCallFlags get_Flags() { }

	public override bool get_IsBinderThatCanHaveRefReceiver() { }

	[CompilerGenerated]
	public override Type[] get_TypeArguments() { }

	public override CSharpArgumentInfo GetArgumentInfo(int index) { }

	private override string Microsoft.CSharp.RuntimeBinder.ICSharpBinder.get_Name() { }

	private override bool Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.get_ResultDiscarded() { }

	private override bool Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.get_StaticCall() { }

	public override void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments) { }

}

