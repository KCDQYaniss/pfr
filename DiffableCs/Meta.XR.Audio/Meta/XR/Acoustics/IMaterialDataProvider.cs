namespace Meta.XR.Acoustics;

internal interface IMaterialDataProvider
{

	public MaterialData Data
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public MaterialData get_Data() { }

	public string get_name() { }

}

