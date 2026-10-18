namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprUserLogicalOp : ExprWithType
{
	[CompilerGenerated]
	private Expr <TrueFalseCall>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private ExprCall <OperatorCall>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Expr <FirstOperandToExamine>k__BackingField; //Field offset: 0x50

	public Expr FirstOperandToExamine
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExprCall OperatorCall
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Expr TrueFalseCall
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExprUserLogicalOp(CType type, Expr trueFalseCall, ExprCall operatorCall) { }

	[CompilerGenerated]
	public Expr get_FirstOperandToExamine() { }

	[CompilerGenerated]
	public ExprCall get_OperatorCall() { }

	[CompilerGenerated]
	public Expr get_TrueFalseCall() { }

	[CompilerGenerated]
	public void set_FirstOperandToExamine(Expr value) { }

	[CompilerGenerated]
	public void set_OperatorCall(ExprCall value) { }

	[CompilerGenerated]
	public void set_TrueFalseCall(Expr value) { }

}

