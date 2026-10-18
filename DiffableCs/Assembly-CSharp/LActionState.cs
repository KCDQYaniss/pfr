//Type is in global namespace

[IgnoreInFastAnimationSystem]
public class LActionState : StateMachineBehaviour, IStateBehaviour
{
	internal class LActionStateContext
	{
		private bool _fired; //Field offset: 0x10
		private bool _increase; //Field offset: 0x11
		private int _layerIndex; //Field offset: 0x14
		private bool _ready; //Field offset: 0x18
		private readonly AnimationCurve _layerWeight; //Field offset: 0x20
		private readonly float _startTreshold; //Field offset: 0x28

		public LActionStateContext(LActionSetup setup) { }

		public LActionStateContext(AnimationCurve layerWeight, float startTreshold) { }

		public void OnStateEnter(IAnimator animator, AnimatorStateInfoWrapper stateInfo, int layerIndex) { }

		public void OnStateExit(IAnimator animator, AnimatorStateInfoWrapper stateInfo, int layerIndex) { }

		public void OnStateUpdate(IAnimator animator, AnimatorStateInfoWrapper stateInfo, int layerIndex) { }

	}

	private UnityAnimatorWrapper _animatorWrapper; //Field offset: 0x18
	public AnimatorControllerStaticData StaticData; //Field offset: 0x20
	public int LActionSetupId; //Field offset: 0x28
	private LActionStateContext _context; //Field offset: 0x30

	private LActionStateContext Context
	{
		private get { } //Length: 434
	}

	public LActionSetup Setup
	{
		 get { } //Length: 119
	}

	public LActionState() { }

	private LActionStateContext get_Context() { }

	public LActionSetup get_Setup() { }

	private void Init(Animator animator) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

