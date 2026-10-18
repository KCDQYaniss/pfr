namespace Koenigz.PerfectCulling;

public interface ISamplingTaskResult
{

	public int NumCells
	{
		 get { } //Length: 0
	}

	public List[] RawCells
	{
		 get { } //Length: 0
	}

	public List[] RawPixels
	{
		 get { } //Length: 0
	}

	public void Dispose() { }

	public void DisposeAt(int cellIndex) { }

	public int get_NumCells() { }

	public List[] get_RawCells() { }

	public List[] get_RawPixels() { }

	public List GetCellData(int index) { }

	public List GetPixelData(int index) { }

	public SamplingTaskCellResult GetSample(int cellIndex) { }

	public void Remap(IndexConvertDelegate remapDelegate) { }

}

