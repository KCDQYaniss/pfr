namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class ExprWithArgs : ExprWithType
{
	[CompilerGenerated]
	private ExprMemberGroup <MemberGroup>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Expr <OptionalArguments>k__BackingField; //Field offset: 0x48

	public ExprMemberGroup MemberGroup
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Expr OptionalArguments
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected ExprWithArgs(ExpressionKind kind, CType type) { }

	[CompilerGenerated]
	public ExprMemberGroup get_MemberGroup() { }

	[CompilerGenerated]
	public Expr get_OptionalArguments() { }

	public abstract SymWithType GetSymWithType() { }

	[CompilerGenerated]
	public void set_MemberGroup(ExprMemberGroup value) { }

	[CompilerGenerated]
	public void set_OptionalArguments(Expr value) { }

}

