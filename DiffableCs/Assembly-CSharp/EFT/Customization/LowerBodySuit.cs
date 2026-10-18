namespace EFT.Customization;

public sealed class LowerBodySuit : CustomizationSuite
{
	public MongoID Feet; //Field offset: 0x78
	public bool DisableForMannequin; //Field offset: 0x90

	[CanBeNull]
	public virtual MongoID[] Clothings
	{
		 get { } //Length: 301
	}

	public virtual EBodyModelPart MainBodyPart
	{
		 get { } //Length: 6
	}

	public virtual MongoID MainBodyPartItem
	{
		 get { } //Length: 24
	}

	public LowerBodySuit() { }

	public virtual MongoID[] get_Clothings() { }

	public virtual EBodyModelPart get_MainBodyPart() { }

	public virtual MongoID get_MainBodyPartItem() { }

	public virtual void SetClothingsToProfile(BodyCustomization customization) { }

}

