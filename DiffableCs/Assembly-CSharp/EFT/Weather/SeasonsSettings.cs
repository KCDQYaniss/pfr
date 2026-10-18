namespace EFT.Weather;

public sealed class SeasonsSettings
{
	public static Vector3 SpringSnowFactorDefault; //Field offset: 0x0
	public Vector3 SpringSnowFactor; //Field offset: 0x10

	public static SeasonsSettings Default
	{
		 get { } //Length: 202
	}

	private static SeasonsSettings() { }

	public SeasonsSettings() { }

	public void Deserialize(NetworkReader reader) { }

	public void Deserialize(IBitReaderStream stream) { }

	public static SeasonsSettings get_Default() { }

	public void Serialize(NetworkWriter writer) { }

	public void Serialize(IBitWriterStream stream) { }

}

