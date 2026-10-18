namespace EFT;

public sealed class GameDateTime
{
	private const string DateFormat = "d"; //Field offset: 0x0
	private const string TimeFormat = "HH:mm:ss"; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Debug>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private DateTime <StatedRealDateTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private DateTime <StatedGameDateTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <TimeFactor>k__BackingField; //Field offset: 0x28
	public float TimeFactorMod; //Field offset: 0x2C
	private float _realtimeSinceStartup; //Field offset: 0x30
	private bool _locked; //Field offset: 0x34

	internal bool Debug
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool Locked
	{
		 get { } //Length: 5
	}

	internal DateTime StatedGameDateTime
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal DateTime StatedRealDateTime
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private float TimeFactor
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	internal GameDateTime(DateTime realDateTime, DateTime gameDateTime, float timeFactor, bool debug = false) { }

	public DateTime Calculate() { }

	public DateTime CalculateTaxonomyDate(DateTime todSkyDateTime) { }

	internal static GameDateTime Create(DateTime realDateTime, ref string gameDate, ref string gameTime, ref float timeFactor, bool debug = false) { }

	public static GameDateTime CreateDebug() { }

	public static GameDateTime Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	internal bool get_Debug() { }

	public bool get_Locked() { }

	[CompilerGenerated]
	internal DateTime get_StatedGameDateTime() { }

	[CompilerGenerated]
	internal DateTime get_StatedRealDateTime() { }

	[CompilerGenerated]
	public float get_TimeFactor() { }

	internal static DateTime GetDateTime(string date, string time) { }

	public void Lock() { }

	private DateTime RealDateTime() { }

	public void Reset(DateTime realDateTime, string gameDate, string gameTime, float timeFactor) { }

	public void Reset(DateTime gameDateTime) { }

	public void Reset(DateTime realDateTime, DateTime gameDateTime, float timeFactor) { }

	public void Reset(DateTime realDateTime, DateTime gameDateTime, float timeFactor, bool force) { }

	public void ResetForce(DateTime gameDateTime) { }

	public void Serialize(NetworkWriter writer, bool gameOnly) { }

	[CompilerGenerated]
	private void set_Debug(bool value) { }

	[CompilerGenerated]
	private void set_StatedGameDateTime(DateTime value) { }

	[CompilerGenerated]
	private void set_StatedRealDateTime(DateTime value) { }

	[CompilerGenerated]
	private void set_TimeFactor(float value) { }

	public void Unlock() { }

	public static void Validate(ref string date, ref string time, ref float timeFactor, bool init) { }

}

