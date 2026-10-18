namespace EFT.Customization;

public class CustomizationItem : BaseCustomizationItem
{

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public CustomizationItem() { }

	public virtual ECustomizationItemCategory get_Category() { }

}

