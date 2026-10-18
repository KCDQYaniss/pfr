namespace EFT.NextObservedPlayer;

public struct ObservedPlayerMovementBurst
{
	public float3 BodyPosition; //Field offset: 0x0
	public float3 HeadRotation; //Field offset: 0xC
	public float2 MovementDirection; //Field offset: 0x18
	public float3 Velocity; //Field offset: 0x20
	public float Tilt; //Field offset: 0x2C
	public int Step; //Field offset: 0x30
	public int BlindFire; //Field offset: 0x34
	public int StateAnimatorIndex; //Field offset: 0x38
	public int State; //Field offset: 0x3C
	public int PhysicalCondition; //Field offset: 0x40
	public float MovementSpeed; //Field offset: 0x44
	public float SprintSpeed; //Field offset: 0x48
	public float MaxSpeed; //Field offset: 0x4C
	public int Pose; //Field offset: 0x50
	public float PoseLevel; //Field offset: 0x54
	public float InHandsObjectOverlap; //Field offset: 0x58
	public byte IsGrounded; //Field offset: 0x5C
	public float JumpHeight; //Field offset: 0x60
	public float FallHeight; //Field offset: 0x64
	public float FallTime; //Field offset: 0x68
	public byte LeftStance; //Field offset: 0x6C
	public float AimRotation; //Field offset: 0x70
	public quaternion FootRotation; //Field offset: 0x74
	public float3 WeaponLocalPosition; //Field offset: 0x84
	public float3 WeaponLocalRotation; //Field offset: 0x90

}

