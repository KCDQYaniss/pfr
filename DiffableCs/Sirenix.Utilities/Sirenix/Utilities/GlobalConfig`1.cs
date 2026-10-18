namespace Sirenix.Utilities;

public abstract class GlobalConfig`1 : ScriptableObject, IGlobalConfigEvents
{
	private static GlobalConfigAttribute configAttribute; //Field offset: 0x0
	private static T instance; //Field offset: 0x0

	public static GlobalConfigAttribute ConfigAttribute
	{
		 get { } //Length: 1033
	}

	public static bool HasInstanceLoaded
	{
		 get { } //Length: 287
	}

	public static T Instance
	{
		 get { } //Length: 117
	}

	protected GlobalConfig`1() { }

	public static GlobalConfigAttribute get_ConfigAttribute() { }

	public static bool get_HasInstanceLoaded() { }

	public static T get_Instance() { }

	public static void LoadInstanceIfAssetExists() { }

	protected override void OnConfigAutoCreated() { }

	protected override void OnConfigInstanceFirstAccessed() { }

	public void OpenInEditor() { }

	private override void Sirenix.Utilities.IGlobalConfigEvents.OnConfigAutoCreated() { }

	private override void Sirenix.Utilities.IGlobalConfigEvents.OnConfigInstanceFirstAccessed() { }

}

