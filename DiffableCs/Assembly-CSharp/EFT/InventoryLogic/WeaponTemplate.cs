namespace EFT.InventoryLogic;

public class WeaponTemplate : CompoundItemTemplate, IRepairableComponentTemplate, IFoldableComponentTemplate, IFireModeComponentTemplate
{
	public const int SINGLE_FIRE_RATE_DEFAULT = 240; //Field offset: 0x0
	public const bool CAN_QUEUE_SECOND_SHOT_DEFAULT = True; //Field offset: 0x0
	public EReloadMode ReloadMode; //Field offset: 0x170
	public string weapClass; //Field offset: 0x178
	public string weapUseType; //Field offset: 0x180
	public string ammoCaliber; //Field offset: 0x188
	public bool AdjustCollimatorsToTrajectory; //Field offset: 0x190
	public object[] weapAmmoTypes; //Field offset: 0x198
	public float Durability; //Field offset: 0x1A0
	public float MaxDurability; //Field offset: 0x1A4
	public float RepairComplexity; //Field offset: 0x1A8
	public float OperatingResource; //Field offset: 0x1AC
	public float RecoilCategoryMultiplierHandRotation; //Field offset: 0x1B0
	public float RecoilReturnSpeedHandRotation; //Field offset: 0x1B4
	public float RecoilDampingHandRotation; //Field offset: 0x1B8
	public float RecoilCamera; //Field offset: 0x1BC
	public int RecoilStableIndexShot; //Field offset: 0x1C0
	public float RecoilForceBack; //Field offset: 0x1C4
	public float RecoilForceUp; //Field offset: 0x1C8
	public int RecolDispersion; //Field offset: 0x1CC
	public float RecoilPosZMult; //Field offset: 0x1D0
	public float RecoilReturnPathDampingHandRotation; //Field offset: 0x1D4
	public float RecoilReturnPathOffsetHandRotation; //Field offset: 0x1D8
	public int RecoilAngle; //Field offset: 0x1DC
	public float RecoilStableAngleIncreaseStep; //Field offset: 0x1E0
	public Vector3 ProgressRecoilAngleOnStable; //Field offset: 0x1E4
	public Vector3 RecoilCenter; //Field offset: 0x1F0
	public Vector2 PostRecoilVerticalRangeHandRotation; //Field offset: 0x1FC
	public Vector2 PostRecoilHorizontalRangeHandRotation; //Field offset: 0x204
	public Vector2 CameraToWeaponAngleSpeedRange; //Field offset: 0x20C
	public float CameraToWeaponAngleStep; //Field offset: 0x214
	public ShotsGroupSettings[] ShotsGroupSettings; //Field offset: 0x218
	public float CameraSnap; //Field offset: 0x220
	public Vector3 MountingPosition; //Field offset: 0x224
	public float MountVerticalRecoilMultiplier; //Field offset: 0x230
	public float MountHorizontalRecoilMultiplier; //Field offset: 0x234
	public float MountReturnSpeedHandMultiplier; //Field offset: 0x238
	public float MountCameraSnapMultiplier; //Field offset: 0x23C
	public bool ResetAfterShot; //Field offset: 0x240
	public WeaponRecoil WeaponRecoilSettings; //Field offset: 0x248
	public WeaponAiming WeaponAimSettings; //Field offset: 0x250
	public float Ergonomics; //Field offset: 0x258
	public float Velocity; //Field offset: 0x25C
	public int durabSpawnMin; //Field offset: 0x260
	public int durabSpawnMax; //Field offset: 0x264
	public bool isFastReload; //Field offset: 0x268
	public bool isChamberLoad; //Field offset: 0x269
	public int ShotgunDispersion; //Field offset: 0x26C
	public int bFirerate; //Field offset: 0x270
	public int SingleFireRate; //Field offset: 0x274
	public bool CanQueueSecondShot; //Field offset: 0x278
	public int bEffDist; //Field offset: 0x27C
	public int bHearDist; //Field offset: 0x280
	public bool isBoltCatch; //Field offset: 0x284
	public string defMagType; //Field offset: 0x288
	public string defAmmo; //Field offset: 0x290
	public float AimPlane; //Field offset: 0x298
	public Slot[] Chambers; //Field offset: 0x2A0
	public float CenterOfImpact; //Field offset: 0x2A8
	public float DoubleActionAccuracyPenalty; //Field offset: 0x2AC
	public float DeviationMax; //Field offset: 0x2B0
	public float DeviationCurve; //Field offset: 0x2B4
	public bool MustBoltBeOpennedForExternalReload; //Field offset: 0x2B8
	public bool MustBoltBeOpennedForInternalReload; //Field offset: 0x2B9
	public bool Foldable; //Field offset: 0x2BA
	public bool Retractable; //Field offset: 0x2BB
	public bool BoltAction; //Field offset: 0x2BC
	public bool ManualBoltCatch; //Field offset: 0x2BD
	public Vector3 TacticalReloadStiffnes; //Field offset: 0x2C0
	public float TacticalReloadFixation; //Field offset: 0x2CC
	public Vector3 RotationCenter; //Field offset: 0x2D0
	public Vector3 RotationCenterNoStock; //Field offset: 0x2DC
	public int IronSightRange; //Field offset: 0x2E8
	public float HipInnaccuracyGain; //Field offset: 0x2EC
	public float HipAccuracyRestorationDelay; //Field offset: 0x2F0
	public float HipAccuracyRestorationSpeed; //Field offset: 0x2F4
	public float MountingHorizontalOutOfBreathMultiplier; //Field offset: 0x2F8
	public float MountingVerticalOutOfBreathMultiplier; //Field offset: 0x2FC
	private AmmoTemplate _defAmmoTemplate; //Field offset: 0x300
	public bool CompactHandling; //Field offset: 0x308
	public float SightingRange; //Field offset: 0x30C
	public bool AllowJam; //Field offset: 0x310
	public bool AllowFeed; //Field offset: 0x311
	public bool AllowMisfire; //Field offset: 0x312
	public bool AllowSlide; //Field offset: 0x313
	public float BaseMalfunctionChance; //Field offset: 0x314
	public float AimSensitivity; //Field offset: 0x318
	public float DurabilityBurnRatio; //Field offset: 0x31C
	public float HeatFactorGun; //Field offset: 0x320
	public float CoolFactorGun; //Field offset: 0x324
	public bool AllowOverheat; //Field offset: 0x328
	public float HeatFactorByShot; //Field offset: 0x32C
	public float CoolFactorGunMods; //Field offset: 0x330
	public bool IsFlareGun; //Field offset: 0x334
	public bool IsOneoff; //Field offset: 0x335
	public bool IsGrenadeLauncher; //Field offset: 0x336
	public bool NoFiremodeOnBoltcatch; //Field offset: 0x337
	public bool IsStationaryWeapon; //Field offset: 0x338
	public bool IsBeltMachineGun; //Field offset: 0x339
	public bool BlockLeftStance; //Field offset: 0x33A
	public bool WithAnimatorAiming; //Field offset: 0x33B
	public bool IsMountable; //Field offset: 0x33C
	public bool UseAltMountBone; //Field offset: 0x33D
	public bool CanUnloadAmmoByPlayer; //Field offset: 0x33E
	public WeaponTemplateAudioSettings AudioSettings; //Field offset: 0x340
	public float MinRepairDegradation; //Field offset: 0x348
	public float MaxRepairDegradation; //Field offset: 0x34C
	public int SizeReduceRight; //Field offset: 0x350
	public string FoldedSlot; //Field offset: 0x358
	public EFireMode[] weapFireType; //Field offset: 0x360
	public int BurstShotsCount; //Field offset: 0x368

