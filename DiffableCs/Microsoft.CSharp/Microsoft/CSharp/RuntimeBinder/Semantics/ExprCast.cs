namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprCast : ExprWithType
{
	[CompilerGenerated]
	private Expr <Argument>k__BackingField; //Field offset: 0x40

	public Expr Argument
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool IsBoxingCast
	{
		 get { } //Length: 8
	}

	public virtual object Object
	{
		 get { } //Length: 108
	}

	public ExprCast(EXPRFLAG flags, CType type, Expr argument) { }

	[CompilerGenerated]
	public Expr get_Argument() { }

	public bool get_IsBoxingCast() { }

	public virtual object get_Object() { }

	[CompilerGenerated]
	public void set_Argument(Expr value) { }

}

