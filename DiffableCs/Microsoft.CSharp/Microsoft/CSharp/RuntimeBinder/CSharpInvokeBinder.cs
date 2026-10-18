namespace Microsoft.CSharp.RuntimeBinder;

internal sealed class CSharpInvokeBinder : InvokeBinder, ICSharpInvokeOrInvokeMemberBinder, ICSharpBinder
{
	private readonly CSharpCallFlags _flags; //Field offset: 0x20
	private readonly CSharpArgumentInfo[] _argumentInfo; //Field offset: 0x28
	private readonly RuntimeBinder _binder; //Field offset: 0x30

	public override BindingFlag BindingFlags
	{
		 get { } //Length: 3
	}

	public override bool IsBinderThatCanHaveRefReceiver
	{
		 get { } //Length: 3
	}

	private override string Microsoft.CSharp.RuntimeBinder.ICSharpBinder.Name
	{
		private get { } //Length: 49
	}

	private override CSharpCallFlags Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.Flags
	{
		private get { } //Length: 4
	}

	private override bool Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.ResultDiscarded
	{
		private get { } //Length: 8
	}

	private override bool Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.StaticCall
	{
		private get { } //Length: 65
	}

	private override Type[] Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.TypeArguments
	{
		private get { } //Length: 53
	}

	public CSharpInvokeBinder(CSharpCallFlags flags, Type callingContext, IEnumerable argumentInfo) { }

	public override Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	public virtual DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	public override BindingFlag get_BindingFlags() { }

	public override bool get_IsBinderThatCanHaveRefReceiver() { }

	private override string Microsoft.CSharp.RuntimeBinder.ICSharpBinder.get_Name() { }

	private override CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.ICSharpBinder.GetArgumentInfo(int index) { }

	private override CSharpCallFlags Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.get_Flags() { }

	private override bool Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.get_ResultDiscarded() { }

	private override bool Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.get_StaticCall() { }

	private override Type[] Microsoft.CSharp.RuntimeBinder.ICSharpInvokeOrInvokeMemberBinder.get_TypeArguments() { }

	public override void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments) { }

}

