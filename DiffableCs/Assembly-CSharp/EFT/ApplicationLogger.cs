namespace EFT;

public sealed class ApplicationLogger : AbstractLogger
{
	private static ApplicationLogger _instance; //Field offset: 0x0

	public static ApplicationLogger Instance
	{
		 get { } //Length: 311
	}

	private ApplicationLogger() { }

	public static ApplicationLogger get_Instance() { }

}

