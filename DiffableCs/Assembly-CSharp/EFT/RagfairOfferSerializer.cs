namespace EFT;

public sealed class RagfairOfferSerializer : ISerializer
{
	public string _id; //Field offset: 0x10
	public long intId; //Field offset: 0x18
	public Merchant user; //Field offset: 0x20
	public FlatItem[] items; //Field offset: 0x28
	public string root; //Field offset: 0x30
	public int itemsCost; //Field offset: 0x38
	public int requirementsCost; //Field offset: 0x3C
	public HandoverRequirement[] requirements; //Field offset: 0x40
	public double startTime; //Field offset: 0x48
	public double endTime; //Field offset: 0x50
	public bool wasEdit; //Field offset: 0x58
	public bool exchange; //Field offset: 0x59
	public int loyaltyLevel; //Field offset: 0x5C
	public bool locked; //Field offset: 0x60
	public bool unlimitedCount; //Field offset: 0x61
	public int buyRestrictionMax; //Field offset: 0x64
	public int buyRestrictionCurrent; //Field offset: 0x68
	public bool sellInOnePiece; //Field offset: 0x6C
	public int summaryCost; //Field offset: 0x70
	public int quantity; //Field offset: 0x74

	public RagfairOfferSerializer() { }

	public override Offer Deserialize() { }

	public override object Serialize(Offer t) { }

}

