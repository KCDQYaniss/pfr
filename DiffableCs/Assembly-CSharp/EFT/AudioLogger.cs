namespace EFT;

public class AudioLogger : AbstractLogger
{
	private static AudioLogger _instance; //Field offset: 0x0

	public static AudioLogger Instance
	{
		 get { } //Length: 311
	}

	private AudioLogger() { }

	public static AudioLogger get_Instance() { }

}

