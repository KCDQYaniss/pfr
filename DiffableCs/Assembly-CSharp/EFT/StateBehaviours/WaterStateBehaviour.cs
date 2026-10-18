namespace EFT.StateBehaviours;

public class WaterStateBehaviour : StateMachineBehaviour
{
	private bool _animationFinished; //Field offset: 0x18

	public WaterStateBehaviour() { }

	private static bool HasFinished(AnimatorStateInfo stateInfo) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

