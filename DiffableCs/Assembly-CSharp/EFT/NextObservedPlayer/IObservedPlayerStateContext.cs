namespace EFT.NextObservedPlayer;

public interface IObservedPlayerStateContext
{

	public Vector3 BodyPosition
	{
		 get { } //Length: 0
	}

	public Quaternion BodyRotation
	{
		 get { } //Length: 0
	}

	public ICharacterController CharacterController
	{
		 get { } //Length: 0
	}

	public FirearmsAnimator FirearmsAnimator
	{
		 get { } //Length: 0
	}

	public WorldInteractiveObject InteractionDoor
	{
		 get { } //Length: 0
	}

	public Item InteractionDoorKey
	{
		 get { } //Length: 0
	}

	public bool InteractionDoorResult
	{
		 get { } //Length: 0
	}

	public bool IsGrounded
	{
		 get { } //Length: 0
	}

	public bool IsInMountedState
	{
		 get { } //Length: 0
	}

	public PlayerAnimator PlayerAnimator
	{
		 get { } //Length: 0
	}

	public ProceduralWeaponAnimation ProceduralWeaponAnimation
	{
		 get { } //Length: 0
	}

	public Quaternion TargetBodyRotation
	{
		 get { } //Length: 0
	}

	public void ClearIKInteract() { }

	public void CreateKeyInHand(Item key) { }

	public void DestroyKeyInHand() { }

	public void EnableApproached(bool value) { }

	public void EnableKick(bool value) { }

	public void EnableKickSucceed(bool value) { }

	public void EnterStationary() { }

	public void ExitFromStationary() { }

	public Vector3 get_BodyPosition() { }

	public Quaternion get_BodyRotation() { }

	public ICharacterController get_CharacterController() { }

	public FirearmsAnimator get_FirearmsAnimator() { }

	public WorldInteractiveObject get_InteractionDoor() { }

	public Item get_InteractionDoorKey() { }

	public bool get_InteractionDoorResult() { }

	public bool get_IsGrounded() { }

	public bool get_IsInMountedState() { }

	public PlayerAnimator get_PlayerAnimator() { }

	public ProceduralWeaponAnimation get_ProceduralWeaponAnimation() { }

	public Quaternion get_TargetBodyRotation() { }

	public void ObservedDisableLeftStanceAnim() { }

	public void ObservedSetAnimatorLeftStanceToCacheValue() { }

	public void ObservedSetLeftStanceState(bool value) { }

	public void OnStateEnter(BaseMovementState nextState) { }

	public void OnStateExit(BaseMovementState state) { }

	public void OnStateMove(BaseMovementState state) { }

	public void SetIKInteract(GripPose grip) { }

	public void SetRotation(Quaternion value) { }

	public float UpdateIKInteract() { }

	public void UpdateStationaryWeaponPosition() { }

}

