namespace EFT.Builds;

public interface IBuild
{

	public EEquipmentBuildType BuildType
	{
		 get { } //Length: 0
	}

	public MongoID Id
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public EEquipmentBuildType get_BuildType() { }

	public MongoID get_Id() { }

	public string get_Name() { }

}

