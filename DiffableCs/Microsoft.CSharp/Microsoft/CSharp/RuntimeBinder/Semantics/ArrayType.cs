namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ArrayType : CType
{
	[CompilerGenerated]
	private readonly int <Rank>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <IsSZArray>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly CType <ElementType>k__BackingField; //Field offset: 0x20

	public virtual Type AssociatedSystemType
	{
		 get { } //Length: 114
	}

	public CType BaseElementType
	{
		 get { } //Length: 84
	}

	public virtual CType BaseOrParameterOrElementType
	{
		 get { } //Length: 5
	}

	public virtual ConstValKind ConstValKind
	{
		 get { } //Length: 6
	}

	public CType ElementType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual FUNDTYPE FundamentalType
	{
		 get { } //Length: 6
	}

	public virtual bool IsReferenceType
	{
		 get { } //Length: 3
	}

	public bool IsSZArray
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int Rank
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public ArrayType(CType elementType, int rank, bool isSZArray) { }

	public virtual Type get_AssociatedSystemType() { }

	public CType get_BaseElementType() { }

	public virtual CType get_BaseOrParameterOrElementType() { }

	public virtual ConstValKind get_ConstValKind() { }

	[CompilerGenerated]
	public CType get_ElementType() { }

	public virtual FUNDTYPE get_FundamentalType() { }

	public virtual bool get_IsReferenceType() { }

	[CompilerGenerated]
	public bool get_IsSZArray() { }

	[CompilerGenerated]
	public int get_Rank() { }

	public virtual AggregateType GetAts() { }

	public virtual bool IsUnsafe() { }

}

