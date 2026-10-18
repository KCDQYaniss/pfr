namespace EFT;

public struct TransitionStatus
{
	[CompilerGenerated]
	private bool <InTransition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private string <Location>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <Training>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ESideType <Side>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private ERaidMode <Mode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EDateTime <Time>k__BackingField; //Field offset: 0x1C

	[JsonProperty]
	public private bool InTransition
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 3
	}

	[JsonProperty]
	public private string Location
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty]
	public private ERaidMode Mode
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty]
	public private ESideType Side
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty]
	public private EDateTime Time
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty]
	public private bool Training
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TransitionStatus(string targetLocation, bool training, ESideType side, ERaidMode mode, EDateTime time) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_InTransition() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_Location() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ERaidMode get_Mode() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ESideType get_Side() { }

	[CompilerGenerated]
	[IsReadOnly]
	public EDateTime get_Time() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_Training() { }

	[CompilerGenerated]
	private void set_InTransition(bool value) { }

	[CompilerGenerated]
	private void set_Location(string value) { }

	[CompilerGenerated]
	private void set_Mode(ERaidMode value) { }

	[CompilerGenerated]
	private void set_Side(ESideType value) { }

	[CompilerGenerated]
	private void set_Time(EDateTime value) { }

	[CompilerGenerated]
	private void set_Training(bool value) { }

}

