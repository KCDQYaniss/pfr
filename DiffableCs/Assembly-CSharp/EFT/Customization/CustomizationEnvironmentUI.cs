namespace EFT.Customization;

public sealed class CustomizationEnvironmentUI : BaseCustomizationItem
{
	public EEnvironmentUIType EnvironmentUIType; //Field offset: 0x58

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public CustomizationEnvironmentUI() { }

	public virtual ECustomizationItemCategory get_Category() { }

}

