namespace AnimationEventSystem;

public class FastAnimationEventsStateBehaviour : FastStateBehavior, IEventBehaviour, IStateBehaviour
{
	public string FullName; //Field offset: 0x18
	public int FullNameHash; //Field offset: 0x20
	public AnimationEventsContainer EventsContainer; //Field offset: 0x28
	public List AnimationEvents; //Field offset: 0x30

	private override AnimationEventsContainer AnimationEventSystem.IEventBehaviour.EventsContainer
	{
		private get { } //Length: 5
		private set { } //Length: 82
	}

	private override int AnimationEventSystem.IEventBehaviour.FullNameHash
	{
		private get { } //Length: 4
	}

	public FastAnimationEventsStateBehaviour() { }

	private override AnimationEventsContainer AnimationEventSystem.IEventBehaviour.get_EventsContainer() { }

	private override int AnimationEventSystem.IEventBehaviour.get_FullNameHash() { }

	private override void AnimationEventSystem.IEventBehaviour.set_EventsContainer(AnimationEventsContainer value) { }

	public virtual FastStateBehavior Clone() { }

	public virtual void Deserialize(BinaryReader reader) { }

	public virtual bool Equals(object obj) { }

	protected bool Equals(FastAnimationEventsStateBehaviour other) { }

	public virtual int GetHashCode() { }

	public virtual void OnStateEnter(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateExit(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateMove(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateUpdate(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void ResetCache() { }

	public virtual void Serialize(BinaryWriter writer) { }

}

