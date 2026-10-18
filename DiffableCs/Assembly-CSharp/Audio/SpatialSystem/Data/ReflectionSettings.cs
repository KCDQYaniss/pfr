namespace Audio.SpatialSystem.Data;

public class ReflectionSettings
{
	[Tooltip("Number of initial rays cast for reflection sampling")]
	public QualityIntValue[] initialRaysCount; //Field offset: 0x10
	[Tooltip("Maximum number of reflections per ray")]
	public int maxReflections; //Field offset: 0x18
	[Tooltip("Energy loss factor applied per reflection")]
	public float energyLossFactorPerReflection; //Field offset: 0x1C
	[Tooltip("Minimum energy at maximum distance for reflections")]
	public float minEnergyAtMaxDistance; //Field offset: 0x20
	private Dictionary _initialRaysCountMap; //Field offset: 0x28

	public ReflectionSettings() { }

	public void Apply(ReflectionSettings newSettings) { }

	public int GetRaysCountByQuality() { }

}

