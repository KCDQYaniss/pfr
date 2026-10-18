namespace EFT.NextObservedPlayer;

public class ObservedPlayerMovementContext : MonoBehaviour
{
	[CompilerGenerated]
	private ICharacterController <ObserverCharacterController>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private MovementInfoPacket <CurrentPacket>k__BackingField; //Field offset: 0x28
	protected PlayerAnimator _playerAnimator; //Field offset: 0x1A0
	[CompilerGenerated]
	private EPlayerState <CurrentState>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private EPlayerState <PreviousState>k__BackingField; //Field offset: 0x1A9
	private Vector2 _rotation; //Field offset: 0x1AC
	private float _handsToBodyAngle; //Field offset: 0x1B4
	private BifacialTransform _playerTransform; //Field offset: 0x1B8

	public MovementInfoPacket CurrentPacket
	{
		[CompilerGenerated]
		 get { } //Length: 180
		[CompilerGenerated]
		 set { } //Length: 242
	}

	public private EPlayerState CurrentState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private ICharacterController ObserverCharacterController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private EPlayerState PreviousState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Vector2 Rotation
	{
		 get { } //Length: 25
		 set { } //Length: 248
	}

	public ObservedPlayerMovementContext() { }

	public void ApplyRotation(Quaternion rotation) { }

	[CompilerGenerated]
	public MovementInfoPacket get_CurrentPacket() { }

	[CompilerGenerated]
	public EPlayerState get_CurrentState() { }

	[CompilerGenerated]
	public ICharacterController get_ObserverCharacterController() { }

	[CompilerGenerated]
	public EPlayerState get_PreviousState() { }

	public Vector2 get_Rotation() { }

	public void Initialize(BifacialTransform playerTransform, ICharacterController characterController, PlayerAnimator animator) { }

	public override void PlayerAnimatorSetAimAngle(float movementContextPitch) { }

	public override void PlayerAnimatorSetDeltaRotation(float movementContextPitch) { }

	[CompilerGenerated]
	public void set_CurrentPacket(MovementInfoPacket value) { }

	[CompilerGenerated]
	private void set_CurrentState(EPlayerState value) { }

	[CompilerGenerated]
	private void set_ObserverCharacterController(ICharacterController value) { }

	[CompilerGenerated]
	private void set_PreviousState(EPlayerState value) { }

	public void set_Rotation(Vector2 value) { }

	public override void UpdateAnimatorRotationParameters() { }

}

