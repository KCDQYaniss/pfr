namespace JsonType;

public sealed class KolotunGlobalSettings
{
	public bool active; //Field offset: 0x10
	public bool enableDamage; //Field offset: 0x11
	public float initialFrozenDelaySec; //Field offset: 0x14
	public float applyFrozenEverySec; //Field offset: 0x18
	public float fireDistanceToHeat; //Field offset: 0x1C
	public int drunkImmunitySec; //Field offset: 0x20
	public float damageIntervalSec; //Field offset: 0x24
	public float damagePerTickMin; //Field offset: 0x28
	public float damagePerTickMax; //Field offset: 0x2C
	public string[] protectiveClothes; //Field offset: 0x30
	public string buffStage1; //Field offset: 0x38
	public string buffStage2; //Field offset: 0x40
	public int eventStage; //Field offset: 0x48
	public EBodyPart[] damageBodyParts; //Field offset: 0x50
	public float minHealthAfterDamage; //Field offset: 0x58
	public int soundTicksPerPlay; //Field offset: 0x5C

	public int ApplyFrozenEveryMS
	{
		 get { } //Length: 18
	}

	public int DamageIntervalMS
	{
		 get { } //Length: 18
	}

	public float FireDistanceToHeatSqr
	{
		 get { } //Length: 10
	}

	public KolotunGlobalSettings() { }

	public int get_ApplyFrozenEveryMS() { }

	public int get_DamageIntervalMS() { }

	public float get_FireDistanceToHeatSqr() { }

}

