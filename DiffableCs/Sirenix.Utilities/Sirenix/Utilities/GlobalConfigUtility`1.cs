namespace Sirenix.Utilities;

public static class GlobalConfigUtility`1
{
	private static T instance; //Field offset: 0x0

	public static bool HasInstanceLoaded
	{
		 get { } //Length: 258
	}

	public static bool get_HasInstanceLoaded() { }

	public static T GetInstance(string defaultAssetFolderPath, string defaultFileNameWithoutExtension = null) { }

	internal static void LoadInstanceIfAssetExists(string assetPath, string defaultFileNameWithoutExtension = null) { }

}

