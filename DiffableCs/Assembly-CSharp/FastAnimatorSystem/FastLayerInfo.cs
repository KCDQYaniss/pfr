namespace FastAnimatorSystem;

public class FastLayerInfo
{
	[CompilerGenerated]
	private AbstractAnimatorControllerState <CurrentState>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private AnimatorControllerTransition <Transition>k__BackingField; //Field offset: 0x18
	private float _prevCurrentAbsTime; //Field offset: 0x20
	private float _cachedCurrentNormalizedTime; //Field offset: 0x24
	public float CurrentStateAbsoluteTime; //Field offset: 0x28
	public float TransitionAbsTime; //Field offset: 0x2C
	public float DestinationStateAbsoluteTime; //Field offset: 0x30
	private float _prevDestinationAbsTime; //Field offset: 0x34
	private float _cachedDestinationNormalizedTime; //Field offset: 0x38
	public AbstractState ForcePlayState; //Field offset: 0x40
	public float ForcePlayStateNT; //Field offset: 0x48

	public AbstractAnimatorControllerState CurrentState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float CurrentStateNormalizedTime
	{
		 get { } //Length: 111
	}

	public AbstractAnimatorControllerState DestinationState
	{
		 get { } //Length: 19
	}

	public float DestinationStateNormalizedTime
	{
		 get { } //Length: 127
	}

	public AnimatorControllerTransition Transition
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float TransitionAbsDuration
	{
		 get { } //Length: 82
	}

	public FastLayerInfo() { }

	private static float ConvertAbsTimeToNormalized(AbstractAnimatorControllerState state, float absoluteTime) { }

	[CompilerGenerated]
	public AbstractAnimatorControllerState get_CurrentState() { }

	public float get_CurrentStateNormalizedTime() { }

	public AbstractAnimatorControllerState get_DestinationState() { }

	public float get_DestinationStateNormalizedTime() { }

	[CompilerGenerated]
	public AnimatorControllerTransition get_Transition() { }

	public float get_TransitionAbsDuration() { }

	[CompilerGenerated]
	public void set_CurrentState(AbstractAnimatorControllerState value) { }

	[CompilerGenerated]
	public void set_Transition(AnimatorControllerTransition value) { }

	public virtual string ToString() { }

}

