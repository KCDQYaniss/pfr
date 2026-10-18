namespace Koenigz.PerfectCulling;

public interface IBakingBehaviour
{

	public void AddSamplingProvider(IActiveSamplingProvider samplingProvider) { }

	public void RemoveSamplingProvider(IActiveSamplingProvider samplingProvider) { }

}

