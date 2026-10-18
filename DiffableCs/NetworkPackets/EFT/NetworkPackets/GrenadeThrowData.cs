namespace EFT.NetworkPackets;

public struct GrenadeThrowData
{
	public bool HasThrowData; //Field offset: 0x0
	public Quaternion ThrowGrenadeRotation; //Field offset: 0x4
	public Vector3 ThrowGreanadePosition; //Field offset: 0x14
	public Vector3 ThrowForce; //Field offset: 0x20
	public bool LowThrow; //Field offset: 0x2C

}

