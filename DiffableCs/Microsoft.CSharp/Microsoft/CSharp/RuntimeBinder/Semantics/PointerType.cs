namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class PointerType : CType
{
	[CompilerGenerated]
	private readonly CType <ReferentType>k__BackingField; //Field offset: 0x18

	public virtual Type AssociatedSystemType
	{
		 get { } //Length: 69
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

	public CType ReferentType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PointerType(CType referentType) { }

	public virtual Type get_AssociatedSystemType() { }

	public virtual CType get_BaseOrParameterOrElementType() { }

	public virtual ConstValKind get_ConstValKind() { }

	public virtual FUNDTYPE get_FundamentalType() { }

	[CompilerGenerated]
	public CType get_ReferentType() { }

	public virtual bool IsUnsafe() { }

}

