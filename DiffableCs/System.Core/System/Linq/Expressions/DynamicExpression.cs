namespace System.Linq.Expressions;

public class DynamicExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	private readonly CallSiteBinder <Binder>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Type <DelegateType>k__BackingField; //Field offset: 0x18

	public ReadOnlyCollection Arguments
	{
		 get { } //Length: 20
	}

	public CallSiteBinder Binder
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual bool CanReduce
	{
		 get { } //Length: 3
	}

	public override Type DelegateType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	[ExcludeFromCodeCoverage]
	private override int System.Linq.Expressions.IArgumentProvider.ArgumentCount
	{
		private get { } //Length: 39
	}

	public virtual Type Type
	{
		 get { } //Length: 175
	}

	internal DynamicExpression(Type delegateType, CallSiteBinder binder) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public ReadOnlyCollection get_Arguments() { }

	[CompilerGenerated]
	public CallSiteBinder get_Binder() { }

	public virtual bool get_CanReduce() { }

	[CompilerGenerated]
	public override Type get_DelegateType() { }

	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

	[ExcludeFromCodeCoverage]
	internal override ReadOnlyCollection GetOrMakeArguments() { }

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2) { }

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1) { }

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0) { }

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, ReadOnlyCollection arguments) { }

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	public virtual Expression Reduce() { }

	[ExcludeFromCodeCoverage]
	internal override DynamicExpression Rewrite(Expression[] args) { }

	private override int System.Linq.Expressions.IArgumentProvider.get_ArgumentCount() { }

	[ExcludeFromCodeCoverage]
	private override Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index) { }

}

