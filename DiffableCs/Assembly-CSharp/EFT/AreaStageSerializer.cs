namespace EFT;

public sealed class AreaStageSerializer : ISerializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		public static Func <>9__11_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Bonus <Deserialize>b__10_0(BonusDescriptor bonus) { }

		internal BonusDescriptor <Serialize>b__11_0(Bonus bonus) { }

	}

	[JsonProperty("requirements")]
	private Requirement[] _requirements; //Field offset: 0x10
	[JsonProperty("bonuses")]
	private BonusDescriptor[] _bonusDescriptors; //Field offset: 0x18
	[JsonProperty("constructionTime")]
	private float _constructionTime; //Field offset: 0x20
	[JsonProperty("boost")]
	private Requirement[] _boost; //Field offset: 0x28
	[JsonProperty("fuelSupply")]
	private FuelConsumption[] _fuelSupply; //Field offset: 0x30
	[JsonProperty("improvements")]
	private Improvement[] _improvements; //Field offset: 0x38
	[JsonProperty("startTime")]
	private double _startTime; //Field offset: 0x40
	[JsonProperty("autoUpgrade")]
	private bool _autoUpgrade; //Field offset: 0x48
	[JsonProperty("displayInterface")]
	private bool _displayInterface; //Field offset: 0x49
	private List _bonuses; //Field offset: 0x50

	public AreaStageSerializer() { }

	public override Stage Deserialize() { }

	public override object Serialize(Stage stage) { }

}

