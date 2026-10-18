namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprAssignment : Expr
{
	private Expr _lhs; //Field offset: 0x40
	[CompilerGenerated]
	private Expr <RHS>k__BackingField; //Field offset: 0x48

	public Expr LHS
	{
		 get { } //Length: 5
		 set { } //Length: 211
	}

	public Expr RHS
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExprAssignment(Expr lhs, Expr rhs) { }

	public Expr get_LHS() { }

	[CompilerGenerated]
	public Expr get_RHS() { }

	public void set_LHS(Expr value) { }

	[CompilerGenerated]
	public void set_RHS(Expr value) { }

}

