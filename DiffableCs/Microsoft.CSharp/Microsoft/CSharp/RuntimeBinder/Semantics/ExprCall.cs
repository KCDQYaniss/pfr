namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprCall : ExprWithArgs
{
	[CompilerGenerated]
	private MethWithInst <MethWithInst>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private PREDEFMETH <PredefinedMethod>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private NullableCallLiftKind <NullableCallLiftKind>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private Expr <PConversions>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Expr <CastOfNonLiftedResultToLiftedType>k__BackingField; //Field offset: 0x68

	public Expr CastOfNonLiftedResultToLiftedType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MethWithInst MethWithInst
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public NullableCallLiftKind NullableCallLiftKind
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Expr PConversions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public PREDEFMETH PredefinedMethod
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ExprCall(CType type, EXPRFLAG flags, Expr arguments, ExprMemberGroup member, MethWithInst method) { }

	[CompilerGenerated]
	public Expr get_CastOfNonLiftedResultToLiftedType() { }

	[CompilerGenerated]
	public MethWithInst get_MethWithInst() { }

	[CompilerGenerated]
	public NullableCallLiftKind get_NullableCallLiftKind() { }

	[CompilerGenerated]
	public Expr get_PConversions() { }

	[CompilerGenerated]
	public PREDEFMETH get_PredefinedMethod() { }

	public virtual SymWithType GetSymWithType() { }

	[CompilerGenerated]
	public void set_CastOfNonLiftedResultToLiftedType(Expr value) { }

	[CompilerGenerated]
	public void set_MethWithInst(MethWithInst value) { }

	[CompilerGenerated]
	public void set_NullableCallLiftKind(NullableCallLiftKind value) { }

	[CompilerGenerated]
	public void set_PConversions(Expr value) { }

	[CompilerGenerated]
	public void set_PredefinedMethod(PREDEFMETH value) { }

}

