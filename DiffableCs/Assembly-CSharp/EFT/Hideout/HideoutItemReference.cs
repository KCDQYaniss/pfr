namespace EFT.Hideout;

[JsonObject(MemberSerialization::OptIn (1))]
public struct HideoutItemReference : IExchangeable
{
	[CompilerGenerated]
	private IExchangeRequirement[] <Requirements>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Item <Item>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly bool <OnlyMoney>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <SellInOnePiece>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private int <BuyRestrictionMax>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <BuyRestrictionCurrent>k__BackingField; //Field offset: 0x18
	[JsonProperty("count")]
	public int Count; //Field offset: 0x1C
	public bool RemoveReferenceItem; //Field offset: 0x20
	[JsonIgnore]
	public bool IsTool; //Field offset: 0x21

	public override int BuyRestrictionCurrent
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override int BuyRestrictionMax
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override int CurrentItemCount
	{
		 get { } //Length: 53
	}

	public override DateTime EndTime
	{
		 get { } //Length: 84
	}

	[JsonProperty("id")]
	public override string Id
	{
		 get { } //Length: 15
	}

	public override Item Item
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override EMemberCategory MemberType
	{
		 get { } //Length: 6
	}

	public override bool OnlyMoney
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public override IExchangeRequirement[] Requirements
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override bool SellInOnePiece
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public string TemplateId
	{
		 get { } //Length: 445
	}

	[CompilerGenerated]
	[IsReadOnly]
	public override int get_BuyRestrictionCurrent() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override int get_BuyRestrictionMax() { }

	public override int get_CurrentItemCount() { }

	public override DateTime get_EndTime() { }

	public override string get_Id() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override Item get_Item() { }

	public override EMemberCategory get_MemberType() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override bool get_OnlyMoney() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override IExchangeRequirement[] get_Requirements() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override bool get_SellInOnePiece() { }

	public string get_TemplateId() { }

	[CompilerGenerated]
	public override void set_BuyRestrictionCurrent(int value) { }

	[CompilerGenerated]
	public void set_BuyRestrictionMax(int value) { }

	[CompilerGenerated]
	public void set_Item(Item value) { }

	[CompilerGenerated]
	public void set_Requirements(IExchangeRequirement[] value) { }

}

