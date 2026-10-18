namespace EFT.UI.Ragfair;

public sealed class Offer : IExchangeable
{
	internal sealed class Merchant
	{
		[JsonProperty("Id")]
		public MongoID Id; //Field offset: 0x10
		[JsonProperty("Aid")]
		public int Aid; //Field offset: 0x28
		[JsonProperty("Nickname")]
		public string Nickname; //Field offset: 0x30
		[JsonProperty("Rating")]
		public float Rating; //Field offset: 0x38
		[JsonProperty("MemberType")]
		public EMemberCategory MemberType; //Field offset: 0x3C
		[JsonProperty("Avatar")]
		public string Avatar; //Field offset: 0x40
		[JsonProperty("IsRatingGrowing")]
		public bool IsRatingGrowing; //Field offset: 0x48
		[JsonProperty("selectedMemberCategory")]
		public EMemberCategory SelectedMemberType; //Field offset: 0x4C

		public string CorrectedNickname
		{
			 get { } //Length: 276
		}

		public Merchant() { }

		public string get_CorrectedNickname() { }

	}

	private const int RENEW_MODIFIER = 25; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnSelectToPurchase; //Field offset: 0x10
	public long IntId; //Field offset: 0x18
	public int ItemsCost; //Field offset: 0x20
	public int RequirementsCost; //Field offset: 0x24
	public DateTime StartTime; //Field offset: 0x28
	public string Name; //Field offset: 0x30
	public string ShortName; //Field offset: 0x38
	public int LoyaltyLevel; //Field offset: 0x40
	public bool Locked; //Field offset: 0x44
	public bool UnlimitedCount; //Field offset: 0x45
	public int SummaryCost; //Field offset: 0x48
	[JsonIgnore]
	public Merchant User; //Field offset: 0x50
	[JsonIgnore]
	public bool NotAvailable; //Field offset: 0x58
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Item <Item>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private IExchangeRequirement[] <Requirements>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <SellInOnePiece>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private DateTime <EndTime>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private int <Quantity>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private int <BuyRestrictionMax>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private int <BuyRestrictionCurrent>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private bool <AvailableTimePassed>k__BackingField; //Field offset: 0x94

	public event Action OnSelectToPurchase
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool AvailableTimePassed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[JsonIgnore]
	public override int BuyRestrictionCurrent
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int BuyRestrictionMax
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool CanBeBought
	{
		 get { } //Length: 75
	}

	public override int CurrentItemCount
	{
		 get { } //Length: 36
	}

	public override DateTime EndTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool Expired
	{
		 get { } //Length: 267
	}

	public override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override Item Item
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool LimitsReached
	{
		 get { } //Length: 28
	}

	public override EMemberCategory MemberType
	{
		 get { } //Length: 26
	}

	public ECurrencyType MoneyType
	{
		 get { } //Length: 256
	}

	[JsonIgnore]
	public override bool OnlyMoney
	{
		 get { } //Length: 260
	}

	public int Quantity
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public int RenewPercent
	{
		 get { } //Length: 278
	}

	public override IExchangeRequirement[] Requirements
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override bool SellInOnePiece
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int TotalItemCount
	{
		 get { } //Length: 7
	}

	public Offer() { }

	[CompilerGenerated]
	public void add_OnSelectToPurchase(Action value) { }

	public static Offer CreateUnavailableOffer(string templateId) { }

	public void DeselectFromPurchase() { }

	[CompilerGenerated]
	public bool get_AvailableTimePassed() { }

	[CompilerGenerated]
	public override int get_BuyRestrictionCurrent() { }

	[CompilerGenerated]
	public override int get_BuyRestrictionMax() { }

	public bool get_CanBeBought() { }

	public override int get_CurrentItemCount() { }

	[CompilerGenerated]
	public override DateTime get_EndTime() { }

	public bool get_Expired() { }

	[CompilerGenerated]
	public override string get_Id() { }

	[CompilerGenerated]
	public override Item get_Item() { }

	public bool get_LimitsReached() { }

	public override EMemberCategory get_MemberType() { }

	public ECurrencyType get_MoneyType() { }

	public override bool get_OnlyMoney() { }

	[CompilerGenerated]
	public int get_Quantity() { }

	public int get_RenewPercent() { }

	[CompilerGenerated]
	public override IExchangeRequirement[] get_Requirements() { }

	[CompilerGenerated]
	public override bool get_SellInOnePiece() { }

	public int get_TotalItemCount() { }

	[CompilerGenerated]
	public void remove_OnSelectToPurchase(Action value) { }

	public void SelectToPurchase() { }

	[CompilerGenerated]
	public void set_AvailableTimePassed(bool value) { }

	[CompilerGenerated]
	public override void set_BuyRestrictionCurrent(int value) { }

	[CompilerGenerated]
	public void set_BuyRestrictionMax(int value) { }

	[CompilerGenerated]
	public void set_EndTime(DateTime value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_Item(Item value) { }

	[CompilerGenerated]
	public void set_Quantity(int value) { }

	[CompilerGenerated]
	public void set_Requirements(IExchangeRequirement[] value) { }

	[CompilerGenerated]
	public void set_SellInOnePiece(bool value) { }

	public virtual string ToString() { }

}

