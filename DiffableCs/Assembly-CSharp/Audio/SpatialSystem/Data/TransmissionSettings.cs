namespace Audio.SpatialSystem.Data;

public class TransmissionSettings
{
	[Tooltip("Number of additional rays used to check transmission around the center ray")]
	public QualityIntValue[] initialRaysCount; //Field offset: 0x10
	[Tooltip("Energy loss factor per unit of thickness for transmission")]
	public float absorptionPerUnit; //Field offset: 0x18
	[Tooltip("Radius of the circle on which widening transmission rays are cast")]
	public float raysWideningRadius; //Field offset: 0x1C
	[Tooltip("Vertical offset for second sampling level above listener and source")]
	public float listenerHeightSamplingOffset; //Field offset: 0x20
	[Tooltip("Vertical offset for second sampling level above listener and source")]
	public float sourceHeightSamplingOffset; //Field offset: 0x24
	[Tooltip("Minimum thickness of an obstacle to start absorbing transmitted sound energy")]
	public float obstacleMinThickness; //Field offset: 0x28
	[Tooltip("Maximum thickness of an obstacle before it's considered fully blocking transmission")]
	public float obstacleMaxThickness; //Field offset: 0x2C
	[Tooltip("Minimum energy threshold for transmitted sound")]
	public float minEnergyThreshold; //Field offset: 0x30
	[Tooltip("Use Raycast instead of Spherecast for transmission")]
	public bool useRaycast; //Field offset: 0x34
	public float minClearPathScore; //Field offset: 0x38
	private Dictionary _initialRaysCountMap; //Field offset: 0x40

	public TransmissionSettings() { }

	public void Apply(TransmissionSettings newSettings) { }

	public int GetRaysCountByQuality() { }

}

