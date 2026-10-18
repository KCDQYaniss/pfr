namespace EFT.InventoryLogic;

public class Ammo : StackableItem
{
	public float buckshotDispersion; //Field offset: 0x78
	public SonicType SonicType; //Field offset: 0x7C
	[DefaultValue(False)]
	[Diffable]
	public bool IsUsed; //Field offset: 0x80

	public int ammoAccr
	{
		 get { } //Length: 79
	}

	public int ammoDist
	{
		 get { } //Length: 79
	}

	public float AmmoFactor
	{
		 get { } //Length: 82
	}

	public int ammoHear
	{
		 get { } //Length: 79
	}

	public float AmmoLifeTimeSec
	{
		 get { } //Length: 81
	}

	public int ammoRec
	{
		 get { } //Length: 79
	}

	public string ammoSfx
	{
		 get { } //Length: 80
	}

	public int ammoShiftChance
	{
		 get { } //Length: 79
	}

	public AmmoTemplate AmmoTemplate
	{
		 get { } //Length: 140
	}

	public string ammoType
	{
		 get { } //Length: 80
	}

	public int ArmorDamage
	{
		 get { } //Length: 79
	}

	public float ArmorDamagePortion
	{
		 get { } //Length: 92
	}

	public float BallisticCoeficient
	{
		 get { } //Length: 81
	}

	public int buckshotBullets
	{
		 get { } //Length: 79
	}

	public float BulletDiameterMilimeters
	{
		 get { } //Length: 81
	}

	public float BulletMassGram
	{
		 get { } //Length: 81
	}

	public string Caliber
	{
		 get { } //Length: 150
	}

	public float casingEjectPower
	{
		 get { } //Length: 81
	}

	public float casingMass
	{
		 get { } //Length: 81
	}

	public string casingName
	{
		 get { } //Length: 80
	}

	public string casingSounds
	{
		 get { } //Length: 80
	}

	public int Damage
	{
		 get { } //Length: 79
	}

	public float DurabilityBurnModificator
	{
		 get { } //Length: 81
	}

	public float FragmentationChance
	{
		 get { } //Length: 81
	}

	public float GetBulletSpeed
	{
		 get { } //Length: 81
	}

	public float HeatFactor
	{
		 get { } //Length: 81
	}

	public float HeavyBleedingDelta
	{
		 get { } //Length: 81
	}

	public virtual bool ImportantForCheckSpawnedInSession
	{
		 get { } //Length: 3
	}

	public float InitialSpeed
	{
		 get { } //Length: 81
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		 get { } //Length: 70
	}

	public float LightBleedingDelta
	{
		 get { } //Length: 81
	}

	public float MalfFeedChance
	{
		 get { } //Length: 81
	}

	public float MalfMisfireChance
	{
		 get { } //Length: 81
	}

	public int MaxFragmentsCount
	{
		 get { } //Length: 79
	}

	public int MinFragmentsCount
	{
		 get { } //Length: 79
	}

	public float MisfireChance
	{
		 get { } //Length: 81
	}

	public float PenetrationChanceObstacle
	{
		 get { } //Length: 81
	}

	public float PenetrationDamageMod
	{
		 get { } //Length: 81
	}

	public int PenetrationPower
	{
		 get { } //Length: 79
	}

	public float PenetrationPowerDiviation
	{
		 get { } //Length: 81
	}

	public int ProjectileCount
	{
		 get { } //Length: 79
	}

	public float RicochetChance
	{
		 get { } //Length: 81
	}

	public bool ShowBullet
	{
		 get { } //Length: 80
	}

	public virtual bool SpawnedInSession
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public float StaminaBurnRate
	{
		 get { } //Length: 81
	}

	public bool Tracer
	{
		 get { } //Length: 80
	}

	public TaxonomyColor TracerColor
	{
		 get { } //Length: 79
	}

	public float TracerDistance
	{
		 get { } //Length: 81
	}

	public Ammo(string id, AmmoTemplate template) { }

	public static OperationResult ApplyToAddress(Item from, ItemAddress toLocation, int count, ItemController itemController, bool simulate) { }

	public static OperationResult ApplyToAmmo(Item from, Item to, int count, ItemController itemController, bool simulate) { }

	public Ammo Clone(string id) { }

	public int get_ammoAccr() { }

	public int get_ammoDist() { }

	public float get_AmmoFactor() { }

	public int get_ammoHear() { }

	public float get_AmmoLifeTimeSec() { }

	public int get_ammoRec() { }

	public string get_ammoSfx() { }

	public int get_ammoShiftChance() { }

	public AmmoTemplate get_AmmoTemplate() { }

	public string get_ammoType() { }

	public int get_ArmorDamage() { }

	public float get_ArmorDamagePortion() { }

	public float get_BallisticCoeficient() { }

	public int get_buckshotBullets() { }

	public float get_BulletDiameterMilimeters() { }

	public float get_BulletMassGram() { }

	public string get_Caliber() { }

	public float get_casingEjectPower() { }

	public float get_casingMass() { }

	public string get_casingName() { }

	public string get_casingSounds() { }

	public int get_Damage() { }

	public float get_DurabilityBurnModificator() { }

	public float get_FragmentationChance() { }

	public float get_GetBulletSpeed() { }

	public float get_HeatFactor() { }

	public float get_HeavyBleedingDelta() { }

	public virtual bool get_ImportantForCheckSpawnedInSession() { }

	public float get_InitialSpeed() { }

	public virtual IEnumerable get_ItemInteractionButtons() { }

	public float get_LightBleedingDelta() { }

	public float get_MalfFeedChance() { }

	public float get_MalfMisfireChance() { }

	public int get_MaxFragmentsCount() { }

	public int get_MinFragmentsCount() { }

	public float get_MisfireChance() { }

	public float get_PenetrationChanceObstacle() { }

	public float get_PenetrationDamageMod() { }

	public int get_PenetrationPower() { }

	public float get_PenetrationPowerDiviation() { }

	public int get_ProjectileCount() { }

	public float get_RicochetChance() { }

	public bool get_ShowBullet() { }

	public virtual bool get_SpawnedInSession() { }

	public float get_StaminaBurnRate() { }

	public bool get_Tracer() { }

	public TaxonomyColor get_TracerColor() { }

	public float get_TracerDistance() { }

	public virtual void set_SpawnedInSession(bool value) { }

}

