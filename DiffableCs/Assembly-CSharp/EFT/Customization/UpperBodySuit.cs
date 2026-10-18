namespace EFT.Customization;

public sealed class UpperBodySuit : CustomizationSuite
{
	public MongoID Body; //Field offset: 0x78
	public MongoID Hands; //Field offset: 0x90

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	[CanBeNull]
	public virtual MongoID[] Clothings
	{
		 get { } //Length: 413
	}

	public virtual EBodyModelPart MainBodyPart
	{
		 get { } //Length: 3
	}

	public virtual MongoID MainBodyPartItem
	{
		 get { } //Length: 24
	}

	public UpperBodySuit() { }

	public virtual ECustomizationItemCategory get_Category() { }

	public virtual MongoID[] get_Clothings() { }

	public virtual EBodyModelPart get_MainBodyPart() { }

	public virtual MongoID get_MainBodyPartItem() { }

	public virtual void SetClothingsToProfile(BodyCustomization customization) { }

}

