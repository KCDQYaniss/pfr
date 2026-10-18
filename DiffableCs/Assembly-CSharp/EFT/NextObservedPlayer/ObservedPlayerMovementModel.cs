namespace EFT.NextObservedPlayer;

public struct ObservedPlayerMovementModel
{
	public Vector3 BodyPosition; //Field offset: 0x0
	public Vector3 HeadRotation; //Field offset: 0xC
	public Vector2 MovementDirection; //Field offset: 0x18
	public Vector3 Velocity; //Field offset: 0x20
	public float Tilt; //Field offset: 0x2C
	public int Step; //Field offset: 0x30
	public int BlindFire; //Field offset: 0x34
	public int StateAnimatorIndex; //Field offset: 0x38
	public EPlayerState State; //Field offset: 0x3C
	public EPhysicalCondition PhysicalCondition; //Field offset: 0x40
	public float MovementSpeed; //Field offset: 0x44
	public float SprintSpeed; //Field offset: 0x48
	public float MaxSpeed; //Field offset: 0x4C
	public EPlayerPose Pose; //Field offset: 0x50
	public float PoseLevel; //Field offset: 0x54
	public float InHandsObjectOverlap; //Field offset: 0x58
	public bool IsGrounded; //Field offset: 0x5C
	public float JumpHeight; //Field offset: 0x60
	public float FallHeight; //Field offset: 0x64
	public float FallTime; //Field offset: 0x68
	public bool LeftStance; //Field offset: 0x6C
	public float AimRotation; //Field offset: 0x70
	public Quaternion FootRotation; //Field offset: 0x74
	public Vector3 WeaponLocalPosition; //Field offset: 0x84
	public Vector3 WeaponLocalRotation; //Field offset: 0x90

}

