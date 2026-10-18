namespace EFT.SeasonBP;

public sealed class BattlePassDocumentScheme
{
	public readonly MongoID Id; //Field offset: 0x10
	public readonly ImageData Image; //Field offset: 0x28
	public readonly ImageData InactiveImage; //Field offset: 0x30
	public readonly MongoID TemplateId; //Field offset: 0x38
	private BattlePassItem _item; //Field offset: 0x50
	public readonly string DescriptionLocaleKey; //Field offset: 0x58

	public BattlePassItem Item
	{
		 get { } //Length: 756
	}

	public BattlePassDocumentScheme(BattlePassDocumentSchemeData data) { }

	public BattlePassDocumentScheme(BattlePassUniversalDocumentData data) { }

	public BattlePassItem get_Item() { }

}

