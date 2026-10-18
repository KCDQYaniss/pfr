namespace EFT.Hideout;

[DefaultMember("Item")]
public sealed class AreaPanelSettings : SerializedScriptableObject
{
	public Dictionary StatusAreaMap; //Field offset: 0x58

	public Sprite Item
	{
		 get { } //Length: 86
	}

	public AreaPanelSettings() { }

	public Sprite get_Item(EAreaStatus status) { }

}

