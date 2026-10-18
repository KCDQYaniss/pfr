namespace Audio.SpatialSystem.Data;

public class DiffractionSettings
{
	[Tooltip("Number of rays used to search for an edge candidate from each side (source/listener hit point)")]
	public QualityIntValue[] edgeSearchRayCount; //Field offset: 0x10
	[Tooltip("Maximum distance from edge to consider for diffraction")]
	public float maxEdgeDist; //Field offset: 0x18
	[Tooltip("Maximum allowed path length multiplier for diffracted rays")]
	public float maxPathFactor; //Field offset: 0x1C
	[Tooltip("Length of the rays used to search for edge candidates")]
	public float edgeSearchRayLength; //Field offset: 0x20
	[Tooltip("Offset from the candidate edge point when checking visibility from source/listener")]
	public float edgeValidationRayOffset; //Field offset: 0x24
	private Dictionary _edgeSearchRayCount; //Field offset: 0x28

	public DiffractionSettings() { }

	public void Apply(DiffractionSettings newSettings) { }

	public int GetRaysCountByQuality() { }

}

