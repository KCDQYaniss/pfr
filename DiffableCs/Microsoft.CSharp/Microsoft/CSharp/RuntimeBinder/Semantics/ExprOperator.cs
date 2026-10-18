namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class ExprOperator : ExprWithType
{
	[CompilerGenerated]
	private readonly Expr <OptionalUserDefinedCall>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private MethWithInst <PredefinedMethodToCall>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private MethPropWithInst <UserDefinedCallMethod>k__BackingField; //Field offset: 0x50

	public Expr OptionalUserDefinedCall
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MethWithInst PredefinedMethodToCall
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MethPropWithInst UserDefinedCallMethod
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected ExprOperator(ExpressionKind kind, CType type) { }

	protected ExprOperator(ExpressionKind kind, CType type, Expr call, MethPropWithInst userDefinedMethod) { }

	[CompilerGenerated]
	public Expr get_OptionalUserDefinedCall() { }

	[CompilerGenerated]
	public MethWithInst get_PredefinedMethodToCall() { }

	[CompilerGenerated]
	public MethPropWithInst get_UserDefinedCallMethod() { }

	[CompilerGenerated]
	public void set_PredefinedMethodToCall(MethWithInst value) { }

	[CompilerGenerated]
	public void set_UserDefinedCallMethod(MethPropWithInst value) { }

}

