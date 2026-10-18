namespace EFT.Customization;

public class CustomizationSuite : BaseCustomizationItem
{
	protected MongoID[] _clothings; //Field offset: 0x58
	[CompilerGenerated]
	private readonly MongoID <MainBodyPartItem>k__BackingField; //Field offset: 0x60

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	[CanBeNull]
	public override MongoID[] Clothings
	{
		 get { } //Length: 3
	}

	public override EBodyModelPart MainBodyPart
	{
		 get { } //Length: 3
	}

	public override MongoID MainBodyPartItem
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public CustomizationSuite() { }

	public virtual ECustomizationItemCategory get_Category() { }

	public override MongoID[] get_Clothings() { }

	public override EBodyModelPart get_MainBodyPart() { }

	[CompilerGenerated]
	public override MongoID get_MainBodyPartItem() { }

	public override void SetClothingsToProfile(BodyCustomization customization) { }

}

