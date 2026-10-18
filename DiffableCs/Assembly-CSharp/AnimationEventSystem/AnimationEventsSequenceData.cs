namespace AnimationEventSystem;

public class AnimationEventsSequenceData
{
	[IsReadOnly]
	internal struct DebugQueueData
	{
		public readonly string EventName; //Field offset: 0x0
		public readonly int StateNameShortHash; //Field offset: 0x8
		public readonly bool ConditionPassed; //Field offset: 0xC

		public DebugQueueData(string eventName, int stateHash, bool condsPassed) { }

	}

	private const int MAX_QUEUE_SIZE = 15; //Field offset: 0x0
	public readonly Queue AnimationEventsDebugQueue; //Field offset: 0x10

	public AnimationEventsSequenceData() { }

	public void AddAnimationEventToDebugQueue(string eventName, int stateShortNameHash, bool conditionPassed) { }

}

