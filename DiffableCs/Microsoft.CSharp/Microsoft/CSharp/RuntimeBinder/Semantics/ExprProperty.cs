namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprProperty : ExprWithArgs
{
	[CompilerGenerated]
	private readonly Expr <OptionalObjectThrough>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly PropWithType <PropWithTypeSlot>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly MethWithType <MethWithTypeSet>k__BackingField; //Field offset: 0x60

	public MethWithType MethWithTypeSet
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Expr OptionalObjectThrough
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PropWithType PropWithTypeSlot
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExprProperty(CType type, Expr pOptionalObjectThrough, Expr pOptionalArguments, ExprMemberGroup pMemberGroup, PropWithType pwtSlot, MethWithType mwtSet) { }

	[CompilerGenerated]
	public MethWithType get_MethWithTypeSet() { }

	[CompilerGenerated]
	public Expr get_OptionalObjectThrough() { }

	[CompilerGenerated]
	public PropWithType get_PropWithTypeSlot() { }

	public virtual SymWithType GetSymWithType() { }

}

