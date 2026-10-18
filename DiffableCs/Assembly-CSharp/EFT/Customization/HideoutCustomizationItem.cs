namespace EFT.Customization;

public sealed class HideoutCustomizationItem : BaseCustomizationItem
{
	[JsonProperty("AssetPath")]
	public ResourceKey Prefab; //Field offset: 0x58
	[JsonProperty("hideGarbage")]
	public bool HideGarbage; //Field offset: 0x60

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public HideoutCustomizationItem() { }

	public virtual ECustomizationItemCategory get_Category() { }

}

