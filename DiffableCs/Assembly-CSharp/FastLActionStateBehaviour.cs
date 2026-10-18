//Type is in global namespace

public class FastLActionStateBehaviour : FastStateBehavior
{
	public float StartTreshold; //Field offset: 0x18
	public AnimationCurve LayerWeight; //Field offset: 0x20
	private LActionStateContext _context; //Field offset: 0x28

	private LActionStateContext Context
	{
		private get { } //Length: 318
	}

	public FastLActionStateBehaviour() { }

	public virtual FastStateBehavior Clone() { }

	private LActionStateContext get_Context() { }

	public virtual void OnStateEnter(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateExit(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateUpdate(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

}

