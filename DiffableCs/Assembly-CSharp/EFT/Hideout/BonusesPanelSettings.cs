namespace EFT.Hideout;

[DefaultMember("Item")]
public sealed class BonusesPanelSettings : SerializedScriptableObject
{
	public Dictionary BonusTypeMap; //Field offset: 0x58
	public Dictionary SkillTypeMap; //Field offset: 0x60
	public Dictionary SkillIdMap; //Field offset: 0x68

	public Sprite Item
	{
		 get { } //Length: 321
	}

	public BonusesPanelSettings() { }

	public Sprite get_Item(Enum status) { }

}

