namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[IsReadOnly]
internal struct UdConvInfo
{
	public readonly MethWithType Meth; //Field offset: 0x0
	public readonly bool SrcImplicit; //Field offset: 0x8
	public readonly bool DstImplicit; //Field offset: 0x9

	public UdConvInfo(MethWithType mwt, bool srcImplicit, bool dstImplicit) { }

}

