namespace EFT.Hideout;

public sealed class Improvement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8
		public static Func <>9__12_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Bonus <OnDeserialized>b__12_0(BonusDescriptor bonus) { }

		internal BonusDescriptor <OnSerializing>b__11_0(Bonus bonus) { }

	}

	[JsonProperty("id")]
	public string Id; //Field offset: 0x10
	[JsonProperty("requirements")]
	public Requirement[] Requirements; //Field offset: 0x18
	[JsonProperty("bonuses")]
	private BonusDescriptor[] _bonusDescriptors; //Field offset: 0x20
	[JsonIgnore]
	public Bonus[] Bonuses; //Field offset: 0x28
	[JsonProperty("improvementTime")]
	public int ImprovementTime; //Field offset: 0x30
	[JsonIgnore]
	public bool Completed; //Field offset: 0x34
	[JsonIgnore]
	public int CompleteTimestamp; //Field offset: 0x38

	public bool Processing
	{
		 get { } //Length: 17
	}

	public bool Waiting
	{
		 get { } //Length: 17
	}

	public Improvement() { }

	public void ClearData() { }

	public bool get_Processing() { }

	public bool get_Waiting() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext context) { }

	public int TimeLeft() { }

	public int TimePassed() { }

	public void UpdateData(ImprovementData value) { }

}

