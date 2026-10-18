namespace EFT.NetworkPackets;

public struct LauncherReloadInfo
{
	public bool Reload; //Field offset: 0x0
	public string[] AmmoIds; //Field offset: 0x8

	public virtual string ToString() { }

}