	public AmmoTemplate DefAmmoTemplate
	{
		 get { } //Length: 589
	}

	private override EFireMode[] EFT.InventoryLogic.IFireModeComponentTemplate.AvailablEFireModes
	{
		private get { } //Length: 8
	}

	private override int EFT.InventoryLogic.IFireModeComponentTemplate.BurstShotsCount
	{
		private get { } //Length: 7
	}

	private override string EFT.InventoryLogic.IFoldableComponentTemplate.FoldedSlot
	{
		private get { } //Length: 8
	}

	private override int EFT.InventoryLogic.IFoldableComponentTemplate.SizeReduceRight
	{
		private get { } //Length: 7
	}

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.Durability
	{
		private get { } //Length: 6
	}

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.MaxDurability
	{
		private get { } //Length: 6
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MaxRepairDegradation
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MaxRepairKitDegradation
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MinRepairDegradation
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MinRepairKitDegradation
	{
		private get { } //Length: 9
	}

	public string MasteringLocalizationKey
	{
		 get { } //Length: 69
	}

	public WeaponTemplate() { }

	private override EFireMode[] EFT.InventoryLogic.IFireModeComponentTemplate.get_AvailablEFireModes() { }

	private override int EFT.InventoryLogic.IFireModeComponentTemplate.get_BurstShotsCount() { }

	private override string EFT.InventoryLogic.IFoldableComponentTemplate.get_FoldedSlot() { }

	private override int EFT.InventoryLogic.IFoldableComponentTemplate.get_SizeReduceRight() { }

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.get_Durability() { }

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxDurability() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxRepairDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxRepairKitDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MinRepairDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MinRepairKitDegradation() { }

	public AmmoTemplate get_DefAmmoTemplate() { }

	public string get_MasteringLocalizationKey() { }

}

