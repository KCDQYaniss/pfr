namespace DefaultNamespace;

[IgnoreInFastAnimationSystem]
public class LayerWeightStateController : StateMachineBehaviour, IStateBehaviour
{
	public int TargetLayerIndex; //Field offset: 0x18
	public float StartValue; //Field offset: 0x1C
	public float EndValue; //Field offset: 0x20
	public AnimationCurve LayerWeight; //Field offset: 0x28
	private UnityAnimatorWrapper _animatorWrapper; //Field offset: 0x30

	public LayerWeightStateController() { }

	private void Init(Animator animator) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

