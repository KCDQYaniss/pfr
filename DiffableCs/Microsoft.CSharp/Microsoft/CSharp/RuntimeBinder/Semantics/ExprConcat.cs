namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprConcat : ExprWithType
{
	[CompilerGenerated]
	private Expr <FirstArgument>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Expr <SecondArgument>k__BackingField; //Field offset: 0x48

	public Expr FirstArgument
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Expr SecondArgument
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExprConcat(Expr first, Expr second) { }

	[CompilerGenerated]
	public Expr get_FirstArgument() { }

	[CompilerGenerated]
	public Expr get_SecondArgument() { }

	[CompilerGenerated]
	public void set_FirstArgument(Expr value) { }

	[CompilerGenerated]
	public void set_SecondArgument(Expr value) { }

	private static CType TypeFromOperands(Expr first, Expr second) { }

}

