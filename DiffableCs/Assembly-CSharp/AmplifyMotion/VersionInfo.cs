namespace AmplifyMotion;

public class VersionInfo
{
	public const byte Major = 1; //Field offset: 0x0
	public const byte Minor = 8; //Field offset: 0x0
	public const byte Release = 1; //Field offset: 0x0
	private static string StageSuffix; //Field offset: 0x0
	private static string TrialSuffix; //Field offset: 0x8
	[SerializeField]
	private int m_major; //Field offset: 0x10
	[SerializeField]
	private int m_minor; //Field offset: 0x14
	[SerializeField]
	private int m_release; //Field offset: 0x18

	public int Number
	{
		 get { } //Length: 24
	}

	private static VersionInfo() { }

	private VersionInfo() { }

	private VersionInfo(byte major, byte minor, byte release) { }

	public static VersionInfo Current() { }

	public int get_Number() { }

	public static bool Matches(VersionInfo version) { }

	public static string StaticToString() { }

	public virtual string ToString() { }

}

