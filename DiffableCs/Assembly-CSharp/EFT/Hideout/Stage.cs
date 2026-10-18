namespace EFT.Hideout;

public class Stage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__2_8; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal RelatedData <get_Data>b__2_0() { }

		internal RelatedData <get_Data>b__2_8() { }

	}

	private Dictionary _data; //Field offset: 0x10
	[JsonProperty("requirements")]
	public RelatedRequirements Requirements; //Field offset: 0x18
	[JsonProperty("bonuses")]
	public RelatedBonuses Bonuses; //Field offset: 0x20
	[JsonProperty("constructionTime")]
	public RelatedConstructionTime ConstructionTime; //Field offset: 0x28
	public RelatedBoost Boost; //Field offset: 0x30
	public RelatedFuelSupply FuelSupply; //Field offset: 0x38
	public RelatedProduction Production; //Field offset: 0x40
	public RelatedImprovement Improvements; //Field offset: 0x48
	public RelatedSounds Sounds; //Field offset: 0x50
	public RelatedQteData QteData; //Field offset: 0x58
	[HideInInspector]
	public RelatedInteractions Interactions; //Field offset: 0x60
	[HideInInspector]
	public RelatedProduction Decryption; //Field offset: 0x68
	public RelatedCustomPrefabData CustomPrefab; //Field offset: 0x70
	[MinValue(0)]
	public float HideoutProgress; //Field offset: 0x78
	[CompilerGenerated]
	private DateTime <StartTime>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private int <Level>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private bool <ActionGoing>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private bool <Waiting>k__BackingField; //Field offset: 0x8D
	[CompilerGenerated]
	private bool <ActionReady>k__BackingField; //Field offset: 0x8E
	[CompilerGenerated]
	private bool <AutoUpgrade>k__BackingField; //Field offset: 0x8F
	[CompilerGenerated]
	private bool <DisplayInterface>k__BackingField; //Field offset: 0x90

	public bool ActionGoing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool ActionReady
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool AutoUpgrade
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[JsonIgnore]
	public Dictionary Data
	{
		 get { } //Length: 1917
	}

	public bool DisplayInterface
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public int Level
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public DateTime StartTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool Waiting
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Stage() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_1() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_10() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_11() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_2() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_3() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_4() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_5() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_6() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_7() { }

	[CompilerGenerated]
	private RelatedData <get_Data>b__2_9() { }

	[CompilerGenerated]
	public bool get_ActionGoing() { }

	[CompilerGenerated]
	public bool get_ActionReady() { }

	[CompilerGenerated]
	public bool get_AutoUpgrade() { }

	public Dictionary get_Data() { }

	[CompilerGenerated]
	public bool get_DisplayInterface() { }

	[CompilerGenerated]
	public int get_Level() { }

	[CompilerGenerated]
	public DateTime get_StartTime() { }

	[CompilerGenerated]
	public bool get_Waiting() { }

	[CompilerGenerated]
	public void set_ActionGoing(bool value) { }

	[CompilerGenerated]
	public void set_ActionReady(bool value) { }

	[CompilerGenerated]
	public void set_AutoUpgrade(bool value) { }

	[CompilerGenerated]
	public void set_DisplayInterface(bool value) { }

	[CompilerGenerated]
	public void set_Level(int value) { }

	[CompilerGenerated]
	public void set_StartTime(DateTime value) { }

	[CompilerGenerated]
	public void set_Waiting(bool value) { }

	public void UpdateData(Stage stage) { }

}

