namespace AmplifyImpostors;

public class VersionInfo
{
	public const byte Major = 0; //Field offset: 0x0
	public const byte Minor = 9; //Field offset: 0x0
	public const byte Release = 7; //Field offset: 0x0
	public static byte Revision; //Field offset: 0x0

	public static string FullLabel
	{
		 get { } //Length: 308
	}

	public static int FullNumber
	{
		 get { } //Length: 88
	}

	private static VersionInfo() { }

	public VersionInfo() { }

	public static string get_FullLabel() { }

	public static int get_FullNumber() { }

	public static string StaticToString() { }

}

