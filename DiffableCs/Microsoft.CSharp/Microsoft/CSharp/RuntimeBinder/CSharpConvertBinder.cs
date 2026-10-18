namespace Microsoft.CSharp.RuntimeBinder;

internal sealed class CSharpConvertBinder : ConvertBinder, ICSharpBinder
{
	[CompilerGenerated]
	private readonly CSharpConversionKind <ConversionKind>k__BackingField; //Field offset: 0x28
	private readonly RuntimeBinder _binder; //Field offset: 0x30

	public override BindingFlag BindingFlags
	{
		 get { } //Length: 3
	}

	private CSharpConversionKind ConversionKind
	{
		[CompilerGenerated]
		private get { } //Length: 4
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

	public CSharpConvertBinder(Type type, CSharpConversionKind conversionKind, bool isChecked, Type callingContext) { }

	public override Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	public virtual DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	public override BindingFlag get_BindingFlags() { }

	[CompilerGenerated]
	private CSharpConversionKind get_ConversionKind() { }

	public override bool get_IsBinderThatCanHaveRefReceiver() { }

	public override string get_Name() { }

	private override CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.ICSharpBinder.GetArgumentInfo(int index) { }

	public override void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments) { }

}

