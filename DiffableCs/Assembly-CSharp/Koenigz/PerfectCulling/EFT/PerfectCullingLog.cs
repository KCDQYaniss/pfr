namespace Koenigz.PerfectCulling.EFT;

public sealed class PerfectCullingLog : AbstractLogger
{
	private static PerfectCullingLog _instance; //Field offset: 0x0

	public static PerfectCullingLog Instance
	{
		 get { } //Length: 311
	}

	private PerfectCullingLog() { }

	public static void Debug(string msg) { }

	public static void Error(string msg) { }

	public static PerfectCullingLog get_Instance() { }

	public static void Throw(string msg) { }

	public static void Warning(string msg) { }

}

