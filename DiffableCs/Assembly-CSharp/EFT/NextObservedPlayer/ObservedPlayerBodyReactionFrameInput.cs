namespace EFT.NextObservedPlayer;

public struct ObservedPlayerBodyReactionFrameInput
{
	public float3 Spine3EulerDegrees; //Field offset: 0x0
	public float3 Spine1EulerDegrees; //Field offset: 0xC
	public quaternion Spine3AnimBaselineLocal; //Field offset: 0x18
	public quaternion Spine1AnimBaselineLocal; //Field offset: 0x28
	public Transform Spine3; //Field offset: 0x38
	public Transform Spine1; //Field offset: 0x40
	public Transform Pelvis; //Field offset: 0x48
	public Transform LeftThigh; //Field offset: 0x50
	public Transform LeftCalf; //Field offset: 0x58
	public Transform LeftFoot; //Field offset: 0x60
	public Transform RightThigh; //Field offset: 0x68
	public Transform RightCalf; //Field offset: 0x70
	public Transform RightFoot; //Field offset: 0x78
	public float3 PelvisLocalOffsetMeters; //Field offset: 0x80
	public bool SuppressBodyPositionApply; //Field offset: 0x8C

	public static ObservedPlayerBodyReactionFrameInput Default
	{
		 get { } //Length: 45
	}

	public bool HasPelvisReaction
	{
		 get { } //Length: 1193
	}

	public bool HasSpineReaction
	{
		 get { } //Length: 375
	}

	public static ObservedPlayerBodyReactionFrameInput get_Default() { }

	public bool get_HasPelvisReaction() { }

	public bool get_HasSpineReaction() { }

}

