namespace Microsoft.CSharp.RuntimeBinder;

internal sealed class CSharpUnaryOperationBinder : UnaryOperationBinder, ICSharpBinder
{
	private readonly CSharpArgumentInfo[] _argumentInfo; //Field offset: 0x20
	private readonly RuntimeBinder _binder; //Field offset: 0x28

	public override BindingFlag BindingFlags
	{
		 get { } //Length: 3
	}

	public override bool IsBinderThatCanHaveRefReceiver
	{
		 get { } //Length: 3
	}

	[ExcludeFromCodeCoverage]
	public override string Name
	{
		 get { } //Length: 3
	}

	public override Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	public virtual DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	public override BindingFlag get_BindingFlags() { }

	public override bool get_IsBinderThatCanHaveRefReceiver() { }

	public override string get_Name() { }

	private override CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.ICSharpBinder.GetArgumentInfo(int index) { }

	public override void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments) { }

}

