namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewExpressionProxy))]
public class NewExpression : Expression, IArgumentProvider
{
	private IReadOnlyList _arguments; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ConstructorInfo <Constructor>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection <Members>k__BackingField; //Field offset: 0x20

	public override int ArgumentCount
	{
		 get { } //Length: 75
	}

	public ReadOnlyCollection Arguments
	{
		 get { } //Length: 63
	}

	public ConstructorInfo Constructor
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ReadOnlyCollection Members
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		 get { } //Length: 42
	}

	internal NewExpression(ConstructorInfo constructor, IReadOnlyList arguments, ReadOnlyCollection members) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public override int get_ArgumentCount() { }

	public ReadOnlyCollection get_Arguments() { }

	[CompilerGenerated]
	public ConstructorInfo get_Constructor() { }

	[CompilerGenerated]
	public ReadOnlyCollection get_Members() { }

	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

	public override Expression GetArgument(int index) { }

	public NewExpression Update(IEnumerable arguments) { }

}

