namespace EFT.Customization;

public sealed class CustomizationDogTag : BaseCustomizationItem
{
	public string[] ProfileVersions; //Field offset: 0x58
	public Nullable BearTemplateId; //Field offset: 0x60
	public Nullable UsecTemplateId; //Field offset: 0x80
	private Item _item; //Field offset: 0xA0

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public Item ItemBear
	{
		 get { } //Length: 569
	}

	public Item ItemUsec
	{
		 get { } //Length: 585
	}

	public CustomizationDogTag() { }

	public virtual ECustomizationItemCategory get_Category() { }

	public Item get_ItemBear() { }

	public Item get_ItemUsec() { }

	public Item GetItemClone(EPlayerSide side) { }

}

