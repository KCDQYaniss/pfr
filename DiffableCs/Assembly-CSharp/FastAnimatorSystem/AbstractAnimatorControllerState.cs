namespace FastAnimatorSystem;

public abstract class AbstractAnimatorControllerState : AbstractState, IParameterValueChangedListener
{
	internal AbstractStateMachine _parentStateMachine; //Field offset: 0x30
	internal List _outTransitions; //Field offset: 0x38
	internal readonly float SpeedMultiplier; //Field offset: 0x40
	internal readonly AnimatorParameter SpeedAnimatorParameterMultiplier; //Field offset: 0x48
	public List _outTransitions__WITH_EXIT_TIME; //Field offset: 0x50
	private bool _hasSuccedConditions__WITH_EXIT_TIME; //Field offset: 0x58
	public List _outTransitions__NO_EXIT_TIME; //Field offset: 0x60
	private bool _hasSuccedConditions__NO_EXIT_TIME; //Field offset: 0x68
	private bool _isTransitionConditionsDirty; //Field offset: 0x69
	private bool _isMotionDurationDirty; //Field offset: 0x6A
	private float _cachedMotionDuration; //Field offset: 0x6C

	public abstract bool Loop
	{
		 get { } //Length: 0
	}

	public float MotionDuration
	{
		 get { } //Length: 238
	}

	public int OutTransitionsCount
	{
		 get { } //Length: 65
	}

	public AbstractStateMachine ParentStateMachine
	{
		 get { } //Length: 76
	}

	public float Real
	{
		 get { } //Length: 20
	}

	protected abstract float RealMotionDuration
	{
		 get { } //Length: 0
	}

	protected AbstractAnimatorControllerState(string name, int hash, List outTransitions, float speedMultiplier, AnimatorParameter speedAnimatorParameterMultiplier) { }

	protected AbstractAnimatorControllerState(string name, int hash, float speedMultiplier, AnimatorParameter speedAnimatorParameterMultiplier) { }

	protected virtual void Dispose(bool disposing) { }

	public abstract bool get_Loop() { }

	public float get_MotionDuration() { }

	public int get_OutTransitionsCount() { }

	public AbstractStateMachine get_ParentStateMachine() { }

	public float get_Real() { }

	protected abstract float get_RealMotionDuration() { }

	public AnimatorControllerTransition GetInterruptedTriggeredTransition(AbstractAnimatorControllerState current, AbstractAnimatorControllerState next, float currentStateAbsTime, float nextStateAbsTime, float dt, AnimatorControllerTransition currentTransition) { }

	public AnimatorControllerTransition GetOutTransition(int outTransitionIndex) { }

	public IEnumerable GetOutTransitions() { }

	public AnimatorControllerTransition GetTriggeredTransition(float absoluteStartFrameTime, float absoluteEndFrameTime) { }

	private bool IsOrderedInterruptionFailed(AnimatorControllerTransition currentTransition, AnimatorControllerTransition transition) { }

	public void MarkDependentParameterDirty() { }

	public void MarkTransitionDirty() { }

	public override void OnParameterValueChanged() { }

	public void OnStateEnter(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public void OnStateExit(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public void OnStateMove(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public void OnStateUpdate(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void ResetCache() { }

	public virtual string ToString() { }

}

