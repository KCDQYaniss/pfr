namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprUserDefinedConversion : Expr
{
	private Expr _userDefinedCall; //Field offset: 0x40
	[CompilerGenerated]
	private Expr <Argument>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly MethWithInst <UserDefinedCallMethod>k__BackingField; //Field offset: 0x50

	public Expr Argument
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Expr UserDefinedCall
	{
		 get { } //Length: 5
		 set { } //Length: 211
	}

	public MethWithInst UserDefinedCallMethod
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExprUserDefinedConversion(Expr argument, Expr call, MethWithInst method) { }

	[CompilerGenerated]
	public Expr get_Argument() { }

	public Expr get_UserDefinedCall() { }

	[CompilerGenerated]
	public MethWithInst get_UserDefinedCallMethod() { }

	[CompilerGenerated]
	public void set_Argument(Expr value) { }

	public void set_UserDefinedCall(Expr value) { }

}

