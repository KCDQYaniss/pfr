namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class NullType : CType
{
	public static readonly NullType Instance; //Field offset: 0x0

	public virtual ConstValKind ConstValKind
	{
		 get { } //Length: 6
	}

	public virtual FUNDTYPE FundamentalType
	{
		 get { } //Length: 6
	}

	public virtual bool IsReferenceType
	{
		 get { } //Length: 3
	}

	private static NullType() { }

	private NullType() { }

	public virtual ConstValKind get_ConstValKind() { }

	public virtual FUNDTYPE get_FundamentalType() { }

	public virtual bool get_IsReferenceType() { }

}

