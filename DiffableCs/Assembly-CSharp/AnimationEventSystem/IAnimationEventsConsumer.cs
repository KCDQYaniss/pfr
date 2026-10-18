namespace AnimationEventSystem;

public interface IAnimationEventsConsumer
{

	public void ReceiveEvent(AnimationEvent event, IAnimator animator, in AnimatorStateInfoWrapper stateInfo, float normalizedTime) { }

}

