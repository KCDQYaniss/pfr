namespace EFT.Network.Quality;

public sealed class NetworkQualityParam
{
	public bool KickEnabled; //Field offset: 0x10
	public int Threshold; //Field offset: 0x14
	public int TrackingSeconds; //Field offset: 0x18
	public int TrackingPauseSeconds; //Field offset: 0x1C

	public NetworkQualityParam() { }

	public virtual string ToString() { }

}

