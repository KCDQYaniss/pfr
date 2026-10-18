namespace Audio.SpatialSystem.SpatialAudioCalculator;

public interface IAudioOcclusionCalculator : IDisposable
{

	public bool IsCalculationInProgress
	{
		 get { } //Length: 0
	}

	public JobHandle LastJobHandle
	{
		 get { } //Length: 0
	}

	public void CompleteCalculation() { }

	public bool get_IsCalculationInProgress() { }

	public JobHandle get_LastJobHandle() { }

	public float GetNormalizedPathScore() { }

	public JobHandle StartCalculation(Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance, float qualityFactor = 1, JobHandle inputDeps = null) { }

	public JobHandle UpdateCalculationStep(JobHandle inputDeps = null) { }

}

