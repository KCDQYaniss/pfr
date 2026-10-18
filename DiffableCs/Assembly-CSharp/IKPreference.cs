//Type is in global namespace

public class IKPreference : StateMachineBehaviour
{
	public LimbIK[] footIKs; //Field offset: 0x18
	public bool IKEnabledEnter; //Field offset: 0x20
	public bool IKEnabledExit; //Field offset: 0x21

	public IKPreference() { }

	private void InitFootIK(Animator animator) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

