namespace Koenigz.PerfectCulling.EFT;

[IsByRefLike]
[IsReadOnly]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct TemporaryCullingCellData
{
	public readonly int CullingGroupId; //Field offset: 0x0
	public readonly FastArray Indices; //Field offset: 0x8

	public TemporaryCullingCellData(int cullingGroupId, FastArray indices) { }

}

