//Type is in global namespace

[StateBehaviorConverter(typeof(PlayerStateContainerBehaviourConverter))]
public class PlayerStateContainer : StateMachineBehaviour, IPlayerStateContainerBehaviour, IStateBehaviour
{
	public bool IsDefaultState; //Field offset: 0x18
	public EPlayerState Name; //Field offset: 0x19
	public EStateType Type; //Field offset: 0x1A
	public EMovementDirection AdditionalDirectionInfo; //Field offset: 0x1B
	public float RotationSpeedClamp; //Field offset: 0x1C
	public float StateSensitivity; //Field offset: 0x20
	public bool CanInteract; //Field offset: 0x24
	public bool DisableRootMotion; //Field offset: 0x25
	public bool CreateUniqueMovementStateObject; //Field offset: 0x26
	public float AnimationAuthority; //Field offset: 0x28
	public float AuthoritySpeed; //Field offset: 0x2C
	public AnimationCurve SmoothLerpAnimCurve; //Field offset: 0x30
	[HideInInspector]
	public string StateFullName; //Field offset: 0x38
	[HideInInspector]
	public int StateFullNameHash; //Field offset: 0x40
	[HideInInspector]
	public float StateLength; //Field offset: 0x44
	public AnimatorPose FirstPersonPose; //Field offset: 0x48
	[CompilerGenerated]
	private BaseMovementState <EncapsulatedState>k__BackingField; //Field offset: 0x50

	public override bool DefaultState
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public override BaseMovementState EncapsulatedState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override int FullNameHash
	{
		 get { } //Length: 4
	}

	public override EPlayerState PlayerStateName
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public PlayerStateContainer() { }

	public override void Deinit() { }

	public override bool get_DefaultState() { }

	[CompilerGenerated]
	public override BaseMovementState get_EncapsulatedState() { }

	public override int get_FullNameHash() { }

	public override EPlayerState get_PlayerStateName() { }

	public override void Init(Func newStateFunc) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void set_DefaultState(bool value) { }

	[CompilerGenerated]
	public override void set_EncapsulatedState(BaseMovementState value) { }

	public override void set_PlayerStateName(EPlayerState value) { }

}

