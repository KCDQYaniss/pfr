namespace EFT;

public sealed class ArtilleryProjectileExplosionParams
{
	public Vector3 Blindness; //Field offset: 0x10
	public Vector3 Contusion; //Field offset: 0x1C
	public Vector3 ArmorDistanceDistanceDamage; //Field offset: 0x28
	public float DeadlyDistance; //Field offset: 0x34
	public float MinExplosionDistance; //Field offset: 0x38
	public float MaxExplosionDistance; //Field offset: 0x3C
	public int FragmentsCount; //Field offset: 0x40
	public float Strength; //Field offset: 0x44
	public string FragmentType; //Field offset: 0x48
	public float ArmorDamage; //Field offset: 0x50
	public float StaminaBurnRate; //Field offset: 0x54
	public float PenetrationPower; //Field offset: 0x58
	public float DirectionalDamageAngle; //Field offset: 0x5C
	public float DirectionalDamageMultiplier; //Field offset: 0x60
	public float MaxShakeEffectDistance; //Field offset: 0x64
	public float ShakeEffectExponentValue; //Field offset: 0x68
	public float CameraPositionShakeStrength; //Field offset: 0x6C
	public float CameraRotationShakeStrength; //Field offset: 0x70
	public float ShakeTime; //Field offset: 0x74

	public ArtilleryProjectileExplosionParams() { }

}

