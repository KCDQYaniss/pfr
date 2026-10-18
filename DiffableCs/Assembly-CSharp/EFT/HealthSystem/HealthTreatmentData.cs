namespace EFT.HealthSystem;

public sealed class HealthTreatmentData
{
	public readonly Dictionary BodyParts; //Field offset: 0x10
	public float Energy; //Field offset: 0x18
	public float Hydration; //Field offset: 0x1C

	public HealthTreatmentData() { }

}

