namespace Koenigz.PerfectCulling;

public interface IObjectSampleSetFactory
{

	public IObjectSampleSet CreateSampleSet() { }

	public IObjectSampleSet CreateSampleSet(SamplingTaskCellResult result) { }

	public ISamplingTaskResult CreateSamplingTaskResult(int numCells) { }

}

