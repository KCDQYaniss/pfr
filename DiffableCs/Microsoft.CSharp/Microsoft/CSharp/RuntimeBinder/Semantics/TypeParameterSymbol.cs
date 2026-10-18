namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class TypeParameterSymbol : Symbol
{
	private bool _bIsMethodTypeParameter; //Field offset: 0x38
	private SpecCons _constraints; //Field offset: 0x3C
	private TypeParameterType _pTypeParameterType; //Field offset: 0x40
	private int _nIndexInOwnParameters; //Field offset: 0x48
	private int _nIndexInTotalParameters; //Field offset: 0x4C
	private TypeArray _pBounds; //Field offset: 0x50
	public bool Covariant; //Field offset: 0x58
	public bool Contravariant; //Field offset: 0x59

	public bool Invariant
	{
		 get { } //Length: 17
	}

	public TypeParameterSymbol() { }

	public bool get_Invariant() { }

	public TypeArray GetBounds() { }

	public int GetIndexInOwnParameters() { }

	public int GetIndexInTotalParameters() { }

	public TypeParameterType GetTypeParameterType() { }

	public bool HasNewConstraint() { }

	public bool HasRefConstraint() { }

	public bool HasValConstraint() { }

	public bool IsMethodTypeParameter() { }

	public bool IsNonNullableValueType() { }

	public bool IsReferenceType() { }

	public bool IsValueType() { }

	public void SetBounds(TypeArray pBounds) { }

	public void SetConstraints(SpecCons constraints) { }

	public void SetIndexInOwnParameters(int index) { }

	public void SetIndexInTotalParameters(int index) { }

	public void SetIsMethodTypeParameter(bool b) { }

	public void SetTypeParameterType(TypeParameterType pType) { }

}

