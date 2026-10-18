namespace System.Dynamic;

public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly ExpressionType <Operation>k__BackingField; //Field offset: 0x18

	internal virtual bool IsStandardBinder
	{
		internal get { } //Length: 3
	}

	public ExpressionType Operation
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 175
	}

	protected BinaryOperationBinder(ExpressionType operation) { }

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) { }

	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion) { }

	internal virtual bool get_IsStandardBinder() { }

	[CompilerGenerated]
	public ExpressionType get_Operation() { }

	public virtual Type get_ReturnType() { }

	internal static bool OperationIsValid(ExpressionType operation) { }

}

