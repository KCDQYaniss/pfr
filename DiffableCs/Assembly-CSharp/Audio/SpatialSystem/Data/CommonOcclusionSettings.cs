namespace Audio.SpatialSystem.Data;

public class CommonOcclusionSettings
{
	[Tooltip("Layer mask used for occlusion raycasts")]
	public LayerMask occlusionLayerMask; //Field offset: 0x10
	[Tooltip("How much position change triggers a recalculation start")]
	public QualityFloatValue[] positionChangeThreshold; //Field offset: 0x18
	[Tooltip("How fast the effect value adapts to changes. Higher value = faster.")]
	public float smoothingFactor; //Field offset: 0x20
	[Tooltip("Minimum change in occlusion effect to trigger per-source recalculation")]
	public float effectChangeThreshold; //Field offset: 0x24
	[Tooltip("Maximum distance at which occlusion is calculated")]
	public float maxDistance; //Field offset: 0x28
	public float floorHeight; //Field offset: 0x2C
	public float playerObstructionYOffset; //Field offset: 0x30
	[Range(0, 1)]
	[Tooltip("Threshold above which transmission score triggers reflection stage (0 to 1)")]
	public float transmissionThreshold; //Field offset: 0x34
	[Range(0, 1)]
	[Tooltip("Threshold above which diffraction score triggers reflection stage (0 to 1)")]
	public float diffractionThreshold; //Field offset: 0x38
	private Dictionary _positionChangeThresholdMap; //Field offset: 0x40

	public CommonOcclusionSettings() { }

	public void Apply(CommonOcclusionSettings newSettings) { }

	public float GetPositionThresholdByQuality() { }

}

