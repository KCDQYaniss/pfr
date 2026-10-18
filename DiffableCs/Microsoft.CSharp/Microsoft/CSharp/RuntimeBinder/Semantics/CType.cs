namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class CType
{
	[CompilerGenerated]
	private readonly TypeKind <TypeKind>k__BackingField; //Field offset: 0x10

	[ExcludeFromCodeCoverage]
	public override Type AssociatedSystemType
	{
		 get { } //Length: 39
	}

	public override CType BaseOrParameterOrElementType
	{
		 get { } //Length: 3
	}

	public override ConstValKind ConstValKind
	{
		 get { } //Length: 3
	}

	public override FUNDTYPE FundamentalType
	{
		 get { } //Length: 3
	}

	public override bool IsClassType
	{
		 get { } //Length: 3
	}

	public override bool IsDelegateType
	{
		 get { } //Length: 3
	}

	public override bool IsEnumType
	{
		 get { } //Length: 3
	}

	public override bool IsInterfaceType
	{
		 get { } //Length: 3
	}

	public override bool IsNonNullableValueType
	{
		 get { } //Length: 3
	}

	public override bool IsNumericType
	{
		 get { } //Length: 3
	}

	public override bool IsPredefined
	{
		 get { } //Length: 3
	}

	public override bool IsReferenceType
	{
		 get { } //Length: 3
	}

	public override bool IsSimpleOrEnum
	{
		 get { } //Length: 3
	}

	public override bool IsSimpleOrEnumOrString
	{
		 get { } //Length: 3
	}

	public override bool IsSimpleType
	{
		 get { } //Length: 3
	}

	public override bool IsStaticClass
	{
		 get { } //Length: 3
	}

	public override bool IsStructType
	{
		 get { } //Length: 3
	}

	public override bool IsValueType
	{
		 get { } //Length: 3
	}

	public bool IsWindowsRuntimeType
	{
		 get { } //Length: 69
	}

	[ExcludeFromCodeCoverage]
	public override PredefinedType PredefinedType
	{
		 get { } //Length: 39
	}

	public TypeKind TypeKind
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	[ExcludeFromCodeCoverage]
	public override AggregateType UnderlyingEnumType
	{
		 get { } //Length: 39
	}

	 CType(TypeKind kind) { }

	public override Type get_AssociatedSystemType() { }

	public override CType get_BaseOrParameterOrElementType() { }

	public override ConstValKind get_ConstValKind() { }

	public override FUNDTYPE get_FundamentalType() { }

	public override bool get_IsClassType() { }

	public override bool get_IsDelegateType() { }

	public override bool get_IsEnumType() { }

	public override bool get_IsInterfaceType() { }

	public override bool get_IsNonNullableValueType() { }

	public override bool get_IsNumericType() { }

	public override bool get_IsPredefined() { }

	public override bool get_IsReferenceType() { }

	public override bool get_IsSimpleOrEnum() { }

	public override bool get_IsSimpleOrEnumOrString() { }

	public override bool get_IsSimpleType() { }

	public override bool get_IsStaticClass() { }

	public override bool get_IsStructType() { }

	public override bool get_IsValueType() { }

	public bool get_IsWindowsRuntimeType() { }

	public override PredefinedType get_PredefinedType() { }

	[CompilerGenerated]
	public TypeKind get_TypeKind() { }

	public override AggregateType get_UnderlyingEnumType() { }

	[ExcludeFromCodeCoverage]
	public override AggregateType GetAts() { }

	public CType GetNakedType(bool fStripNub) { }

	public override bool IsPredefType(PredefinedType pt) { }

	public override bool IsUnsafe() { }

	public override CType StripNubs(out bool wasNullable) { }

	public override CType StripNubs() { }

}

