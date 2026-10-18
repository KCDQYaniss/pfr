namespace Koenigz.PerfectCulling.EFT;

public sealed class StreamingVolumeBakeDataGrid
{
	private StreamingVolumeBakeDataIndex _streamData; //Field offset: 0x10
	private FileStream _readStream; //Field offset: 0x18
	private BitStreamReader _bitStreamReader; //Field offset: 0x20
	private byte[] _readBuffer; //Field offset: 0x28
	private byte[] _preloadedData; //Field offset: 0x30
	public int bytesRead; //Field offset: 0x38
	public int readOps; //Field offset: 0x3C
	private bool _preloadData; //Field offset: 0x40

	public StreamingVolumeBakeDataIndex StreamData
	{
		 get { } //Length: 5
	}

	public StreamingVolumeBakeDataGrid(StreamingVolumeBakeDataIndex streamData, string filePath, LoadMode loadMode) { }

	private void Decompress(byte[] compressed, int len, FastArray indices) { }

	private void DecompressDirect(byte[] compressed, int offset, int len, FastArray indices) { }

	public void Dispose() { }

	public StreamingVolumeBakeDataIndex get_StreamData() { }

	public int GetRuntimeMemorySizeBytes() { }

	public int SampleByIndexFromDisk(int index, FastArray buffer) { }

}

