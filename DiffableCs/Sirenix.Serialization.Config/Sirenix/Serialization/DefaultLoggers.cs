namespace Sirenix.Serialization;

public static class DefaultLoggers
{
	private static readonly object LOCK; //Field offset: 0x0
	private static ILogger unityLogger; //Field offset: 0x8

	public static ILogger DefaultLogger
	{
		 get { } //Length: 69
	}

	public static ILogger UnityLogger
	{
		 get { } //Length: 1119
	}

	private static DefaultLoggers() { }

	public static ILogger get_DefaultLogger() { }

	public static ILogger get_UnityLogger() { }

}

