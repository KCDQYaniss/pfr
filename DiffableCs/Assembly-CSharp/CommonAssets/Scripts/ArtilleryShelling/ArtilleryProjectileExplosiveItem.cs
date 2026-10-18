namespace CommonAssets.Scripts.ArtilleryShelling;

public class ArtilleryProjectileExplosiveItem : IExplosiveItem
{
	private static string ARTILLERY_FRAGMENT_TEMPLATE_ID; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <IsDummy>k__BackingField; //Field offset: 0x10
	private Vector3 _blindness; //Field offset: 0x14
	private Vector3 _contusion; //Field offset: 0x20
	private Vector3 _armorDistanceDistanceDamage; //Field offset: 0x2C
	private float _deadlyDistance; //Field offset: 0x38
	private float _minExplosionDistance; //Field offset: 0x3C
	private float _maxExplosionDistance; //Field offset: 0x40
	private int _fragmentsCount; //Field offset: 0x44
	private float _strength; //Field offset: 0x48
	private string _tag; //Field offset: 0x50
	private float _armorDamage; //Field offset: 0x58
	private float _staminaBurnRate; //Field offset: 0x5C
	private float _penetrationPower; //Field offset: 0x60
	private string _fragmentType; //Field offset: 0x68
	private string _fxName; //Field offset: 0x70
	private WildSpawnType _ignoreRole; //Field offset: 0x78
	private float _directionalDamageAngle; //Field offset: 0x7C
	private float _directionalDamageMultiplier; //Field offset: 0x80
	private float _maxShakeEffectDistance; //Field offset: 0x84
	private float _shakeEffectExponentValue; //Field offset: 0x88
	private CustomExplosionShakeSettings _customExplosionShakeSettings; //Field offset: 0x90

	public float ArmorDamage
	{
		 get { } //Length: 6
	}

	public override Vector3 ArmorDistanceDistanceDamage
	{
		 get { } //Length: 19
	}

	public override Vector3 Blindness
	{
		 get { } //Length: 19
	}

	public override Vector3 Contusion
	{
		 get { } //Length: 19
	}

	public CustomExplosionShakeSettings CustomExplosionShakeSettings
	{
		 get { } //Length: 8
	}

	public float DeadlyDistance
	{
		 get { } //Length: 6
	}

	public override int FragmentsCount
	{
		 get { } //Length: 4
	}

	public string FragmentType
	{
		 get { } //Length: 5
	}

	public float GetDirectionalDamageAngle
	{
		 get { } //Length: 6
	}

	public float GetDirectionalDamageMultiplier
	{
		 get { } //Length: 9
	}

	public override float GetStrength
	{
		 get { } //Length: 6
	}

	public override bool IsDummy
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override float MaxExplosionDistance
	{
		 get { } //Length: 6
	}

	public float MaxShakeEffectDistance
	{
		 get { } //Length: 9
	}

	public override float MinExplosionDistance
	{
		 get { } //Length: 6
	}

	public float PenetrationPower
	{
		 get { } //Length: 6
	}

	public float ShakeEffectExponentValue
	{
		 get { } //Length: 9
	}

	public float StaminaBurnRate
	{
		 get { } //Length: 6
	}

	private static ArtilleryProjectileExplosiveItem() { }

	public ArtilleryProjectileExplosiveItem() { }

	public override Ammo CreateFragment() { }

	public float get_ArmorDamage() { }

	public override Vector3 get_ArmorDistanceDistanceDamage() { }

	public override Vector3 get_Blindness() { }

	public override Vector3 get_Contusion() { }

	public CustomExplosionShakeSettings get_CustomExplosionShakeSettings() { }

	public float get_DeadlyDistance() { }

	public override int get_FragmentsCount() { }

	public string get_FragmentType() { }

	public float get_GetDirectionalDamageAngle() { }

	public float get_GetDirectionalDamageMultiplier() { }

	public override float get_GetStrength() { }

	[CompilerGenerated]
	public override bool get_IsDummy() { }

	public override float get_MaxExplosionDistance() { }

	public float get_MaxShakeEffectDistance() { }

	public override float get_MinExplosionDistance() { }

	public float get_PenetrationPower() { }

	public float get_ShakeEffectExponentValue() { }

	public float get_StaminaBurnRate() { }

	public void SetExplosiveItemParams(ArtilleryProjectileExplosionParams explosiveParams) { }

}

