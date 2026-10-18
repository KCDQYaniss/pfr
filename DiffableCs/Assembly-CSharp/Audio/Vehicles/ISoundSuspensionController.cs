namespace Audio.Vehicles;

public interface ISoundSuspensionController
{

	public float PlayingTimeThresholdSeconds
	{
		 get { } //Length: 0
	}

	public float CalculateVolume(float forceMagnitude) { }

	public float get_PlayingTimeThresholdSeconds() { }

	public AudioClip GetImpactClip() { }

	public float GetRandomPitch() { }

	public bool IsOutOfRange(Vector3 position, int sqrRolloff) { }

	public void SetEnvironment(EnvironmentType environment) { }

}

