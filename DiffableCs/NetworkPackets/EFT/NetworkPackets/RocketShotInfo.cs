namespace EFT.NetworkPackets;

public struct RocketShotInfo
{
	public bool HasCriticalData; //Field offset: 0x0
	public Vector3 ShotPosition; //Field offset: 0x4
	public Vector3 ShotForward; //Field offset: 0x10

	public virtual string ToString() { }

}

