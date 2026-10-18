namespace EFT.Customization;

public abstract class BaseCustomizationItem
{
	[JsonProperty("id")]
	public MongoID Id; //Field offset: 0x10
	[JsonProperty("name")]
	public string Name; //Field offset: 0x28
	[JsonProperty("parent")]
	public string Parent; //Field offset: 0x30
	[JsonProperty("side")]
	public EPlayerSide[] Side; //Field offset: 0x38
	[JsonProperty("hiddenByDefault")]
	public bool HiddenByDefault; //Field offset: 0x40
	[JsonProperty("ShopCustomizationUrl")]
	public string ExpansionsUrl; //Field offset: 0x48
	public string[] ProfileVersionsIgnoresSide; //Field offset: 0x50

	public abstract ECustomizationItemCategory Category
	{
		 get { } //Length: 0
	}

	public string DescriptionLocalizationKey
	{
		 get { } //Length: 176
	}

	public string NameLocalizationKey
	{
		 get { } //Length: 176
	}

	protected BaseCustomizationItem() { }

	public virtual bool Equals(object otherObject) { }

	public abstract ECustomizationItemCategory get_Category() { }

	public string get_DescriptionLocalizationKey() { }

	public string get_NameLocalizationKey() { }

	public virtual int GetHashCode() { }

	public bool IsAllSidesCustomizationAllowed(string profileVersion) { }

}

