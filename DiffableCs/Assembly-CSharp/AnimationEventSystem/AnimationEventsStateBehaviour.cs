namespace AnimationEventSystem;

[StateBehaviorConverter(typeof(AnimationEventsStateBehaviourConverter))]
public class AnimationEventsStateBehaviour : StateMachineBehaviour, IEventBehaviour, IStateBehaviour
{
	public AnimationEventsContainer EventsContainer; //Field offset: 0x18
	public string FullName; //Field offset: 0x20
	public int FullNameHash; //Field offset: 0x28
	public AnimatorControllerStaticData EventsData; //Field offset: 0x30
	public int EventsListId; //Field offset: 0x38
	private UnityAnimatorWrapper _animatorWrapper; //Field offset: 0x40

	[CanBeNull]
	public List AnimationEvents
	{
		 get { } //Length: 36
	}

	private override AnimationEventsContainer AnimationEventSystem.IEventBehaviour.EventsContainer
	{
		private get { } //Length: 5
		private set { } //Length: 82
	}

	private override int AnimationEventSystem.IEventBehaviour.FullNameHash
	{
		private get { } //Length: 4
	}

	public AnimationEventsStateBehaviour() { }

	private override AnimationEventsContainer AnimationEventSystem.IEventBehaviour.get_EventsContainer() { }

	private override int AnimationEventSystem.IEventBehaviour.get_FullNameHash() { }

	private override void AnimationEventSystem.IEventBehaviour.set_EventsContainer(AnimationEventsContainer value) { }

	public List get_AnimationEvents() { }

	private void Init(Animator animator) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

