//Type is in global namespace

public class TODSkyProvider
{
	public static ITODSky Instance; //Field offset: 0x0

	public static bool IsAvailable
	{
		 get { } //Length: 93
	}

	public TODSkyProvider() { }

	public static bool get_IsAvailable() { }

	public static void RegisterInstance(ITODSky instance) { }

	public static void TryForceInitialize() { }

}

