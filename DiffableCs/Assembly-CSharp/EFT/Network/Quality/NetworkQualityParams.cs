namespace EFT.Network.Quality;

public sealed class NetworkQualityParams
{
	public NetworkQualityParam Ping; //Field offset: 0x10
	public NetworkQualityParam Loss; //Field offset: 0x18

	public NetworkQualityParams() { }

	public virtual string ToString() { }

}

