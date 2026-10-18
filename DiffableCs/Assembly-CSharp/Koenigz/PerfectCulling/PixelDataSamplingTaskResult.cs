namespace Koenigz.PerfectCulling;

public sealed class PixelDataSamplingTaskResult : ISamplingTaskResult
{
	private List[] _cells; //Field offset: 0x10
	private List[] _pixels; //Field offset: 0x18

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
		 get { } //Length: 5
	}

	public PixelDataSamplingTaskResult(int numCells) { }

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

