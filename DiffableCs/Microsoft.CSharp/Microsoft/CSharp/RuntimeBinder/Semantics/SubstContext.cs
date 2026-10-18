namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class SubstContext
{
	public readonly CType[] ClassTypes; //Field offset: 0x10
	public readonly CType[] MethodTypes; //Field offset: 0x18
	public readonly bool DenormMeth; //Field offset: 0x20

	public bool IsNop
	{
		 get { } //Length: 48
	}

	public SubstContext(TypeArray typeArgsCls, TypeArray typeArgsMeth, bool denormMeth) { }

	public SubstContext(AggregateType type) { }

	public SubstContext(AggregateType type, TypeArray typeArgsMeth) { }

	private SubstContext(AggregateType type, TypeArray typeArgsMeth, bool denormMeth) { }

	public bool get_IsNop() { }

}

