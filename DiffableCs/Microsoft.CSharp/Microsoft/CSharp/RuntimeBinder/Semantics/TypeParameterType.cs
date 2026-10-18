namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class TypeParameterType : CType
{
	[CompilerGenerated]
	private readonly TypeParameterSymbol <Symbol>k__BackingField; //Field offset: 0x18

	public virtual Type AssociatedSystemType
	{
		 get { } //Length: 377
	}

	public TypeArray Bounds
	{
		 get { } //Length: 27
	}

	public bool Contravariant
	{
		 get { } //Length: 27
	}

	public bool Covariant
	{
		 get { } //Length: 27
	}

	public virtual FUNDTYPE FundamentalType
	{
		 get { } //Length: 6
	}

	public bool HasNewConstraint
	{
		 get { } //Length: 30
	}

	public bool HasRefConstraint
	{
		 get { } //Length: 30
	}

	public bool HasValConstraint
	{
		 get { } //Length: 30
	}

	public int IndexInOwnParameters
	{
		 get { } //Length: 26
	}

	public int IndexInTotalParameters
	{
		 get { } //Length: 26
	}

	public bool Invariant
	{
		 get { } //Length: 43
	}

	public bool IsMethodTypeParameter
	{
		 get { } //Length: 27
	}

	public virtual bool IsNonNullableValueType
	{
		 get { } //Length: 30
	}

	public virtual bool IsReferenceType
	{
		 get { } //Length: 30
	}

	public virtual bool IsValueType
	{
		 get { } //Length: 30
	}

	public Name Name
	{
		 get { } //Length: 27
	}

	public ParentSymbol OwningSymbol
	{
		 get { } //Length: 27
	}

	public TypeParameterSymbol Symbol
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public TypeParameterType(TypeParameterSymbol symbol) { }

	public virtual Type get_AssociatedSystemType() { }

	public TypeArray get_Bounds() { }

	public bool get_Contravariant() { }

	public bool get_Covariant() { }

	public virtual FUNDTYPE get_FundamentalType() { }

	public bool get_HasNewConstraint() { }

	public bool get_HasRefConstraint() { }

	public bool get_HasValConstraint() { }

	public int get_IndexInOwnParameters() { }

	public int get_IndexInTotalParameters() { }

	public bool get_Invariant() { }

	public bool get_IsMethodTypeParameter() { }

	public virtual bool get_IsNonNullableValueType() { }

	public virtual bool get_IsReferenceType() { }

	public virtual bool get_IsValueType() { }

	public Name get_Name() { }

	public ParentSymbol get_OwningSymbol() { }

	[CompilerGenerated]
	public TypeParameterSymbol get_Symbol() { }

}

