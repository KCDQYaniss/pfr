//Type is in global namespace

public class AIDebugSettings : ScriptableObject
{
	private static AIDebugSettings _instance; //Field offset: 0x0
	public bool CoverPointDrawEnable; //Field offset: 0x18
	public Texture2D BearingPointIcon; //Field offset: 0x20
	public Texture2D SelectedBearingPointIcon; //Field offset: 0x28

	public static AIDebugSettings Instance
	{
		 get { } //Length: 395
	}

	public AIDebugSettings() { }

	public static AIDebugSettings get_Instance() { }

}

