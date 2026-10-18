namespace Microsoft.CSharp.RuntimeBinder;

internal interface ICSharpBinder
{

	public BindingFlag BindingFlags
	{
		 get { } //Length: 0
	}

	public bool IsBinderThatCanHaveRefReceiver
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public Type ReturnType
	{
		 get { } //Length: 0
	}

	public Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	public BindingFlag get_BindingFlags() { }

	public bool get_IsBinderThatCanHaveRefReceiver() { }

	public string get_Name() { }

	public Type get_ReturnType() { }

	public CSharpArgumentInfo GetArgumentInfo(int index) { }

	public void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments) { }

}

