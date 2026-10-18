namespace AnimationEventSystem;

public class AnimationEventsContainer : ICloneable
{
	private class AnimatorEventsControllerLogger : AbstractLogger
	{
		private struct LoggedInfo
		{
			public int stateHash; //Field offset: 0x0
			public EUpdateType UpdateType; //Field offset: 0x4

		}

		private LoggedInfo _previousLoggedInfo; //Field offset: 0x48

		public AnimatorEventsControllerLogger() { }

		public void DebugAnimatorsSwitch(IAnimator previousAnimator, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, EUpdateType updateType) { }

		private bool IsLogEnabledAndTimeToLog(in AnimatorStateInfoWrapper stateInfo, EUpdateType updateType) { }

		public void LogEventsCheck(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, EUpdateType updateType, float previousNormalizedTime) { }

		public void LogEventTimeCheck(AnimationEvent animationEvent, float previousNormalizedTime, float normalizedTime) { }

	}

	internal enum EUpdateType
	{
		OnEnter = 0,
		OnUpdate = 1,
		OnExit = 2,
	}

	private const float ALMOST_ONE = 0.99999; //Field offset: 0x0
	private const float A_BIT_GREATER_THAN_ONE = 1.00001; //Field offset: 0x0
	private const float MIN_DIFF = 1E-05; //Field offset: 0x0
	private static readonly AnimatorEventsControllerLogger Logger; //Field offset: 0x0
	private bool _previousLoop; //Field offset: 0x10
	private float _previousNormalizedTime; //Field offset: 0x14
	private IAnimator _previousAnimator; //Field offset: 0x18
	private IAnimationEventsConsumer _eventsConsumer; //Field offset: 0x20
	private bool _hasEventsAndConsumerCache; //Field offset: 0x28

	private static AnimationEventsContainer() { }

	public AnimationEventsContainer() { }

	private void CheckEvents(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, EUpdateType updateType, List animationEvents) { }

	private void CheckEventsTime(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float previousNormalizedTime, float normalizedTime, List animationEvents) { }

	public override object Clone() { }

	private void FireEvent(AnimationEvent event, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float normalizedTime) { }

	private bool HasConsumerAndEvents() { }

	public void OnStateEnter(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, List animationEvents) { }

	public void OnStateExit(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, List animationEvents) { }

	public void OnStateUpdate(IAnimator animator, in AnimatorStateInfoWrapper stateInfo, int layerIndex, List animationEvents) { }

	public override void ResetCache() { }

	public void SetEventsConsumer(IAnimationEventsConsumer consumer) { }

	public void UnsetEventsConsumer(IAnimationEventsConsumer consumer) { }

}

