namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class NullableType : CType
{
	private AggregateType _ats; //Field offset: 0x18
	[CompilerGenerated]
	private readonly CType <UnderlyingType>k__BackingField; //Field offset: 0x20

	public virtual Type AssociatedSystemType
	{
		 get { } //Length: 356
	}

	public virtual CType BaseOrParameterOrElementType
	{
		 get { } //Length: 5
	}

	[ExcludeFromCodeCoverage]
	public virtual ConstValKind ConstValKind
	{
		 get { } //Length: 6
	}

	public virtual FUNDTYPE FundamentalType
	{
		 get { } //Length: 6
	}

	public virtual bool IsStructType
	{
		 get { } //Length: 3
	}

	public virtual bool IsValueType
	{
		 get { } //Length: 3
	}

	public CType UnderlyingType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public NullableType(CType underlyingType) { }

	public virtual Type get_AssociatedSystemType() { }

	public virtual CType get_BaseOrParameterOrElementType() { }

	public virtual ConstValKind get_ConstValKind() { }

	public virtual FUNDTYPE get_FundamentalType() { }

	public virtual bool get_IsStructType() { }

	public virtual bool get_IsValueType() { }

	[CompilerGenerated]
	public CType get_UnderlyingType() { }

	public virtual AggregateType GetAts() { }

	public virtual CType StripNubs() { }

	public virtual CType StripNubs(out bool wasNullable) { }

}

