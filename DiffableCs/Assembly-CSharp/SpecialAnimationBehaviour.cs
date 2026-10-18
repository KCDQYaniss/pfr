//Type is in global namespace

public class SpecialAnimationBehaviour : StateMachineBehaviour
{
	public IKSettings IKDisable; //Field offset: 0x18
	public bool EnableSpecialAnimation; //Field offset: 0x1C
	public float TresholdTime; //Field offset: 0x20
	public bool LeftArmReverseSnatching; //Field offset: 0x24
	private bool _exitFired; //Field offset: 0x25
	public Player Player; //Field offset: 0x28

	public SpecialAnimationBehaviour() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

