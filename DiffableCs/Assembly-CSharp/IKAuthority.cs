//Type is in global namespace

public class IKAuthority : Authority
{
	public bool Exit; //Field offset: 0x20
	public float Speed; //Field offset: 0x24
	private bool _exitFired; //Field offset: 0x28

	public IKAuthority() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

