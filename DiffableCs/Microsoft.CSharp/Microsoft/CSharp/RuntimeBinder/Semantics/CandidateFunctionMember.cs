namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class CandidateFunctionMember
{
	public MethPropWithInst mpwi; //Field offset: 0x10
	public TypeArray params; //Field offset: 0x18
	public byte ctypeLift; //Field offset: 0x20
	public bool fExpanded; //Field offset: 0x21

	public CandidateFunctionMember(MethPropWithInst mpwi, TypeArray params, byte ctypeLift, bool fExpanded) { }

}

