namespace EFT.Settings.Graphics;

public struct QualityLevelPreset
{
	private static bool _singleShadowCascades; //Field offset: 0x0
	private static readonly QualityLevelPreset _low; //Field offset: 0x4
	private static readonly QualityLevelPreset _medium; //Field offset: 0x4C
	private static readonly QualityLevelPreset _high; //Field offset: 0x94
	private static readonly QualityLevelPreset _ultra; //Field offset: 0xDC
	private int _pixelLightCount; //Field offset: 0x0
	private int _antiAliasing; //Field offset: 0x4
	private bool _softParticles; //Field offset: 0x8
	private bool _realtimeReflectionProbes; //Field offset: 0x9
	private bool _billboardsFaceCameraPosition; //Field offset: 0xA
	private float _resolutionScalingFixedDpiFactor; //Field offset: 0xC
	private ShadowmaskMode _shadowMaskMode; //Field offset: 0x10
	private ShadowQuality _shadows; //Field offset: 0x14
	private ShadowResolution _shadowResolution; //Field offset: 0x18
	private ShadowProjection _shadowProjection; //Field offset: 0x1C
	private float _shadowNearPlaneOffset; //Field offset: 0x20
	private int _shadowCascades; //Field offset: 0x24
	private float _shadowCascade2Split; //Field offset: 0x28
	private Vector3 _shadowCascade4Split; //Field offset: 0x2C
	private SkinWeights _skinWeights; //Field offset: 0x38
	private int _maximumLodLevel; //Field offset: 0x3C
	private int _particleRaycastBudget; //Field offset: 0x40
	private bool _asyncUploadPersistentBuffer; //Field offset: 0x44

	private static QualityLevelPreset() { }

	public void Apply() { }

	private void ApplyShadowShaderKeywords() { }

	public static QualityLevelPreset GetPreset(int quality) { }

}

