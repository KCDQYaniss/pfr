namespace Koenigz.PerfectCulling;

public static class PerfectCullingConstants
{
	public const int MaxRenderers = 65535; //Field offset: 0x0
	public const int SampleBatchCount = 2048; //Field offset: 0x0
	public const int CamBakeLayer = 30; //Field offset: 0x0
	public const bool SafetyChecks = True; //Field offset: 0x0
	public static readonly HashSet SupportedRendererTypes; //Field offset: 0x0
	public static Color ClearColor; //Field offset: 0x8
	public static bool AllowSceneReload; //Field offset: 0x18
	public static bool EFTSceneBakeMode; //Field offset: 0x19
	public static readonly string MultiSceneTempPath; //Field offset: 0x20
	public static readonly string ResourcesFolder; //Field offset: 0x28

	private static PerfectCullingConstants() { }

}

