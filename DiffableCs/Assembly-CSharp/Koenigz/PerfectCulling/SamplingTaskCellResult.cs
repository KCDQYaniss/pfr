namespace Koenigz.PerfectCulling;

[IsByRefLike]
[IsReadOnly]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct SamplingTaskCellResult
{
	public static readonly IReadOnlyList Empty; //Field offset: 0x0
	public readonly IReadOnlyList Indices; //Field offset: 0x0
	public readonly IReadOnlyList Pixels; //Field offset: 0x8

	public SamplingTaskCellResult(IReadOnlyList Indices, IReadOnlyList Pixels) { }

}

