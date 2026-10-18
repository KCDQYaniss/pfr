namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprMemberGroup : ExprWithType
{
	[CompilerGenerated]
	private readonly Name <Name>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly TypeArray <TypeArgs>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly SYMKIND <SymKind>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Expr <OptionalObject>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Expr <OptionalLHS>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly CMemberLookupResults <MemberLookupResults>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly CType <ParentType>k__BackingField; //Field offset: 0x70

	public bool IsDelegate
	{
		 get { } //Length: 11
	}

	public CMemberLookupResults MemberLookupResults
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Name Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Expr OptionalLHS
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Expr OptionalObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public CType ParentType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public SYMKIND SymKind
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public TypeArray TypeArgs
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExprMemberGroup(EXPRFLAG flags, Name name, TypeArray typeArgs, SYMKIND symKind, CType parentType, Expr optionalObject, CMemberLookupResults memberLookupResults) { }

	public bool get_IsDelegate() { }

	[CompilerGenerated]
	public CMemberLookupResults get_MemberLookupResults() { }

	[CompilerGenerated]
	public Name get_Name() { }

	[CompilerGenerated]
	public Expr get_OptionalObject() { }

	[CompilerGenerated]
	public CType get_ParentType() { }

	[CompilerGenerated]
	public SYMKIND get_SymKind() { }

	[CompilerGenerated]
	public TypeArray get_TypeArgs() { }

	[CompilerGenerated]
	public void set_OptionalLHS(Expr value) { }

	[CompilerGenerated]
	public void set_OptionalObject(Expr value) { }

}

