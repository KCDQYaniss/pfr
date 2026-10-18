//Type is in global namespace

public class KhorovodBotGameEvent : BotData
{
	[CompilerGenerated]
	private readonly ChristmasTreePoI <ChristmasTree>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <InKhorovod>k__BackingField; //Field offset: 0x21

	public ChristmasTreePoI ChristmasTree
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private bool InKhorovod
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public KhorovodBotGameEvent(BotOwner owner) { }

	[CompilerGenerated]
	public ChristmasTreePoI get_ChristmasTree() { }

	[CompilerGenerated]
	public bool get_InKhorovod() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	public void OnEnterKhorovod() { }

	[CompilerGenerated]
	private void set_InKhorovod(bool value) { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

}

