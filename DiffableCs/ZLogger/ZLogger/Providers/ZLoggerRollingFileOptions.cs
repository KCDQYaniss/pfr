namespace ZLogger.Providers;

public sealed class ZLoggerRollingFileOptions : ZLoggerFileOptions
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Func <FilePathSelector>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private RollingInterval <RollingInterval>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private int <RollingSizeKB>k__BackingField; //Field offset: 0x54

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Func FilePathSelector
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RollingInterval RollingInterval
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int RollingSizeKB
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ZLoggerRollingFileOptions() { }

	[CompilerGenerated]
	public Func get_FilePathSelector() { }

	[CompilerGenerated]
	public RollingInterval get_RollingInterval() { }

	[CompilerGenerated]
	public int get_RollingSizeKB() { }

	[CompilerGenerated]
	public void set_FilePathSelector(Func value) { }

	[CompilerGenerated]
	public void set_RollingInterval(RollingInterval value) { }

	[CompilerGenerated]
	public void set_RollingSizeKB(int value) { }

}

