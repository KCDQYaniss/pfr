namespace EFT.HealthSystem;

[Extension]
public static class DamageHelper
{
	public static EHealthFactorType[] HealthFactors; //Field offset: 0x0
	public static readonly DamageInfo UndefinedDamage; //Field offset: 0x8
	public static readonly DamageInfo FallDamage; //Field offset: 0xE8
	public static readonly DamageInfo PoisonDamage; //Field offset: 0x1C8
	public static readonly DamageInfo LethalPoisonDamage; //Field offset: 0x2A8
	public static readonly DamageInfo LightBleedingDamage; //Field offset: 0x388
	public static readonly DamageInfo HeavyBleedingDamage; //Field offset: 0x468
	public static readonly DamageInfo DehydrationDamage; //Field offset: 0x548
	public static readonly DamageInfo ExhaustionDamage; //Field offset: 0x628
	public static readonly DamageInfo RadiationDamage; //Field offset: 0x708
	public static readonly DamageInfo TearGasDamage; //Field offset: 0x7E8
	public static readonly DamageInfo MedKitUse; //Field offset: 0x8C8
	public static readonly DamageInfo Existence; //Field offset: 0x9A8
	public static readonly DamageInfo StimulatorUse; //Field offset: 0xA88
	private static readonly EDamageType Bleeding; //Field offset: 0xB68
	private static readonly EDamageType SelfInflictedDamage; //Field offset: 0xB6C
	private static readonly EDamageType WeaponDamage; //Field offset: 0xB70
	private static readonly EDamageType EnemiesDamage; //Field offset: 0xB74
	private static readonly EDamageType EnvironmentalDamage; //Field offset: 0xB78

	private static DamageHelper() { }

	[Extension]
	public static bool IsBleeding(EDamageType damageType) { }

	[Extension]
	public static bool IsEnemyDamage(EDamageType damageType) { }

	[Extension]
	public static bool IsEnvironmental(EDamageType damageType) { }

	[Extension]
	public static bool IsSelfInflicted(EDamageType damageType) { }

	[Extension]
	public static bool IsWeaponInduced(EDamageType damageType) { }

}

