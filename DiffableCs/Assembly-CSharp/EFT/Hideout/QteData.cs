namespace EFT.Hideout;

public class QteData
{
	internal enum EQteActivityType
	{
		Gym = 0,
	}

	internal enum EQteEffectType
	{
		FinishEffect = 0,
		SingleSuccessEffect = 1,
		SingleFailEffect = 2,
	}

	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EQteActivityType <Type>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EAreaType <AreaType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <AreaLevel>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private QuickTimeEvent[] <QuickTimeEvents>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Requirement[] <Requirements>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Dictionary <Results>k__BackingField; //Field offset: 0x38

	[JsonProperty("AreaLevel")]
	public private int AreaLevel
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("Area")]
	public private EAreaType AreaType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("Id")]
	public private string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("QuickTimeEvents")]
	public private QuickTimeEvent[] QuickTimeEvents
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("Requirements")]
	public private Requirement[] Requirements
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("Results")]
	public private Dictionary Results
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("Type")]
	[SerializeField]
	public private EQteActivityType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public QteData() { }

	[CompilerGenerated]
	public int get_AreaLevel() { }

	[CompilerGenerated]
	public EAreaType get_AreaType() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public QuickTimeEvent[] get_QuickTimeEvents() { }

	[CompilerGenerated]
	public Requirement[] get_Requirements() { }

	[CompilerGenerated]
	public Dictionary get_Results() { }

	[CompilerGenerated]
	public EQteActivityType get_Type() { }

	[CompilerGenerated]
	private void set_AreaLevel(int value) { }

	[CompilerGenerated]
	private void set_AreaType(EAreaType value) { }

	[CompilerGenerated]
	private void set_Id(string value) { }

	[CompilerGenerated]
	private void set_QuickTimeEvents(QuickTimeEvent[] value) { }

	[CompilerGenerated]
	private void set_Requirements(Requirement[] value) { }

	[CompilerGenerated]
	private void set_Results(Dictionary value) { }

	[CompilerGenerated]
	private void set_Type(EQteActivityType value) { }

	public void Update(QteData backendData) { }

}

