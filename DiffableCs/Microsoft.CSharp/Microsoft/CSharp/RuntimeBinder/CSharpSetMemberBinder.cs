namespace Microsoft.CSharp.RuntimeBinder;

internal sealed class CSharpSetMemberBinder : SetMemberBinder, ICSharpBinder
{
	[CompilerGenerated]
	private readonly bool <IsCompoundAssignment>k__BackingField; //Field offset: 0x28
	private readonly CSharpArgumentInfo[] _argumentInfo; //Field offset: 0x30
	private readonly RuntimeBinder _binder; //Field offset: 0x38

	public override BindingFlag BindingFlags
	{
		 get { } //Length: 3
	}

	public override bool IsBinderThatCanHaveRefReceiver
	{
		 get { } //Length: 3
	}

	internal bool IsCompoundAssignment
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public CSharpSetMemberBinder(string name, bool isCompoundAssignment, bool isChecked, Type callingContext, IEnumerable argumentInfo) { }

	public override Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	public virtual DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

	public override BindingFlag get_BindingFlags() { }

	public override bool get_IsBinderThatCanHaveRefReceiver() { }

	[CompilerGenerated]
	internal bool get_IsCompoundAssignment() { }

	private override string Microsoft.CSharp.RuntimeBinder.ICSharpBinder.get_Name() { }

	private override CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.ICSharpBinder.GetArgumentInfo(int index) { }

	public override void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments) { }

}

