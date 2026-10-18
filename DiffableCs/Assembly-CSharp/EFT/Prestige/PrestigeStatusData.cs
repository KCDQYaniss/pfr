namespace EFT.Prestige;

[GenerateBinarySerialization]
public sealed class PrestigeStatusData
{
	public MongoID TemplateId; //Field offset: 0x10
	public int Timestamp; //Field offset: 0x28

	public PrestigeStatusData() { }

	public PrestigeStatusData(MongoID templateId, int timestamp) { }

}

