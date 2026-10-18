//Type is in global namespace

public class Authority : StateMachineBehaviour, IStateBehaviour
{
	public PlayerBones PlayerBones; //Field offset: 0x18

	public Authority() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

