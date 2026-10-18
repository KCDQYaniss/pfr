namespace Koenigz.PerfectCulling;

public interface IObjectSampleSet
{

	public int Count
	{
		 get { } //Length: 0
	}

	public void Clear() { }

	public bool ContainsIndex(ushort index) { }

	public int get_Count() { }

	public int GetNumPixels(ushort index) { }

	public ushort[] ToIndexArray() { }

	public List ToSamplesArray() { }

	public void UnionWith(SamplingTaskCellResult result) { }

}

