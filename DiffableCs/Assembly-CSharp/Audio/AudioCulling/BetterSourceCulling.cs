namespace Audio.AudioCulling;

public class BetterSourceCulling : AudioCullingManager, IBetterSourceCulling
{

	public BetterSourceCulling() { }

	private override void Audio.AudioCulling.IBetterSourceCulling.Register(BetterSource source) { }

	private override void Audio.AudioCulling.IBetterSourceCulling.Remove(BetterSource source) { }

	protected virtual BetterSourceCullingHandler CreateHandler(AudioSourcePriorityCalculator priorityCalculator) { }

}

