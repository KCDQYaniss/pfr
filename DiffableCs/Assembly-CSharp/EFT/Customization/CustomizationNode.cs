namespace EFT.Customization;

public sealed class CustomizationNode : BaseCustomizationItem
{

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 3
	}

	public CustomizationNode() { }

	public virtual ECustomizationItemCategory get_Category() { }

}

