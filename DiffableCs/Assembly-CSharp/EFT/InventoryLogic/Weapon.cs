namespace EFT.InventoryLogic;

public class Weapon : CompoundItem, IWeapon
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__105_4; //Field offset: 0x8
		public static Func <>9__105_8; //Field offset: 0x10
		public static Func <>9__105_11; //Field offset: 0x18
		public static Func <>9__105_15; //Field offset: 0x20
		public static Func <>9__105_19; //Field offset: 0x28
		public static Func <>9__105_23; //Field offset: 0x30
		public static Func <>9__105_26; //Field offset: 0x38
		public static Func <>9__105_29; //Field offset: 0x40
		public static Func <>9__105_32; //Field offset: 0x48
		public static Func <>9__105_35; //Field offset: 0x50
		public static Func <>9__113_0; //Field offset: 0x58
		public static Func <>9__113_1; //Field offset: 0x60
		public static Func <>9__113_2; //Field offset: 0x68
		public static Func <>9__115_0; //Field offset: 0x70
		public static Func <>9__115_1; //Field offset: 0x78
		public static Func <>9__121_0; //Field offset: 0x80
		public static Func <>9__122_0; //Field offset: 0x88
		public static Func <>9__124_0; //Field offset: 0x90
		public static Func <>9__124_1; //Field offset: 0x98
		public static Func <>9__136_0; //Field offset: 0xA0
		public static Func <>9__138_0; //Field offset: 0xA8
		public static Func <>9__149_0; //Field offset: 0xB0
		public static Func <>9__154_0; //Field offset: 0xB8
		public static Func <>9__203_0; //Field offset: 0xC0
		public static Predicate <>9__224_0; //Field offset: 0xC8
		public static Func <>9__229_0; //Field offset: 0xD0
		public static Func <>9__230_0; //Field offset: 0xD8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__105_11() { }

		internal EItemAttributeDisplayType <.ctor>b__105_15() { }

		internal EItemAttributeDisplayType <.ctor>b__105_19() { }

		internal EItemAttributeDisplayType <.ctor>b__105_23() { }

		internal EItemAttributeDisplayType <.ctor>b__105_26() { }

		internal EItemAttributeDisplayType <.ctor>b__105_29() { }

		internal EItemAttributeDisplayType <.ctor>b__105_32() { }

		internal EItemAttributeDisplayType <.ctor>b__105_35() { }

		internal EItemAttributeDisplayType <.ctor>b__105_4() { }

		internal EItemAttributeDisplayType <.ctor>b__105_8() { }

		internal int <get_CenterOfImpactDelta>b__136_0(Mod mod) { }

		internal bool <get_EmptyTacticalSlotCount>b__124_0(Slot x) { }

		internal bool <get_EmptyTacticalSlotCount>b__124_1(Slot x) { }

		internal float <get_ErgonomicsDelta>b__121_0(Mod mod) { }

		internal Item <get_Mods>b__203_0(Slot slot) { }

		internal bool <get_RecoilDelta>b__113_0(Mod mod) { }

		internal float <get_RecoilDelta>b__113_1(Mod mod) { }

		internal float <get_RecoilDelta>b__113_2(Mod mod) { }

		internal bool <get_StockDoubleActionAccuracyPenaltyMult>b__138_0(Mod mod) { }

		internal bool <get_StockRecoilDelta>b__115_0(Mod mod) { }

		internal float <get_StockRecoilDelta>b__115_1(Mod mod) { }

		internal float <get_VelocityDelta>b__149_0(Mod mod) { }

		internal bool <GetLauncherSlot>b__230_0(Slot slot) { }

		internal bool <GetMagazineSlot>b__224_0(Slot x) { }

		internal float <GetSightingRange>b__122_0(Mod x) { }

		internal bool <GetUnderbarrelWeapon>b__229_0(Slot slot) { }

		internal bool <IsModSuitable>b__154_0(Slot x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass231_0
	{
		public ItemController itemController; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <get_Containers>d__156 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Weapon <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private Slot[] <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40

		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_Containers>d__156(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.IContainer>.GetEnumerator() { }

		[DebuggerHidden]
		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[Flags]
	internal enum EFireMode
	{
		fullauto = 0,
		single = 1,
		doublet = 2,
		burst = 3,
		doubleaction = 4,
		semiauto = 5,
		grenadeThrowing = 6,
		greanadePlanting = 7,
	}

	[Flags]
	internal enum EMalfunctionSource
	{
		Durability = 0,
		Ammo = 1,
		Magazine = 2,
		Overheat = 4,
		ConsoleCommand = 8,
		Effect = 16,
	}

	internal enum EMalfunctionState
	{
		None = 0,
		Misfire = 1,
		Jam = 2,
		HardSlide = 3,
		SoftSlide = 4,
		Feed = 5,
	}

	internal enum EReloadMode
	{
		ExternalMagazine = 0,
		InternalMagazine = 1,
		OnlyBarrel = 2,
		ExternalMagazineWithInternalReloadSupport = 3,
	}

	internal class MalfunctionState
	{
		[CompilerGenerated]
		private Action OnStateChanged; //Field offset: 0x10
		public Ammo AmmoToFire; //Field offset: 0x18
		public Ammo AmmoWillBeLoadedToChamber; //Field offset: 0x20
		public Ammo MalfunctionedAmmo; //Field offset: 0x28
		public float LastShotOverheat; //Field offset: 0x30
		public float LastShotTime; //Field offset: 0x34
		public float LastMalfunctionTime; //Field offset: 0x38
		public float OverheatBarrelMoveMult; //Field offset: 0x3C
		public Vector2 OverheatBarrelMoveDir; //Field offset: 0x40
		public float OverheatFirerateMult; //Field offset: 0x48
		public bool OverheatFirerateMultInited; //Field offset: 0x4C
		public bool SlideOnOverheatReached; //Field offset: 0x4D
		public bool AutoshotChanceInited; //Field offset: 0x4E
		public float AutoshotTime; //Field offset: 0x50
		private EMalfunctionState _state; //Field offset: 0x54
		private readonly List _playersWhoKnowAboutMalfunction; //Field offset: 0x58
		private readonly List _playersWhoKnowMalfType; //Field offset: 0x60
		private readonly Dictionary _playersReducedMalfChances; //Field offset: 0x68
		[CompilerGenerated]
		private EMalfunctionSource <Source>k__BackingField; //Field offset: 0x70

		public event Action OnStateChanged
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public bool IsAnyMalfExceptMisfire
		{
			 get { } //Length: 29
		}

		public IDictionary PlayersReducedMalfChances
		{
			 get { } //Length: 5
		}

		public IEnumerable PlayersWhoKnowAboutMalfunction
		{
			 get { } //Length: 5
		}

		public IEnumerable PlayersWhoKnowMalfType
		{
			 get { } //Length: 5
		}

		public EMalfunctionSource Source
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public EMalfunctionState State
		{
			 get { } //Length: 4
			 set { } //Length: 33
		}

		public MalfunctionState() { }

		[CompilerGenerated]
		public void add_OnStateChanged(Action value) { }

		public void AddMalfReduceChance(int raidId, EMalfunctionSource malfSource) { }

		public bool AddPlayerWhoKnowMalfType(int raidId) { }

		public void AddPlayerWhoKnowMalfunction(int raidId, bool clearRest = false) { }

		public void ChangeStateSilent(EMalfunctionState state) { }

		public void ClearPlayersWhoKnow() { }

		public void CopyFrom(MalfunctionDescriptor descriptor, ItemFactory itemFactory) { }

		public bool get_IsAnyMalfExceptMisfire() { }

		public IDictionary get_PlayersReducedMalfChances() { }

		public IEnumerable get_PlayersWhoKnowAboutMalfunction() { }

		public IEnumerable get_PlayersWhoKnowMalfType() { }

		[CompilerGenerated]
		public EMalfunctionSource get_Source() { }

		public EMalfunctionState get_State() { }

		public bool HasMalfReduceChance(int raidId, EMalfunctionSource malfSource) { }

		public bool IsKnownMalfType(int raidId) { }

		public bool IsKnownMalfunction(int raidId) { }

		[CompilerGenerated]
		public void remove_OnStateChanged(Action value) { }

		public void Repair() { }

		public void ResetOverheat() { }

		[CompilerGenerated]
		public void set_Source(EMalfunctionSource value) { }

		public void set_State(EMalfunctionState value) { }

	}

	public const string WEAPON_CLASS_PISTOL = "pistol"; //Field offset: 0x0
	public const float MOA_ON_100_METERS = 2.9089; //Field offset: 0x0
	private const float ERGONOMICS_MIN = 0; //Field offset: 0x0
	private const float ERGONOMICS_MAX = 100; //Field offset: 0x0
	private static readonly IEnumerable _weaponInteractions; //Field offset: 0x0
	public const float OVERHEAT_PROBLEMS_START = 100; //Field offset: 0x0
	private static List _preallocatedMods; //Field offset: 0x8
	[Component]
	public readonly RepairableComponent Repairable; //Field offset: 0x90
	[Component]
	public readonly FoldableComponent Foldable; //Field offset: 0x98
	[Component]
	public readonly FireModeComponent FireMode; //Field offset: 0xA0
	[Component]
	public BuffComponent Buff; //Field offset: 0xA8
	[CompilerGenerated]
	private Slot[] <Chambers>k__BackingField; //Field offset: 0xB0
	private Vector3[] _opticCalibrationPoints; //Field offset: 0xB8
	private TrajectoryCalculator _opticTrajectoryInfosForAGS; //Field offset: 0xC0
	private Slot _magSlotCache; //Field offset: 0xC8
	private int _lastModsCalculateFrame; //Field offset: 0xD0
	private IEnumerable _mods; //Field offset: 0xD8
	public BindableState AimIndex; //Field offset: 0xE0
	public bool CompatibleAmmo; //Field offset: 0xE8
	public bool Armed; //Field offset: 0xE9
	public bool IsUnderBarrelDeviceActive; //Field offset: 0xEA
	[CompilerGenerated]
	private Func OnMalfunctionValidate; //Field offset: 0xF0
	public bool CylinderHammerClosed; //Field offset: 0xF8
	private AmmoTemplate[] _shellsInChambers; //Field offset: 0x100
	[CompilerGenerated]
	private readonly MalfunctionState <MalfState>k__BackingField; //Field offset: 0x108
	public EMalfunctionState TutorialMalf; //Field offset: 0x110

	public event Func OnMalfunctionValidate
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public bool AllowFeed
	{
		 get { } //Length: 80
	}

	public bool AllowJam
	{
		 get { } //Length: 80
	}

	public bool AllowMalfunction
	{
		 get { } //Length: 231
	}

	public bool AllowMisfire
	{
		 get { } //Length: 80
	}

	public bool AllowOverheat
	{
		 get { } //Length: 80
	}

	public bool AllowSlide
	{
		 get { } //Length: 80
	}

	public virtual IEnumerable AllSlots
	{
		 get { } //Length: 79
	}

	public string AmmoCaliber
	{
		 get { } //Length: 150
	}

	public WeaponTemplateAudioSettings AudioSettings
	{
		 get { } //Length: 80
	}

	public float BaseMalfunctionChance
	{
		 get { } //Length: 81
	}

	public bool BlockLeftStance
	{
		 get { } //Length: 80
	}

	public bool BoltAction
	{
		 get { } //Length: 80
	}

	public virtual bool CanBePickedUp
	{
		 get { } //Length: 83
	}

	public override bool CanLoadAmmo
	{
		 get { } //Length: 3
	}

	public bool CanLoadAmmoToChamber
	{
		 get { } //Length: 80
	}

	public bool CanQueueSecondShot
	{
		 get { } //Length: 80
	}

	public bool CanReloadFast
	{
		 get { } //Length: 80
	}

	public bool CanUnloadAmmoByPlayer
	{
		 get { } //Length: 80
	}

	public float CenterOfImpactBase
	{
		 get { } //Length: 213
	}

	public float CenterOfImpactDelta
	{
		 get { } //Length: 426
	}

	public int ChamberAmmoCount
	{
		 get { } //Length: 280
	}

	public override Slot[] Chambers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool CompactHandling
	{
		 get { } //Length: 80
	}

	public virtual IEnumerable Containers
	{
		[IteratorStateMachine(typeof(<get_Containers>d__156))]
		 get { } //Length: 175
	}

	public float CoolFactorGun
	{
		 get { } //Length: 81
	}

	[CanBeNull]
	public AmmoTemplate CurrentAmmoTemplate
	{
		 get { } //Length: 484
	}

	public float DeviationCurve
	{
		 get { } //Length: 216
	}

	private float DeviationMax
	{
		private get { } //Length: 243
	}

	public float DoubleActionAccuracyPenalty
	{
		 get { } //Length: 81
	}

	public float DurabilityBurnRatio
	{
		 get { } //Length: 81
	}

	private override bool EFT.InventoryLogic.IWeapon.IsUnderbarrelWeapon
	{
		private get { } //Length: 3
	}

	private override Item EFT.InventoryLogic.IWeapon.Item
	{
		private get { } //Length: 4
	}

	private override WeaponTemplate EFT.InventoryLogic.IWeapon.WeaponTemplate
	{
		private get { } //Length: 62
	}

	public int EmptyTacticalSlotCount
	{
		 get { } //Length: 750
	}

	public float ErgonomicsDelta
	{
		 get { } //Length: 524
	}

	public float ErgonomicsTotal
	{
		 get { } //Length: 113
	}

	public int FireRate
	{
		 get { } //Length: 79
	}

	public Slot FirstFreeChamberSlot
	{
		 get { } //Length: 189
	}

	public Slot FirstLoadedChamberSlot
	{
		 get { } //Length: 189
	}

	public bool Folded
	{
		 get { } //Length: 112
	}

	public Slot[] FreeChambersForLoading
	{
		 get { } //Length: 475
	}

	public int FreeChamberSlotsCount
	{
		 get { } //Length: 29
	}

	public bool HasChambers
	{
		 get { } //Length: 33
	}

	public bool HasShellsInChamberBarrelOnlyWeapon
	{
		 get { } //Length: 84
	}

	public float HeatFactorByShot
	{
		 get { } //Length: 81
	}

	public float HeatFactorGun
	{
		 get { } //Length: 81
	}

	public bool IsBeltMachineGun
	{
		 get { } //Length: 80
	}

	public bool IsBoltCatch
	{
		 get { } //Length: 80
	}

	public bool IsFlareGun
	{
		 get { } //Length: 80
	}

	public bool IsGrenadeLauncher
	{
		 get { } //Length: 80
	}

	public bool IsMountable
	{
		 get { } //Length: 80
	}

	public bool IsMultiBarrel
	{
		 get { } //Length: 33
	}

	public bool IsOneOff
	{
		 get { } //Length: 80
	}

	public bool IsStationaryWeapon
	{
		 get { } //Length: 80
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		 get { } //Length: 133
	}

	public override MalfunctionState MalfState
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool ManualBoltCatch
	{
		 get { } //Length: 80
	}

	public IEnumerable Mods
	{
		 get { } //Length: 697
	}

	public bool MustBoltBeOpennedForExternalReload
	{
		 get { } //Length: 80
	}

	public bool MustBoltBeOpennedForInternalReload
	{
		 get { } //Length: 80
	}

	public bool NoFiremodeOnBoltcatch
	{
		 get { } //Length: 80
	}

	public Vector3[] OpticCalibrationPointsForAll
	{
		 get { } //Length: 8
	}

	public override float RecoilBase
	{
		 get { } //Length: 155
	}

	public override float RecoilDelta
	{
		 get { } //Length: 995
	}

	public override float RecoilForceBack
	{
		 get { } //Length: 81
	}

	public float RecoilTotal
	{
		 get { } //Length: 76
	}

	public EReloadMode ReloadMode
	{
		 get { } //Length: 380
	}

	public EFireMode SelectedFireMode
	{
		 get { } //Length: 30
	}

	public int ShellsInChamberCount
	{
		 get { } //Length: 280
	}

	public AmmoTemplate[] ShellsInChambers
	{
		 get { } //Length: 333
		 set { } //Length: 82
	}

	public int ShellsInWeaponCount
	{
		 get { } //Length: 460
	}

	public float ShotgunDispersionBase
	{
		 get { } //Length: 219
	}

	public float SightingRange
	{
		 get { } //Length: 81
	}

	public int SingleFireRate
	{
		 get { } //Length: 537
	}

	public override float SpeedFactor
	{
		 get { } //Length: 24
	}

	public float StockDoubleActionAccuracyPenaltyMult
	{
		 get { } //Length: 474
	}

	public float StockRecoilDelta
	{
		 get { } //Length: 739
	}

	public bool SupportsInternalReload
	{
		 get { } //Length: 49
	}

	public WeaponTemplate Template
	{
		 get { } //Length: 62
	}

	public float TotalAccuracy
	{
		 get { } //Length: 125
	}

	public float TotalShotgunDispersion
	{
		 get { } //Length: 251
	}

	public float TotalVelocity
	{
		 get { } //Length: 72
	}

	public bool UseAltMountBone
	{
		 get { } //Length: 80
	}

	public float VelocityBase
	{
		 get { } //Length: 37
	}

	public float VelocityDelta
	{
		 get { } //Length: 512
	}

	public string WeapClass
	{
		 get { } //Length: 80
	}

	public EFireMode[] WeapFireType
	{
		 get { } //Length: 80
	}

	public bool WithAnimatorAiming
	{
		 get { } //Length: 80
	}

	private static Weapon() { }

	public Weapon(string id, WeaponTemplate template) { }

	[CompilerGenerated]
	private Slot <.ctor>b__105_0(Slot x) { }

	[CompilerGenerated]
	private float <.ctor>b__105_1() { }

	[CompilerGenerated]
	private string <.ctor>b__105_10() { }

	[CompilerGenerated]
	private float <.ctor>b__105_12() { }

	[CompilerGenerated]
	private float <.ctor>b__105_13() { }

	[CompilerGenerated]
	private string <.ctor>b__105_14() { }

	[CompilerGenerated]
	private float <.ctor>b__105_16() { }

	[CompilerGenerated]
	private float <.ctor>b__105_17() { }

	[CompilerGenerated]
	private string <.ctor>b__105_18() { }

	[CompilerGenerated]
	private float <.ctor>b__105_2() { }

	[CompilerGenerated]
	private float <.ctor>b__105_20() { }

	[CompilerGenerated]
	private float <.ctor>b__105_21() { }

	[CompilerGenerated]
	private string <.ctor>b__105_22() { }

	[CompilerGenerated]
	private float <.ctor>b__105_24() { }

	[CompilerGenerated]
	private string <.ctor>b__105_25() { }

	[CompilerGenerated]
	private float <.ctor>b__105_27() { }

	[CompilerGenerated]
	private string <.ctor>b__105_28() { }

	[CompilerGenerated]
	private string <.ctor>b__105_3() { }

	[CompilerGenerated]
	private float <.ctor>b__105_30() { }

	[CompilerGenerated]
	private string <.ctor>b__105_31() { }

	[CompilerGenerated]
	private float <.ctor>b__105_33() { }

	[CompilerGenerated]
	private string <.ctor>b__105_34() { }

	[CompilerGenerated]
	private float <.ctor>b__105_5() { }

	[CompilerGenerated]
	private float <.ctor>b__105_6() { }

	[CompilerGenerated]
	private string <.ctor>b__105_7() { }

	[CompilerGenerated]
	private float <.ctor>b__105_9() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	[CompilerGenerated]
	internal static IResult <Apply>g__CheckActiveEvents|231_0(ItemAddress itemAddress, ref <>c__DisplayClass231_0 unnamed_param_1) { }

	[CompilerGenerated]
	public void add_OnMalfunctionValidate(Func value) { }

	public virtual OperationResult Apply(ItemController itemController, Item item, int count, bool simulate) { }

	public Vector3 CalculateShotDirectionForIron(Vector3 localPosition, float CachedSpeedFactor, int calibrationRange) { }

	public bool CanQuickdrawPistolAfterMalf(float pastTime, MalfunctionSettings malfSettings) { }

	public Vector3[] CreateOpticCalibrationData(int[] opticCalibrationDistances, AmmoTemplate ammoTemplate, float speedFactor, float deltaTime) { }

	public void CreateOpticCalibrationPoints(SightComponent sight) { }

	private override bool EFT.InventoryLogic.IWeapon.get_IsUnderbarrelWeapon() { }

	private override Item EFT.InventoryLogic.IWeapon.get_Item() { }

	private override WeaponTemplate EFT.InventoryLogic.IWeapon.get_WeaponTemplate() { }

	private override int EFT.InventoryLogic.IWeapon.GetCurrentMagazineCount() { }

	public bool get_AllowFeed() { }

	public bool get_AllowJam() { }

	public bool get_AllowMalfunction() { }

	public bool get_AllowMisfire() { }

	public bool get_AllowOverheat() { }

	public bool get_AllowSlide() { }

	public virtual IEnumerable get_AllSlots() { }

	public string get_AmmoCaliber() { }

	public WeaponTemplateAudioSettings get_AudioSettings() { }

	public float get_BaseMalfunctionChance() { }

	public bool get_BlockLeftStance() { }

	public bool get_BoltAction() { }

	public virtual bool get_CanBePickedUp() { }

	public override bool get_CanLoadAmmo() { }

	public bool get_CanLoadAmmoToChamber() { }

	public bool get_CanQueueSecondShot() { }

	public bool get_CanReloadFast() { }

	public bool get_CanUnloadAmmoByPlayer() { }

	public float get_CenterOfImpactBase() { }

	public float get_CenterOfImpactDelta() { }

	public int get_ChamberAmmoCount() { }

	[CompilerGenerated]
	public override Slot[] get_Chambers() { }

	public bool get_CompactHandling() { }

	[IteratorStateMachine(typeof(<get_Containers>d__156))]
	public virtual IEnumerable get_Containers() { }

	public float get_CoolFactorGun() { }

	public AmmoTemplate get_CurrentAmmoTemplate() { }

	public float get_DeviationCurve() { }

	private float get_DeviationMax() { }

	public float get_DoubleActionAccuracyPenalty() { }

	public float get_DurabilityBurnRatio() { }

	public int get_EmptyTacticalSlotCount() { }

	public float get_ErgonomicsDelta() { }

	public float get_ErgonomicsTotal() { }

	public int get_FireRate() { }

	public Slot get_FirstFreeChamberSlot() { }

	public Slot get_FirstLoadedChamberSlot() { }

	public bool get_Folded() { }

	public Slot[] get_FreeChambersForLoading() { }

	public int get_FreeChamberSlotsCount() { }

	public bool get_HasChambers() { }

	public bool get_HasShellsInChamberBarrelOnlyWeapon() { }

	public float get_HeatFactorByShot() { }

	public float get_HeatFactorGun() { }

	public bool get_IsBeltMachineGun() { }

	public bool get_IsBoltCatch() { }

	public bool get_IsFlareGun() { }

	public bool get_IsGrenadeLauncher() { }

	public bool get_IsMountable() { }

	public bool get_IsMultiBarrel() { }

	public bool get_IsOneOff() { }

	public bool get_IsStationaryWeapon() { }

	public virtual IEnumerable get_ItemInteractionButtons() { }

	[CompilerGenerated]
	public override MalfunctionState get_MalfState() { }

	public bool get_ManualBoltCatch() { }

	public IEnumerable get_Mods() { }

	public bool get_MustBoltBeOpennedForExternalReload() { }

	public bool get_MustBoltBeOpennedForInternalReload() { }

	public bool get_NoFiremodeOnBoltcatch() { }

	public Vector3[] get_OpticCalibrationPointsForAll() { }

	public override float get_RecoilBase() { }

	public override float get_RecoilDelta() { }

	public override float get_RecoilForceBack() { }

	public float get_RecoilTotal() { }

	public EReloadMode get_ReloadMode() { }

	public EFireMode get_SelectedFireMode() { }

	public int get_ShellsInChamberCount() { }

	public AmmoTemplate[] get_ShellsInChambers() { }

	public int get_ShellsInWeaponCount() { }

	public float get_ShotgunDispersionBase() { }

	public float get_SightingRange() { }

	public int get_SingleFireRate() { }

	public override float get_SpeedFactor() { }

	public float get_StockDoubleActionAccuracyPenaltyMult() { }

	public float get_StockRecoilDelta() { }

	public bool get_SupportsInternalReload() { }

	public WeaponTemplate get_Template() { }

	public float get_TotalAccuracy() { }

	public float get_TotalShotgunDispersion() { }

	public float get_TotalVelocity() { }

	public bool get_UseAltMountBone() { }

	public float get_VelocityBase() { }

	public float get_VelocityDelta() { }

	public string get_WeapClass() { }

	public EFireMode[] get_WeapFireType() { }

	public bool get_WithAnimatorAiming() { }

	public float GetBarrelDeviation() { }

	private float GetBarrelDeviation(float durability) { }

	public virtual IContainer GetContainer(string containerId) { }

	public virtual Magazine GetCurrentMagazine() { }

	public int GetCurrentMagazineCount() { }

	public float GetCurrentOverheat(float pastTime, OverheatSettings overheatSettings, out float modsCoolFactor) { }

	public float GetCurrentOverheat(float pastTime, OverheatSettings overheatSettings, List weaponCurrentMods, out float modsCoolFactor) { }

	public Vector2 GetCurrentOverheatBarrelMove(float pastTime, float timeToChangeDir) { }

	public float GetDurabilityLossOnShot(float ammoBurnRatio, float overheatFactor, float skillWeaponTreatmentFactor, out float modsBurnRatio) { }

	[CanBeNull]
	public T GetFirstOrDefaultMod() { }

	public FoldableComponent GetFoldable() { }

	public virtual int GetHashSum() { }

	[CanBeNull]
	public Slot GetLauncherSlot() { }

	[CanBeNull]
	public Slot GetMagazineSlot() { }

	public int GetMaxMagazineCount() { }

	public int GetModsHashSumWithoutMag() { }

	public void GetShellsIndexes(List shellsIndexes) { }

	public int GetShellsInWeaponCount() { }

	public float GetShotOverheat(float ammoHeatFactor, float globalModHeatFactor, out float modsHeatFactor) { }

	public float GetSightingRange() { }

	public float GetTotalCenterOfImpact(bool includeAmmo) { }

	[CanBeNull]
	public Launcher GetUnderbarrelWeapon() { }

	public bool HasMagazineWithBelt() { }

	public bool IsModSuitable(Mod mod) { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext context) { }

	public void OnShot(float ammoBurnRatio, float ammoHeatFactor, float skillWeaponTreatmentFactor, OverheatSettings overheatSettings, float pastTime) { }

	public void RecalculateOpticCalibrationPoints() { }

	private void RecalculateScopeCalibrationPoints(SightComponent sight, int scopeIndex) { }

	[CompilerGenerated]
	public void remove_OnMalfunctionValidate(Func value) { }

	[CompilerGenerated]
	public void set_Chambers(Slot[] value) { }

	public void set_ShellsInChambers(AmmoTemplate[] value) { }

	public virtual bool TryFindItem(string itemId, out Item item) { }

	public bool ValidateMalfunction(EMalfunctionState malfState) { }

	public Vector3 ZeroLevelPosition(Vector3 direction, Vector3 startPosition, float height, out float time) { }

}

