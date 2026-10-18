namespace EFT.Customization;

public sealed class CustomizationHead : CustomizationClothing
{

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public CustomizationHead() { }

	public virtual ECustomizationItemCategory get_Category() { }

}

