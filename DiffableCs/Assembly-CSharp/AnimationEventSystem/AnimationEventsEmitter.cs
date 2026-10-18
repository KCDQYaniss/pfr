namespace AnimationEventSystem;

public class AnimationEventsEmitter : IAnimationEventsConsumer, IDisposable
{
	internal class AnimationEventsEmitterLogger : AbstractLogger
	{
		private readonly AnimationEventsEmitter _animationEventsEmitter; //Field offset: 0x48
		private readonly string _animControllerName; //Field offset: 0x50
		private readonly string _distinctId; //Field offset: 0x58

		public AnimationEventsEmitterLogger(AnimationEventsEmitter animationEventsEmitter, string distinctId = "undefined") { }

		public void EventPuttedToDelayedEventsQueue(AnimationEvent e, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float normalizedTime) { }

		public void TraceEventTestPassed(AnimationEvent e, bool conditionsPassed, float normalizedTime, IAnimator animator, in AnimatorStateInfoWrapper stateInfo) { }

		public void WarnNoHandler(string functionName) { }

	}

	private struct DelayedEventInfo
	{
		public readonly IAnimator Animator; //Field offset: 0x0
		public readonly float NormalizedTime; //Field offset: 0x8
		public readonly AnimationEvent AnimationEvent; //Field offset: 0x10
		public readonly AnimatorStateInfoWrapper StateInfo; //Field offset: 0x18

		public DelayedEventInfo(AnimationEvent animationEvent, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float normalizedTime) { }

	}

	internal enum EEmitType
	{
		EmitOnAnimatorUpdate = 0,
		EmitOnDemand = 1,
	}

	private AnimationEventsEmitterLogger _logger; //Field offset: 0x10
	private IAnimator _animator; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnEventAction; //Field offset: 0x20
	private EEmitType _emitType; //Field offset: 0x28
	private readonly Queue _delayedEvents; //Field offset: 0x30
	private HashSet _animationEventsStateBehaviours; //Field offset: 0x38
	private AnimationEventsSequenceData _eventsSequenceData; //Field offset: 0x40
	private List _eventBehaviours; //Field offset: 0x48

	public event Action OnEventAction
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public AnimationEventsSequenceData EventsSequenceData
	{
		 get { } //Length: 5
	}

	public AnimationEventsEmitter() { }

	[CompilerGenerated]
	public void add_OnEventAction(Action value) { }

	private override void AnimationEventSystem.IAnimationEventsConsumer.ReceiveEvent(AnimationEvent animationEvent, IAnimator animator, in AnimatorStateInfoWrapper animatorStateInfo, float normalizedTime) { }

	public override void Dispose() { }

	public void EmitEvents() { }

	private void FireEventIfConditionsPassed(AnimationEvent event, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float normalizedTime) { }

	public AnimationEventsSequenceData get_EventsSequenceData() { }

	[CompilerGenerated]
	public void remove_OnEventAction(Action value) { }

	public void RemoveBindedAnimator() { }

	private void SendEvent(string functionName, int functionNameHash, AnimationEventParameter parameter, int stateShortNameHash) { }

	public void SetAnimator(IAnimator animator, EEmitType emitType, string distinctId = "undefined", bool force = false) { }

	public void SubscribeToAnimatorEvent(IEventBehaviour behaviour) { }

	private void SubscribeToAnimatorEvents() { }

	private void UnsubscribeEvents() { }

	public void UnsubscribeToAnimatorEvent(IEventBehaviour behaviour) { }

}

