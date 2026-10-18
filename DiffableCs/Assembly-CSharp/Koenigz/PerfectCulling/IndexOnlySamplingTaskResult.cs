namespace Koenigz.PerfectCulling;

public sealed class IndexOnlySamplingTaskResult : ISamplingTaskResult
{
	public static readonly List EmptyPixelList; //Field offset: 0x0
	private List[] _cells; //Field offset: 0x10

	public override int NumCells
	{
		 get { } //Length: 26
	}

	public override List[] RawCells
	{
		 get { } //Length: 5
	}

	public override List[] RawPixels
	{
		 get { } //Length: 3
	}

	private static IndexOnlySamplingTaskResult() { }

	public IndexOnlySamplingTaskResult(int numCells) { }

	public override void Dispose() { }

	public override void DisposeAt(int cellIndex) { }

	public override int get_NumCells() { }

	public override List[] get_RawCells() { }

	public override List[] get_RawPixels() { }

	public override List GetCellData(int index) { }

	public override List GetPixelData(int index) { }

	public override SamplingTaskCellResult GetSample(int cellIndex) { }

	public override void Remap(IndexConvertDelegate remapDelegate) { }

}

