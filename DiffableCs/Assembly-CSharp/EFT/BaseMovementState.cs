namespace EFT;

public abstract class BaseMovementState
{
	public EStateType Type; //Field offset: 0x10
	public EPlayerState Name; //Field offset: 0x11
	public string AnimatorStateName; //Field offset: 0x18
	public int AnimatorStateHash; //Field offset: 0x20
	public float AnimationAuthority; //Field offset: 0x24
	public float AuthoritySpeed; //Field offset: 0x28
	public float StateLength; //Field offset: 0x2C
	public float StateSensitivity; //Field offset: 0x30
	public EMovementDirection AdditionalDirectionInfo; //Field offset: 0x34
	public AnimationCurve SmoothLerpAnimCurve; //Field offset: 0x38
	public float RotationSpeedClamp; //Field offset: 0x40
	[CompilerGenerated]
	private bool <CanInteract>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <DisableRootMotion>k__BackingField; //Field offset: 0x45

	public bool CanInteract
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool DisableRootMotion
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected BaseMovementState() { }

	public abstract void AssignAnimatorPose(AnimatorPose firstPersonPose) { }

	public override void Enter(bool isFromSameState) { }

	public override void Exit(bool toSameState) { }

	[CompilerGenerated]
	public bool get_CanInteract() { }

	[CompilerGenerated]
	public override bool get_DisableRootMotion() { }

	public override void OnStateEnter(float stateInfoNormalizedTime) { }

	public abstract void OnStateExit(float stateInfoNormalizedTime) { }

	public abstract void OnStateMove(float stateInfoNormalizedTime) { }

	public override void ReEnter() { }

	[CompilerGenerated]
	public void set_CanInteract(bool value) { }

	[CompilerGenerated]
	public override void set_DisableRootMotion(bool value) { }

}

