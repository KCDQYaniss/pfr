namespace EFT.MenuPlayer;

public class MenuPlayerStateEnterOffset : StateMachineBehaviour
{
	private bool stateTimeHasRandomized; //Field offset: 0x18
	private float offsetRange; //Field offset: 0x1C
	private float stateTimeOffset; //Field offset: 0x20

	public MenuPlayerStateEnterOffset() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

