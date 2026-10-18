namespace EFT.Customization;

public sealed class CustomizationGesture : BaseCustomizationItem
{
	public EInteraction Interaction; //Field offset: 0x58

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public CustomizationGesture() { }

	public virtual ECustomizationItemCategory get_Category() { }

}

