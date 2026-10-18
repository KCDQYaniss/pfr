namespace EFT;

public sealed class RagfairRequirementSerializer : ISerializer
{
	public string _tpl; //Field offset: 0x10
	public double count; //Field offset: 0x18
	public int level; //Field offset: 0x20
	public EDogtagExchangeSide side; //Field offset: 0x24
	public bool onlyFunctional; //Field offset: 0x28

	public RagfairRequirementSerializer() { }

	public override HandoverRequirement Deserialize() { }

	public override object Serialize(HandoverRequirement t) { }

}

