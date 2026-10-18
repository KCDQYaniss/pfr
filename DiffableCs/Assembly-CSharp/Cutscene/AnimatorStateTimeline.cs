namespace Cutscene;

public class AnimatorStateTimeline
{
	internal enum ESyncTime
	{
		Animation = 0,
		AudioSystem = 1,
	}

	private AnimationEvent[] events; //Field offset: 0x10
	private AnimationEvent lastEvent; //Field offset: 0x18
	private AnimationEvent _lastSavedPlayedEvent; //Field offset: 0x20
	private ESyncTime syncTime; //Field offset: 0x28
	private LipSyncPlayer player; //Field offset: 0x30

	public AnimatorStateTimeline(GameObject target, ESyncTime syncTime, AnimationEvent[] events) { }

	private float CalculateEventNormalizedTime(AnimationEvent event, float normalizedTime, float stateDuration) { }

	private void CheckEventsTime(float normalizedTime, float stateDuration) { }

	public void OnStateExit(float normalizedTime, float stateDuration) { }

	public void OnStateUpdate(float normalizedTime, float stateDuration) { }

}

