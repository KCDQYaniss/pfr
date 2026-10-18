namespace Audio.SpatialSystem.Data;

public class PropagationSettings
{
	[Tooltip("percentage total routes count by quality")]
	public QualityFloatValue[] routesCompressionFactorByQuality; //Field offset: 0x10
	[Tooltip("Weight of distance factor in propagation-based occlusion calculation")]
	public float distanceWeight; //Field offset: 0x18
	[Tooltip("Exponent applied to diffraction factor in propagation calculation")]
	public float diffractionExponent; //Field offset: 0x1C
	[Tooltip("Exponent applied to height influence (normalized)")]
	public float heightExponent; //Field offset: 0x20
	[Tooltip("Weight of ascending segment height cost")]
	public float segmentHeightWeightUp; //Field offset: 0x24
	[Tooltip("Weight of descending segment height cost")]
	public float segmentHeightWeightDown; //Field offset: 0x28
	[Tooltip("Min cost percentage when source or listener close to portal")]
	public float minPortalCostPercent; //Field offset: 0x2C
	[Obsolete]
	[Tooltip("Number of portal-to-portal relaxation iterations")]
	public int relaxationIterations; //Field offset: 0x30
	[Tooltip("Weight of absolute vertical displacement in propagation calculation")]
	public float absoluteHeightWeight; //Field offset: 0x34
	[Tooltip("Typical room height (in meters) for normalization of vertical displacement")]
	public float typicalRoomHeight; //Field offset: 0x38
	[Tooltip("Max path segment length (in meters) for normalization of magnitude scaling")]
	public float maxSegmentLength; //Field offset: 0x3C
	private Dictionary _routesCompressionFactorByQualityMap; //Field offset: 0x40

	public PropagationSettings() { }

	public void Apply(PropagationSettings newSettings) { }

	public float GetCompressionFactorByQuality() { }

}

