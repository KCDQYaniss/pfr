namespace Microsoft.CSharp.RuntimeBinder;

internal sealed class CSharpGetMemberBinder : GetMemberBinder, ICSharpBinder
{
	private readonly CSharpArgumentInfo[] _argumentInfo; //Field offset: 0x28
	[CompilerGenerated]
	private readonly bool <ResultIndexed>k__BackingField; //Field offset: 0x30
	private readonly RuntimeBinder _binder; //Field offset: 0x38

	public override BindingFlag BindingFlags
	{
		 get { } //Length: 6
	}

	public override bool IsBinderThatCanHaveRefReceiver
	{
		 get { } //Length: 3
	}

	public CSharpGetMemberBinder(string name, bool resultIndexed, Type callingContext, IEnumerable argumentInfo) { }

	public override Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	public virtual DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	public override BindingFlag get_BindingFlags() { }

	public override bool get_IsBinderThatCanHaveRefReceiver() { }

	private override string Microsoft.CSharp.RuntimeBinder.ICSharpBinder.get_Name() { }

	private override CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.ICSharpBinder.GetArgumentInfo(int index) { }

	public override void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments) { }

}

