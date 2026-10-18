namespace EFT.Customization;

public sealed class CustomizationHideoutMannequinPose : BaseCustomizationItem
{
	[JsonProperty("MannequinPoseName")]
	public string PoseName; //Field offset: 0x58

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public CustomizationHideoutMannequinPose() { }

	public virtual ECustomizationItemCategory get_Category() { }

}

