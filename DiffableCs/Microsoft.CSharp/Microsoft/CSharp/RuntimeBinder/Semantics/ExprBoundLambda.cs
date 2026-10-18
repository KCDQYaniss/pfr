namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprBoundLambda : ExprWithType
{
	[CompilerGenerated]
	private readonly Expr <Expression>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Scope <ArgumentScope>k__BackingField; //Field offset: 0x48

	public Scope ArgumentScope
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AggregateType DelegateType
	{
		 get { } //Length: 73
	}

	public Expr Expression
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExprBoundLambda(AggregateType type, Scope argumentScope, Expr expression) { }

	[CompilerGenerated]
	public Scope get_ArgumentScope() { }

	public AggregateType get_DelegateType() { }

	[CompilerGenerated]
	public Expr get_Expression() { }

}

