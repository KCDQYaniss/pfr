namespace System.Dynamic;

public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly ExpressionType <Operation>k__BackingField; //Field offset: 0x18

	public ExpressionType Operation
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 137
	}

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) { }

	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public ExpressionType get_Operation() { }

	public virtual Type get_ReturnType() { }

}

