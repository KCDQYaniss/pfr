namespace AnimationEventSystem;

public class FastAnimationPlayerStateContainerBehaviour : FastStateBehavior, IPlayerStateContainerBehaviour, IStateBehaviour
{
	public bool IsDefaultState; //Field offset: 0x18
	public EPlayerState Name; //Field offset: 0x19
	public EStateType Type; //Field offset: 0x1A
	public float RotationSpeedClamp; //Field offset: 0x1C
	public float StateSensitivity; //Field offset: 0x20
	public bool CanInteract; //Field offset: 0x24
	public bool DisableRootMotion; //Field offset: 0x25
	public bool CreateUniqueMovementStateObject; //Field offset: 0x26
	public float AnimationAuthority; //Field offset: 0x28
	public float AuthoritySpeed; //Field offset: 0x2C
	public string StateFullName; //Field offset: 0x30
	public float StateLength; //Field offset: 0x38
	public int StateFullNameHash; //Field offset: 0x3C
	[CompilerGenerated]
	private BaseMovementState <EncapsulatedState>k__BackingField; //Field offset: 0x40

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

	public FastAnimationPlayerStateContainerBehaviour() { }

	public virtual FastStateBehavior Clone() { }

	public override void Deinit() { }

	public virtual void Deserialize(BinaryReader reader) { }

	public virtual bool Equals(object obj) { }

	protected bool Equals(FastAnimationPlayerStateContainerBehaviour other) { }

	public override bool get_DefaultState() { }

	[CompilerGenerated]
	public override BaseMovementState get_EncapsulatedState() { }

	public override int get_FullNameHash() { }

	public override EPlayerState get_PlayerStateName() { }

	public virtual int GetHashCode() { }

	public override void Init(Func newStateFunc) { }

	public virtual void OnStateEnter(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateExit(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateMove(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateUpdate(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void Serialize(BinaryWriter writer) { }

	public override void set_DefaultState(bool value) { }

	[CompilerGenerated]
	public override void set_EncapsulatedState(BaseMovementState value) { }

	public override void set_PlayerStateName(EPlayerState value) { }

}

