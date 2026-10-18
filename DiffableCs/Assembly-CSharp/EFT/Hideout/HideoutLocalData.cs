namespace EFT.Hideout;

public sealed class HideoutLocalData
{
	private const string HIDEOUT_AMBIANCE_PREFIX = "HIDEOUT_AMBIANCE_OBJECT_STATUS"; //Field offset: 0x0

	public static ELightingLevel GlobalLightingLevel
	{
		 get { } //Length: 170
		 set { } //Length: 101
	}

	public static bool InfoIconsStatus
	{
		 get { } //Length: 161
		 set { } //Length: 103
	}

	public HideoutLocalData() { }

	public static ELightingLevel get_GlobalLightingLevel() { }

	public static bool get_InfoIconsStatus() { }

	private static string GetObjectId(Appliance appliance) { }

	public static bool GetStatus(Appliance appliance, bool defaultValue) { }

	public static void SaveGlobalEvents(EEventType[] events) { }

	public static void SaveStatus(Appliance appliance) { }

	public static void set_GlobalLightingLevel(ELightingLevel value) { }

	public static void set_InfoIconsStatus(bool value) { }

}

