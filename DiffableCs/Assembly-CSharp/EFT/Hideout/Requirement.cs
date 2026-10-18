namespace EFT.Hideout;

public abstract class Requirement
{
	[CompilerGenerated]
	private EAreaType <SourceAreaType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <SourceAreaLevel>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <Fulfilled>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private InventoryError <Error>k__BackingField; //Field offset: 0x20
	[JsonIgnore]
	public readonly BindableEvent OnFulfillmentChange; //Field offset: 0x28
	private int _userValue; //Field offset: 0x30

	[JsonIgnore]
	public InventoryError Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[JsonIgnore]
	public private override bool Fulfilled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonIgnore]
	public private int SourceAreaLevel
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonIgnore]
	public private EAreaType SourceAreaType
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("type")]
	public abstract ERequirementType Type
	{
		 get { } //Length: 0
	}

	protected Requirement() { }

	[CompilerGenerated]
	public InventoryError get_Error() { }

	[CompilerGenerated]
	public override bool get_Fulfilled() { }

	[CompilerGenerated]
	public int get_SourceAreaLevel() { }

	[CompilerGenerated]
	public EAreaType get_SourceAreaType() { }

	public abstract ERequirementType get_Type() { }

	public void Init(EAreaType sourceAreaType, int sourceAreaLevel) { }

	[CompilerGenerated]
	protected void set_Error(InventoryError value) { }

	[CompilerGenerated]
	private void set_Fulfilled(bool value) { }

	[CompilerGenerated]
	private void set_SourceAreaLevel(int value) { }

	[CompilerGenerated]
	private void set_SourceAreaType(EAreaType value) { }

	protected void SetFulfillment(bool value) { }

	protected void TestRequirement(int userValue, int targetValue) { }

}

