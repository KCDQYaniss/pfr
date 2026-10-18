namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal class MethPropWithInst : MethPropWithType
{
	[CompilerGenerated]
	private TypeArray <TypeArgs>k__BackingField; //Field offset: 0x20

	public private TypeArray TypeArgs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public MethPropWithInst() { }

	public MethPropWithInst(MethodOrPropertySymbol mps, AggregateType ats) { }

	public MethPropWithInst(MethodOrPropertySymbol mps, AggregateType ats, TypeArray typeArgs) { }

	public virtual void Clear() { }

	[CompilerGenerated]
	public TypeArray get_TypeArgs() { }

	public void Set(MethodOrPropertySymbol mps, AggregateType ats, TypeArray typeArgs) { }

	[CompilerGenerated]
	private void set_TypeArgs(TypeArray value) { }

}

