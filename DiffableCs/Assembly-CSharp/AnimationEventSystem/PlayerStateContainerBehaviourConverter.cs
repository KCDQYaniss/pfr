namespace AnimationEventSystem;

public class PlayerStateContainerBehaviourConverter : AbstractFastStateConverter
{

	public PlayerStateContainerBehaviourConverter() { }

	protected virtual FastAnimationPlayerStateContainerBehaviour InternalCreate(PlayerStateContainer behaviour, AbstractState state) { }

}

