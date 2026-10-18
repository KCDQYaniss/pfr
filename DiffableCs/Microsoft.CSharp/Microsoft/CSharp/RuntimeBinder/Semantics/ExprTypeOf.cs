namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprTypeOf : ExprWithType
{
	[CompilerGenerated]
	private readonly CType <SourceType>k__BackingField; //Field offset: 0x40

	public virtual object Object
	{
		 get { } //Length: 42
	}

	public CType SourceType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExprTypeOf(CType type, CType sourceType) { }

	public virtual object get_Object() { }

	[CompilerGenerated]
	public CType get_SourceType() { }

}

