namespace Koenigz.PerfectCulling;

public sealed class IndexOnlyObjectSampleSetFactory : IObjectSampleSetFactory
{

	public IndexOnlyObjectSampleSetFactory() { }

	public override IObjectSampleSet CreateSampleSet() { }

	public override IObjectSampleSet CreateSampleSet(SamplingTaskCellResult result) { }

	public override ISamplingTaskResult CreateSamplingTaskResult(int numCells) { }

}

