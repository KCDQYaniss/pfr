namespace EFT.NetworkPackets;

public struct CorpseImpulse
{
	public EBodyPartColliderType BodyPartColliderType; //Field offset: 0x0
	public Vector3 Direction; //Field offset: 0x4
	public Vector3 Point; //Field offset: 0x10
	public float Force; //Field offset: 0x1C
	public Vector3 OverallVelocity; //Field offset: 0x20

}

