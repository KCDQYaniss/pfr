namespace Koenigz.PerfectCulling;

public sealed class IndexOnlyObjectSampleSet : IObjectSampleSet
{
	private HashSet _indices; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 65
	}

	public IndexOnlyObjectSampleSet() { }

	public IndexOnlyObjectSampleSet(List indices, List pixels) { }

	public IndexOnlyObjectSampleSet(SamplingTaskCellResult result) { }

	public override void Clear() { }

	public override bool ContainsIndex(ushort index) { }

	public override int get_Count() { }

	public override int GetNumPixels(ushort index) { }

	public override ushort[] ToIndexArray() { }

	public override List ToSamplesArray() { }

	public override void UnionWith(SamplingTaskCellResult result) { }

}

