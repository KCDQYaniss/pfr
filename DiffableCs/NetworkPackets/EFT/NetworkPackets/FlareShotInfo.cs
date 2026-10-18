namespace EFT.NetworkPackets;

public struct FlareShotInfo
{
	public bool StartOneShotFire; //Field offset: 0x0
	public bool WasShot; //Field offset: 0x1
	public Vector3 ShotPosition; //Field offset: 0x4
	public Vector3 ShotForward; //Field offset: 0x10

	public virtual string ToString() { }

}

