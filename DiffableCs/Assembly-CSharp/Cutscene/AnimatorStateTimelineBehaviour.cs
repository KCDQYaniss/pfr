namespace Cutscene;

public class AnimatorStateTimelineBehaviour : StateMachineBehaviour
{
	public int stateHash; //Field offset: 0x18
	public AnimatorStateTimelineData data; //Field offset: 0x20
	private AnimatorStateTimeline timeline; //Field offset: 0x28
	private int lastLoop; //Field offset: 0x30

	public AnimatorStateTimelineBehaviour() { }

	[CompilerGenerated]
	private bool <Init>b__8_0(AnimationEvent e) { }

	private void Init(Animator animator) { }

	private void OnState(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

