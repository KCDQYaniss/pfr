namespace Audio.SpatialSystem.SpatialAudioCalculator.CombinedOcclusionCalculator;

public class FakeAudioOcclusionCalculator : IAudioOcclusionCalculator, IDisposable
{

	public override bool IsCalculationInProgress
	{
		 get { } //Length: 3
	}

	public override JobHandle LastJobHandle
	{
		 get { } //Length: 10
	}

	public FakeAudioOcclusionCalculator(TransmissionSettings settings, QueryParameters queryParams, float maxDistance) { }

	public override void CompleteCalculation() { }

	public override void Dispose() { }

	public override bool get_IsCalculationInProgress() { }

	public override JobHandle get_LastJobHandle() { }

	public override float GetNormalizedPathScore() { }

	public override JobHandle StartCalculation(Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance, float qualityFactor = 1, JobHandle inputDeps = null) { }

	public override JobHandle UpdateCalculationStep(JobHandle inputDeps = null) { }

}

