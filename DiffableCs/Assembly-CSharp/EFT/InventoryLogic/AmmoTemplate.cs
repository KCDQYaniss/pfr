namespace EFT.InventoryLogic;

public class AmmoTemplate : StackableItemTemplate, IExplosiveAmmoTemplate, IItemTemplate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__97_2; //Field offset: 0x8
		public static Func <>9__97_6; //Field offset: 0x10
		public static Func <>9__97_7; //Field offset: 0x18
		public static Func <>9__97_9; //Field offset: 0x20
		public static Func <>9__97_12; //Field offset: 0x28
		public static Func <>9__97_15; //Field offset: 0x30
		public static Func <>9__97_18; //Field offset: 0x38
		public static Func <>9__97_21; //Field offset: 0x40
		public static Func <>9__97_24; //Field offset: 0x48
		public static Func <>9__97_27; //Field offset: 0x50

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_12() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_15() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_18() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_2() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_21() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_24() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_27() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_6() { }

		internal float <GetCachedReadonlyQualities>b__97_7() { }

		internal EItemAttributeDisplayType <GetCachedReadonlyQualities>b__97_9() { }

	}

	private static float MaxMalfMisfireChance; //Field offset: 0x0
	private static float MaxMalfFeedChance; //Field offset: 0x4
	private static readonly string[] MalfChancesKeys; //Field offset: 0x8
	public string ammoType; //Field offset: 0x148
	public int Damage; //Field offset: 0x150
	public int ammoAccr; //Field offset: 0x154
	public int ammoRec; //Field offset: 0x158
	public int ammoDist; //Field offset: 0x15C
	public int buckshotBullets; //Field offset: 0x160
	public int PenetrationPower; //Field offset: 0x164
	public float PenetrationPowerDiviation; //Field offset: 0x168
	public int ammoHear; //Field offset: 0x16C
	public string ammoSfx; //Field offset: 0x170
	public float MisfireChance; //Field offset: 0x178
	public int MinFragmentsCount; //Field offset: 0x17C
	public int MaxFragmentsCount; //Field offset: 0x180
	public int ammoShiftChance; //Field offset: 0x184
	public string casingName; //Field offset: 0x188
	public float casingEjectPower; //Field offset: 0x190
	public float casingMass; //Field offset: 0x194
	public string casingSounds; //Field offset: 0x198
	public int ProjectileCount; //Field offset: 0x1A0
	public float InitialSpeed; //Field offset: 0x1A4
	public float PenetrationDamageMod; //Field offset: 0x1A8
	public float PenetrationChanceObstacle; //Field offset: 0x1AC
	public float RicochetChance; //Field offset: 0x1B0
	public float FragmentationChance; //Field offset: 0x1B4
	public float BallisticCoeficient; //Field offset: 0x1B8
	public bool Tracer; //Field offset: 0x1BC
	public TaxonomyColor TracerColor; //Field offset: 0x1C0
	public float TracerDistance; //Field offset: 0x1C4
	public int ArmorDamage; //Field offset: 0x1C8
	public string Caliber; //Field offset: 0x1D0
	public float StaminaBurnPerDamage; //Field offset: 0x1D8
	public bool HasGrenaderComponent; //Field offset: 0x1DC
	public float FuzeArmTimeSec; //Field offset: 0x1E0
	public float MinExplosionDistance; //Field offset: 0x1E4
	public float MaxExplosionDistance; //Field offset: 0x1E8
	public int FragmentsCount; //Field offset: 0x1EC
	public string FragmentType; //Field offset: 0x1F0
	public string ExplosionType; //Field offset: 0x1F8
	public bool ShowHitEffectOnExplode; //Field offset: 0x200
	public float ExplosionStrength; //Field offset: 0x204
	public bool ShowBullet; //Field offset: 0x208
	public float AmmoLifeTimeSec; //Field offset: 0x20C
	public float MalfMisfireChance; //Field offset: 0x210
	public float MalfFeedChance; //Field offset: 0x214
	public Vector3 ArmorDistanceDistanceDamage; //Field offset: 0x218
	public Vector3 Contusion; //Field offset: 0x224
	public Vector3 Blindness; //Field offset: 0x230
	public float LightBleedingDelta; //Field offset: 0x23C
	public float HeavyBleedingDelta; //Field offset: 0x240
	public bool IsLightAndSoundShot; //Field offset: 0x244
	public float LightAndSoundShotAngle; //Field offset: 0x248
	public float LightAndSoundShotSelfContusionTime; //Field offset: 0x24C
	public float LightAndSoundShotSelfContusionStrength; //Field offset: 0x250
	public float DurabilityBurnModificator; //Field offset: 0x254
	public float HeatFactor; //Field offset: 0x258
	public float BulletMassGram; //Field offset: 0x25C
	public float BulletDiameterMilimeters; //Field offset: 0x260
	public bool RemoveShellAfterFire; //Field offset: 0x264
	public string airDropTemplateId; //Field offset: 0x268
	public FlareEventType[] FlareTypes; //Field offset: 0x270
	private List _cachedQualities; //Field offset: 0x278
	private Nullable _cachedSonicType; //Field offset: 0x280

	public string AirDropTemplateId
	{
		 get { } //Length: 8
	}

	public float AmmoFactor
	{
		 get { } //Length: 135
	}

	public float ArmorDamagePortion
	{
		 get { } //Length: 20
	}

	private override Vector3 EFT.InventoryLogic.IExplosiveAmmoTemplate.ArmorDistanceDistanceDamage
	{
		private get { } //Length: 25
	}

	private override Vector3 EFT.InventoryLogic.IExplosiveAmmoTemplate.Blindness
	{
		private get { } //Length: 25
	}

	private override Vector3 EFT.InventoryLogic.IExplosiveAmmoTemplate.Contusion
	{
		private get { } //Length: 25
	}

	private override float EFT.InventoryLogic.IExplosiveAmmoTemplate.ExplosionStrength
	{
		private get { } //Length: 9
	}

	private override string EFT.InventoryLogic.IExplosiveAmmoTemplate.ExplosionType
	{
		private get { } //Length: 8
	}

	private override int EFT.InventoryLogic.IExplosiveAmmoTemplate.FragmentsCount
	{
		private get { } //Length: 7
	}

	private override string EFT.InventoryLogic.IExplosiveAmmoTemplate.FragmentType
	{
		private get { } //Length: 8
	}

	private override float EFT.InventoryLogic.IExplosiveAmmoTemplate.FuzeArmTimeSec
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IExplosiveAmmoTemplate.MaxExplosionDistance
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IExplosiveAmmoTemplate.MinExplosionDistance
	{
		private get { } //Length: 9
	}

	private override bool EFT.InventoryLogic.IExplosiveAmmoTemplate.ShowHitEffectOnExplode
	{
		private get { } //Length: 8
	}

	public override bool GrenadeComponentIsDummy
	{
		 get { } //Length: 40
	}

	private static AmmoTemplate() { }

	public AmmoTemplate() { }

	[CompilerGenerated]
	private float <GetCachedReadonlyQualities>b__97_0() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_1() { }

	[CompilerGenerated]
	private float <GetCachedReadonlyQualities>b__97_10() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_11() { }

	[CompilerGenerated]
	private float <GetCachedReadonlyQualities>b__97_13() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_14() { }

	[CompilerGenerated]
	private float <GetCachedReadonlyQualities>b__97_16() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_17() { }

	[CompilerGenerated]
	private float <GetCachedReadonlyQualities>b__97_19() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_20() { }

	[CompilerGenerated]
	private float <GetCachedReadonlyQualities>b__97_22() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_23() { }

	[CompilerGenerated]
	private float <GetCachedReadonlyQualities>b__97_25() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_26() { }

	[CompilerGenerated]
	private float <GetCachedReadonlyQualities>b__97_3() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_4() { }

	[CompilerGenerated]
	private MultiLineInfo <GetCachedReadonlyQualities>b__97_5() { }

	[CompilerGenerated]
	private string <GetCachedReadonlyQualities>b__97_8() { }

	public bool ContainsType(FlareEventType flareEventType) { }

	protected virtual List CreateReadonlyComponentsCollection() { }

	private override Vector3 EFT.InventoryLogic.IExplosiveAmmoTemplate.get_ArmorDistanceDistanceDamage() { }

	private override Vector3 EFT.InventoryLogic.IExplosiveAmmoTemplate.get_Blindness() { }

	private override Vector3 EFT.InventoryLogic.IExplosiveAmmoTemplate.get_Contusion() { }

	private override float EFT.InventoryLogic.IExplosiveAmmoTemplate.get_ExplosionStrength() { }

	private override string EFT.InventoryLogic.IExplosiveAmmoTemplate.get_ExplosionType() { }

	private override int EFT.InventoryLogic.IExplosiveAmmoTemplate.get_FragmentsCount() { }

	private override string EFT.InventoryLogic.IExplosiveAmmoTemplate.get_FragmentType() { }

	private override float EFT.InventoryLogic.IExplosiveAmmoTemplate.get_FuzeArmTimeSec() { }

	private override float EFT.InventoryLogic.IExplosiveAmmoTemplate.get_MaxExplosionDistance() { }

	private override float EFT.InventoryLogic.IExplosiveAmmoTemplate.get_MinExplosionDistance() { }

	private override bool EFT.InventoryLogic.IExplosiveAmmoTemplate.get_ShowHitEffectOnExplode() { }

	public string get_AirDropTemplateId() { }

	public float get_AmmoFactor() { }

	public float get_ArmorDamagePortion() { }

	public override bool get_GrenadeComponentIsDummy() { }

	public List GetCachedReadonlyQualities() { }

	public SonicType GetCachedSonicType() { }

	public virtual void OnInit() { }

	public void SafelyAddQualityToList(ItemAttribute itemAttribute) { }

}

