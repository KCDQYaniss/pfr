//Type is in global namespace

public class FirstPersonAuthority : StateMachineBehaviour
{
	public AnimationCurve WeightCurve; //Field offset: 0x18

	public FirstPersonAuthority() { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

