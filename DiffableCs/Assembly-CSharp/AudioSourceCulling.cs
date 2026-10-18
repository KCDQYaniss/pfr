//Type is in global namespace

public class AudioSourceCulling : AudioCullingManager
{

	public AudioSourceCulling() { }

	protected virtual AudioSourceCullingHandler CreateHandler(AudioSourcePriorityCalculator priorityCalculator) { }

}

