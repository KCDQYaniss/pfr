namespace EFT.Console.Commands;

public class DLSSCommands
{
	private static float _savedTAASpread; //Field offset: 0x0

	private static DLSSCommands() { }

	public DLSSCommands() { }

	[ConsoleCommand("dlssDebugDisable", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssDebugDisable() { }

	[ConsoleCommand("dlssDebugOutput", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssDebugOutput() { }

	[ConsoleCommand("dlssIsSupported", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssIsSupported() { }

	[ConsoleCommand("dlssNoJitter", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssNoJitter(int enable) { }

	[ConsoleCommand("dlssOpticDynamicResolution", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssOpticDynamicResolution(int dynamicResolution) { }

	[ConsoleCommand("dlssOpticFixedUpdate", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssOpticFixedUpdate(int fixedUpdate) { }

	[ConsoleCommand("dlssQuality", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssQuality(int quality) { }

	[ConsoleCommand("dlssToggle", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssToggle() { }

	[ConsoleCommand("useJitter", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void DlssUseJitter(int useJitter) { }

	private static SSAA[] GetSSAA() { }

	private static SSAAImpl[] GetSSAAImplControllers() { }

	[ConsoleCommand("resampling", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void Resampling(float ratio) { }

	[ConsoleCommand("upscaleViaFSR", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void UpscaleViaFSR(int preset) { }

	[ConsoleCommand("upscaleViaFSR2", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void UpscaleViaFSR2(int preset) { }

}

