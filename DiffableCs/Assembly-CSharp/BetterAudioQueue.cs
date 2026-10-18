//Type is in global namespace

public class BetterAudioQueue
{
	public BetterSource[] AudioSources; //Field offset: 0x10

	public BetterAudioQueue() { }

	public BetterAudioQueue(BetterSource[] audioSources) { }

	protected double CalculateEnd(float clipTime, double calculatedStart) { }

	protected double CalculateStart(double startTime) { }

	public void Pose(Vector3 worldPosition) { }

	public override void Update() { }

}

