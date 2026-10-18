namespace EFT.InventoryLogic;

public class RocketTemplate : AmmoTemplate
{
	public float ComputableUnitSize; //Field offset: 0x288
	public ComputableUnitType ComputableUnitType; //Field offset: 0x28C
	public float ExplosionRadius; //Field offset: 0x290
	public float PropagationSpeed; //Field offset: 0x294
	public float ParticleDuration; //Field offset: 0x298
	public float ParticleSize; //Field offset: 0x29C
	public int ParticleCapacity; //Field offset: 0x2A0
	public Vector2 ComputableUnitDamage; //Field offset: 0x2A4
	public float BackblastDistance; //Field offset: 0x2AC
	public Vector2 BackblastDamage; //Field offset: 0x2B0
	public float BackBlastConeAngle; //Field offset: 0x2B8
	public float ArmingTime; //Field offset: 0x2BC
	public WeightMultipliers WeightMultipliers; //Field offset: 0x2C0

	public RocketTemplate() { }

}

