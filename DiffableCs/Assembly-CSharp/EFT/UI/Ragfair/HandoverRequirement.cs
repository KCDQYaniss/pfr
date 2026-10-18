namespace EFT.UI.Ragfair;

public sealed class HandoverRequirement : IExchangeRequirement
{
	[CompilerGenerated]
	private Offer <Offer>k__BackingField; //Field offset: 0x10
	private Item _item; //Field offset: 0x18
	public int Level; //Field offset: 0x20
	public EDogtagExchangeSide Side; //Field offset: 0x24
	[CompilerGenerated]
	private readonly string <TemplateId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly int <IntCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly double <PreciseCount>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly bool <OnlyFunctional>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly bool <IsEncoded>k__BackingField; //Field offset: 0x41
	[CompilerGenerated]
	private readonly bool <IsSpawnedInSession>k__BackingField; //Field offset: 0x42

	public override int IntCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override bool IsEncoded
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool IsSpawnedInSession
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Item Item
	{
		 get { } //Length: 578
	}

	public override string ItemName
	{
		 get { } //Length: 171
	}

	public private Offer Offer
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override bool OnlyFunctional
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override double PreciseCount
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public override string TemplateId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public HandoverRequirement() { }

	public HandoverRequirement(string template, double itemCount, bool onlyFunctional, bool isEncoded = false) { }

	[CompilerGenerated]
	public override int get_IntCount() { }

	[CompilerGenerated]
	public override bool get_IsEncoded() { }

	[CompilerGenerated]
	public override bool get_IsSpawnedInSession() { }

	public override Item get_Item() { }

	public override string get_ItemName() { }

	[CompilerGenerated]
	private Offer get_Offer() { }

	[CompilerGenerated]
	public override bool get_OnlyFunctional() { }

	[CompilerGenerated]
	public override double get_PreciseCount() { }

	[CompilerGenerated]
	public override string get_TemplateId() { }

	[CompilerGenerated]
	public void set_Offer(Offer value) { }

}

