namespace EFT.VolumePropagation.Rendering;

public static class VolumeRenderPresetRegistry
{
	private static readonly Dictionary _cache; //Field offset: 0x0
	private static VolumeRenderConfig _config; //Field offset: 0x8
	private static bool _loadAttempted; //Field offset: 0x10

	private static VolumeRenderPresetRegistry() { }

	private static VolumeRenderConfig LoadConfig() { }

	public static IVolumeRenderSettings Resolve(byte presetId) { }

}

