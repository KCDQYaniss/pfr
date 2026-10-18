namespace EFT.Hideout;

public class ItemRequirement : Requirement, IExchangeRequirement
{
	private int _notEmptyCompoundItems; //Field offset: 0x38
	private Item _item; //Field offset: 0x40
	[CompilerGenerated]
	private string <TemplateId>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsSpawnedInSession>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <OnlyFunctional>k__BackingField; //Field offset: 0x51
	[CompilerGenerated]
	private bool <IsEncoded>k__BackingField; //Field offset: 0x52
	[CompilerGenerated]
	private int <UserItemsCount>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private int <IntCount>k__BackingField; //Field offset: 0x58
	private int _baseCount; //Field offset: 0x5C

	[JsonProperty("count")]
	public private int BaseCount
	{
		 get { } //Length: 4
		private set { } //Length: 7
	}

	public float CountModifier
	{
		 set { } //Length: 273
	}

	[JsonIgnore]
	public private override int IntCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("isEncoded")]
	public private override bool IsEncoded
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("isSpawnedInSession")]
	public private override bool IsSpawnedInSession
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonIgnore]
	public override Item Item
	{
		 get { } //Length: 372
	}

	[JsonIgnore]
	public override string ItemName
	{
		 get { } //Length: 171
	}

	[JsonProperty("isFunctional")]
	public private override bool OnlyFunctional
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override double PreciseCount
	{
		 get { } //Length: 10
	}

	[JsonProperty("templateId")]
	public private override string TemplateId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	[JsonIgnore]
	public private int UserItemsCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ItemRequirement() { }

	public int get_BaseCount() { }

	[CompilerGenerated]
	public override int get_IntCount() { }

	[CompilerGenerated]
	public override bool get_IsEncoded() { }

	[CompilerGenerated]
	public override bool get_IsSpawnedInSession() { }

	public override Item get_Item() { }

	public override string get_ItemName() { }

	[CompilerGenerated]
	public override bool get_OnlyFunctional() { }

	public override double get_PreciseCount() { }

	[CompilerGenerated]
	public override string get_TemplateId() { }

	public virtual ERequirementType get_Type() { }

	[CompilerGenerated]
	public int get_UserItemsCount() { }

	public static bool IsSuitableItem(IExchangeRequirement requirement, Item item) { }

	public bool IsSuitableItem(Item item) { }

	public void Retest() { }

	private void set_BaseCount(int value) { }

	public void set_CountModifier(float value) { }

	[CompilerGenerated]
	private void set_IntCount(int value) { }

	[CompilerGenerated]
	private void set_IsEncoded(bool value) { }

	[CompilerGenerated]
	private void set_IsSpawnedInSession(bool value) { }

	[CompilerGenerated]
	private void set_OnlyFunctional(bool value) { }

	[CompilerGenerated]
	private void set_TemplateId(string value) { }

	[CompilerGenerated]
	private void set_UserItemsCount(int value) { }

	public void Test(IEnumerable value) { }

}

