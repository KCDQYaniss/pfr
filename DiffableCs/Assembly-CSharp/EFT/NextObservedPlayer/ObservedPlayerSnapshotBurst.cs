namespace EFT.NextObservedPlayer;

public struct ObservedPlayerSnapshotBurst
{
	public float WorldTime; //Field offset: 0x0
	public double LocalTime; //Field offset: 0x8
	public float BodyRotationX; //Field offset: 0x10
	public float BodyRotationY; //Field offset: 0x14
	public float3 BodyPosition; //Field offset: 0x18
	public float2 HeadRotation; //Field offset: 0x24
	public float2 MovementDirection; //Field offset: 0x2C
	public float3 Velocity; //Field offset: 0x34
	public float Tilt; //Field offset: 0x40
	public int Step; //Field offset: 0x44
	public int BlindFire; //Field offset: 0x48
	public int StateAnimatorIndex; //Field offset: 0x4C
	public int State; //Field offset: 0x50
	public int PhysicalCondition; //Field offset: 0x54
	public float MovementSpeed; //Field offset: 0x58
	public float SprintSpeed; //Field offset: 0x5C
	public float MaxSpeed; //Field offset: 0x60
	public int Pose; //Field offset: 0x64
	public float PoseLevel; //Field offset: 0x68
	public float InHandsObjectOverlap; //Field offset: 0x6C
	public byte IsGrounded; //Field offset: 0x70
	public float JumpHeight; //Field offset: 0x74
	public float FallHeight; //Field offset: 0x78
	public float FallTime; //Field offset: 0x7C
	public byte LeftStance; //Field offset: 0x80
	public float3 WeaponLocalPosition; //Field offset: 0x84
	public float3 WeaponLocalRotation; //Field offset: 0x90

}

