namespace Koenigz.PerfectCulling;

[CreateAssetMenu(menuName = "Perfect Culling/PerfectCullingSettings")]
public class PerfectCullingSettings : ScriptableObject
{
	[Range(16, 2048)]
	[Tooltip("Resolution for the actual rendering of a single camera perspective (1 out of 6). Increase this if you are experiencing distant object popping. Decrease this if you are memory constrained on your baking system.")]
	public int bakeCameraResolution; //Field offset: 0x18
	public bool debugBakeMode; //Field offset: 0x1C
	public bool outputPixelData; //Field offset: 0x1D
	public bool supportOldDataFormat; //Field offset: 0x1E
	public Material proxyTransparentMaterial; //Field offset: 0x20
	public Material sharedOccluderMaterial; //Field offset: 0x28
	public float minCullingOccluderSize; //Field offset: 0x30
	public int numActivationsPerVolume; //Field offset: 0x34
	public bool saveRawBakeData; //Field offset: 0x38

	public int bakeCameraResolutionHeight
	{
		 get { } //Length: 4
	}

	public int bakeCameraResolutionWidth
	{
		 get { } //Length: 4
	}

	public static PerfectCullingSettings Instance
	{
		 get { } //Length: 30
	}

	public PerfectCullingSettings() { }

	public int get_bakeCameraResolutionHeight() { }

	public int get_bakeCameraResolutionWidth() { }

	public static PerfectCullingSettings get_Instance() { }

}

