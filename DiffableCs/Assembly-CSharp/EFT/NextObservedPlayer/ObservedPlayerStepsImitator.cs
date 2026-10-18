namespace EFT.NextObservedPlayer;

public class ObservedPlayerStepsImitator
{
	private const float SMOOTH_FACTOR = 3; //Field offset: 0x0
	private readonly ObservedPlayerView _observedPlayer; //Field offset: 0x10
	private readonly AnimationCurve _runCurve; //Field offset: 0x18
	private readonly AnimationCurve _sprintCurve; //Field offset: 0x20
	private readonly AnimationCurve _runSpeedCurve; //Field offset: 0x28
	private readonly AnimationCurve _sprintSpeedCurve; //Field offset: 0x30
	private float _curveValue; //Field offset: 0x38
	private float _maxSpeed; //Field offset: 0x3C
	private float _maxSprintSpeed; //Field offset: 0x40
	private float _smoothedSpeed; //Field offset: 0x44
	public Action OnStateChanged; //Field offset: 0x48
	[CompilerGenerated]
	private EPlayerState <CurrentMovementState>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private EPlayerState <PrevMovementState>k__BackingField; //Field offset: 0x51
	[CompilerGenerated]
	private float <FootStepSign>k__BackingField; //Field offset: 0x54

	public private EPlayerState CurrentMovementState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private float CurveValue
	{
		private get { } //Length: 6
		private set { } //Length: 46
	}

	public private float FootStepSign
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	private float MaxSpeed
	{
		private get { } //Length: 18
	}

	private float MovementSpeed
	{
		private get { } //Length: 72
	}

	public private EPlayerState PrevMovementState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private ObservedPlayerStateContext StateContext
	{
		private get { } //Length: 51
	}

	private AnimationCurve StepCurve
	{
		private get { } //Length: 22
	}

	public ObservedPlayerStepsImitator(ObservedPlayerView player) { }

	public void ApplyMovementModel(ObservedPlayerMovementModel nextModel) { }

	private float CalculateActualStepDuration(float dt) { }

	[CompilerGenerated]
	public EPlayerState get_CurrentMovementState() { }

	private float get_CurveValue() { }

	[CompilerGenerated]
	public float get_FootStepSign() { }

	private float get_MaxSpeed() { }

	private float get_MovementSpeed() { }

	[CompilerGenerated]
	public EPlayerState get_PrevMovementState() { }

	private ObservedPlayerStateContext get_StateContext() { }

	private AnimationCurve get_StepCurve() { }

	private AnimationCurve GetCurve() { }

	private float GetCurveValueByAnimator(float animatorFootstepSign) { }

	private float GetNormalizedPlayerSpeed() { }

	private float GetStepLengthBySpeed(float normalizedSpeed) { }

	public void ManualUpdate() { }

	public void ResetImitation(float animatorFootstepSign) { }

	[CompilerGenerated]
	private void set_CurrentMovementState(EPlayerState value) { }

	private void set_CurveValue(float value) { }

	[CompilerGenerated]
	private void set_FootStepSign(float value) { }

	[CompilerGenerated]
	private void set_PrevMovementState(EPlayerState value) { }

	public void UpdateFootstepSign(float dt) { }

	private void UpdateMovementState() { }

}

