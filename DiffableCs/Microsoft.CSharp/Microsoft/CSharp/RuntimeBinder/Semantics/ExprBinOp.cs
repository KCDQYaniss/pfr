namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprBinOp : ExprOperator
{
	[CompilerGenerated]
	private Expr <OptionalLeftChild>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Expr <OptionalRightChild>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <IsLifted>k__BackingField; //Field offset: 0x68

	public bool IsLifted
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Expr OptionalLeftChild
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Expr OptionalRightChild
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExprBinOp(ExpressionKind kind, CType type, Expr left, Expr right) { }

	public ExprBinOp(ExpressionKind kind, CType type, Expr left, Expr right, Expr call, MethPropWithInst userMethod) { }

	[CompilerGenerated]
	public Expr get_OptionalLeftChild() { }

	[CompilerGenerated]
	public Expr get_OptionalRightChild() { }

	[CompilerGenerated]
	public void set_IsLifted(bool value) { }

	[CompilerGenerated]
	public void set_OptionalLeftChild(Expr value) { }

	[CompilerGenerated]
	public void set_OptionalRightChild(Expr value) { }

	public void SetAssignment() { }

}

