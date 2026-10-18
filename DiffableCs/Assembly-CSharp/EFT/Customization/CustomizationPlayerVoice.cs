namespace EFT.Customization;

public sealed class CustomizationPlayerVoice : BaseCustomizationItem
{
	public string Prefab; //Field offset: 0x58

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public CustomizationPlayerVoice() { }

	public virtual ECustomizationItemCategory get_Category() { }

}

