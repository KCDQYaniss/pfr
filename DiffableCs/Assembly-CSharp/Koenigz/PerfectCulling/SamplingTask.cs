namespace Koenigz.PerfectCulling;

public sealed class SamplingTask
{
	internal enum Mode
	{
		Overwrite = 0,
		Append = 1,
		Union = 2,
		SuperSample = 3,
	}

	[CompilerGenerated]
	private int[] <CellIndices>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Vector3[] <SamplingPoints>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ISamplingTaskResult <OutputData>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private PerfectCullingSuperSamplingVolume <OptionalVolume>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Mode <WriteMode>k__BackingField; //Field offset: 0x30

	public private int[] CellIndices
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PerfectCullingSuperSamplingVolume OptionalVolume
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private ISamplingTaskResult OutputData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Vector3[] SamplingPoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Mode WriteMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public SamplingTask(int[] cellIndices, Vector3[] samplingPoints, Mode writeMode, IObjectSampleSetFactory sampleSetFactory, PerfectCullingSuperSamplingVolume optionalVolume = null) { }

	public void Dispose() { }

	[CompilerGenerated]
	public int[] get_CellIndices() { }

	[CompilerGenerated]
	public PerfectCullingSuperSamplingVolume get_OptionalVolume() { }

	[CompilerGenerated]
	public ISamplingTaskResult get_OutputData() { }

	[CompilerGenerated]
	public Vector3[] get_SamplingPoints() { }

	[CompilerGenerated]
	public Mode get_WriteMode() { }

	public void RemapIds() { }

	[CompilerGenerated]
	private void set_CellIndices(int[] value) { }

	[CompilerGenerated]
	public void set_OptionalVolume(PerfectCullingSuperSamplingVolume value) { }

	[CompilerGenerated]
	private void set_OutputData(ISamplingTaskResult value) { }

	[CompilerGenerated]
	private void set_SamplingPoints(Vector3[] value) { }

	[CompilerGenerated]
	private void set_WriteMode(Mode value) { }

}

