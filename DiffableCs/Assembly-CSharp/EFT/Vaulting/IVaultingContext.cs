namespace EFT.Vaulting;

public interface IVaultingContext
{

	public bool DisablesVaultingByObstacles
	{
		 get { } //Length: 0
	}

	public bool IsGrounded
	{
		 get { } //Length: 0
	}

	public bool IsSprintEnabled
	{
		 get { } //Length: 0
	}

	public Vector3 MovementDirection
	{
		 get { } //Length: 0
	}

	public Vector3 PlayerRealForward
	{
		 get { } //Length: 0
	}

	public Transform VaultingGridRoot
	{
		 get { } //Length: 0
	}

	public bool get_DisablesVaultingByObstacles() { }

	public bool get_IsGrounded() { }

	public bool get_IsSprintEnabled() { }

	public Vector3 get_MovementDirection() { }

	public Vector3 get_PlayerRealForward() { }

	public Transform get_VaultingGridRoot() { }

	public bool IsAnimatorInTransitionState(int layer) { }

	public bool PlayerAnimatorGetIsVaulting() { }

	public float PlayerAnimatorGetObstacleHeight() { }

	public float PlayerAnimatorGetObstacleLength() { }

	public bool PlayerAnimatorIsJumpSetted() { }

	public void PlayerAnimatorSetAbsoluteForwardVelocity(float absoluteForwardVelocity) { }

	public void PlayerAnimatorSetBehindObstacleRatio(float height) { }

	public void PlayerAnimatorSetDoClimb(bool doClimb) { }

	public void PlayerAnimatorSetDoVault(bool doVault) { }

	public void PlayerAnimatorSetIsVaulting(bool isVaulting) { }

	public void PlayerAnimatorSetObstacleHeight(float height) { }

	public void PlayerAnimatorSetObstacleLength(float length) { }

	public void UpdateVaultingSpeedLimit() { }

	public Vector3 VelocityProjectionOnRealForward() { }

}

