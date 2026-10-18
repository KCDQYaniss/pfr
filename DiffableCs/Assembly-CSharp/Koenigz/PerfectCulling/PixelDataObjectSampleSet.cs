namespace Koenigz.PerfectCulling;

public sealed class PixelDataObjectSampleSet : IObjectSampleSet
{
	private Dictionary _sampleMap; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 68
	}

	public PixelDataObjectSampleSet() { }

	public PixelDataObjectSampleSet(List indices, List pixels) { }

	public PixelDataObjectSampleSet(SamplingTaskCellResult result) { }

	public override void Clear() { }

	public override bool ContainsIndex(ushort index) { }

	public override int get_Count() { }

	public override int GetNumPixels(ushort index) { }

	public override ushort[] ToIndexArray() { }

	public override List ToSamplesArray() { }

	public override void UnionWith(SamplingTaskCellResult result) { }

}

