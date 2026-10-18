namespace EFT;

public abstract class VaultingMovementState : MovementState
{
	private const float MOVE_DIRECTION_THRESHOLD = 0.1; //Field offset: 0x0
	private float _cachedColliderHeight; //Field offset: 0xA0
	private Vector3 _cachedColliderCenter; //Field offset: 0xA4
	private float _cachedColliderRadius; //Field offset: 0xB0
	[CompilerGenerated]
	private float <vaultingHeight>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private float <vaultingLength>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private Nullable <currentMotion>k__BackingField; //Field offset: 0xBC
	private Vector3 _cachedRotation; //Field offset: 0xCC
	private Quaternion _lastRotation; //Field offset: 0xD8

	protected Nullable currentMotion
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 11
	}

	protected private float vaultingHeight
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	protected private float vaultingLength
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public VaultingMovementState(MovementContext movementContext) { }

	protected virtual void ApplyMotion(ref Vector3 motion, float deltaTime) { }

	private void CacheColliderParams() { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	[CompilerGenerated]
	protected Nullable get_currentMotion() { }

	[CompilerGenerated]
	protected float get_vaultingHeight() { }

	[CompilerGenerated]
	protected float get_vaultingLength() { }

	public virtual void Move(Vector2 move) { }

	protected abstract void RecalculateCapsuleColliderSize() { }

	protected override void RotateAction(Player player) { }

	[CompilerGenerated]
	protected void set_currentMotion(Nullable value) { }

	[CompilerGenerated]
	private void set_vaultingHeight(float value) { }

	[CompilerGenerated]
	private void set_vaultingLength(float value) { }

	protected void SetCachedColliderParams() { }

	private void SetDefaultColliderSize() { }

}

