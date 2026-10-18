namespace EFT;

public sealed class SkillManager : IInventoryProfileSkillInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__72_0; //Field offset: 0x8
		public static Func <>9__248_5; //Field offset: 0x10
		public static Func <>9__248_6; //Field offset: 0x18
		public static Func <>9__248_0; //Field offset: 0x20
		public static Func <>9__248_1; //Field offset: 0x28
		public static Func <>9__248_2; //Field offset: 0x30
		public static Func <>9__248_3; //Field offset: 0x38
		public static Func <>9__248_4; //Field offset: 0x40
		public static Func <>9__255_5; //Field offset: 0x48
		public static Func <>9__255_7; //Field offset: 0x50
		public static Func <>9__255_8; //Field offset: 0x58
		public static Func <>9__255_9; //Field offset: 0x60
		public static Func <>9__255_10; //Field offset: 0x68
		public static Func <>9__303_2; //Field offset: 0x70
		public static Func <>9__303_3; //Field offset: 0x78
		public static Func <>9__303_4; //Field offset: 0x80
		public static Func <>9__303_5; //Field offset: 0x88
		public static Func <>9__303_6; //Field offset: 0x90

		private static <>c() { }

		public <>c() { }

		internal bool <CreateMental>b__248_0(bool x) { }

		internal bool <CreateMental>b__248_1(bool x) { }

		internal bool <CreateMental>b__248_2(Skill skill) { }

		internal bool <CreateMental>b__248_3(Skill skill) { }

		internal bool <CreateMental>b__248_4(Skill skill) { }

		internal bool <CreateMental>b__248_5(Skill skill) { }

		internal bool <CreateMental>b__248_6(Skill skill) { }

		internal bool <CreatePhysical>b__255_10(IHealthEffect effect) { }

		internal bool <CreatePhysical>b__255_5(IHealthEffect effect) { }

		internal bool <CreatePhysical>b__255_7(float x) { }

		internal bool <CreatePhysical>b__255_8(float x) { }

		internal bool <CreatePhysical>b__255_9(IHealthEffect effect) { }

		internal float <CreatePractical>b__303_2(int i) { }

		internal bool <CreatePractical>b__303_3(Skill x) { }

		internal bool <CreatePractical>b__303_4(bool x) { }

		internal bool <CreatePractical>b__303_5(ShotParams p) { }

		internal float <CreatePractical>b__303_6(int i) { }

		internal float <GetWeaponBuffs>b__72_0(int _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass149_0
	{
		public MasteringInfoDescriptor mastering; //Field offset: 0x10

		public <>c__DisplayClass149_0() { }

		internal bool <.ctor>b__0(MasteringGroup x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass150_0
	{
		public Skill skill; //Field offset: 0x10
		public SkillManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass150_0() { }

		internal void <.ctor>b__0() { }

		internal void <.ctor>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass215_0
	{
		public string weaponTemplateId; //Field offset: 0x10

		public <>c__DisplayClass215_0() { }

		internal bool <ChangeMasteringLevel>b__0(MasteringGroup x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass216_0
	{
		public MasteringGroup group; //Field offset: 0x10
		public SkillManager <>4__this; //Field offset: 0x18
		public Mastering newMastering; //Field offset: 0x20

		public <>c__DisplayClass216_0() { }

		internal void <MasterNewWeapon>b__0() { }

		internal void <MasterNewWeapon>b__1() { }

		internal bool <MasterNewWeapon>b__2(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass220_0
	{
		public string templateId; //Field offset: 0x10

		public <>c__DisplayClass220_0() { }

		internal bool <GetMastering>b__0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass223_0
	{
		public Skill newSkillInfo; //Field offset: 0x10

		public <>c__DisplayClass223_0() { }

		internal bool <ApplyChanges>b__0(Skill x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass255_0
	{
		public SkillManager <>4__this; //Field offset: 0x10
		public ESkillId[] skillsRelatedToHealth; //Field offset: 0x18

		public <>c__DisplayClass255_0() { }

		internal float <CreatePhysical>b__0(MovementParams movement) { }

		internal float <CreatePhysical>b__1(MovementParams movement) { }

		internal float <CreatePhysical>b__2(MovementParams movement) { }

		internal float <CreatePhysical>b__3(MovementParams movement) { }

		internal float <CreatePhysical>b__4(MovementParams movement) { }

		internal bool <CreatePhysical>b__6(Skill skill) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass303_0
	{
		public PointsRate pointsRate; //Field offset: 0x10
		public SkillManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass303_0() { }

		internal float <CreatePractical>b__7(ValueTuple tuple) { }

	}

	internal sealed class BooleanBuff : Buff
	{
		public bool Value; //Field offset: 0x30

		public virtual object ValueObj
		{
			 get { } //Length: 73
		}

		public BooleanBuff() { }

		[CompilerGenerated]
		private void <.ctor>b__3_0(int level) { }

		[CompilerGenerated]
		private void <.ctor>b__3_1() { }

		public virtual object get_ValueObj() { }

		public static bool op_Implicit(BooleanBuff buff) { }

	}

	internal abstract class Buff
	{
		public EBuffId Id; //Field offset: 0x10
		public EBuffType BuffType; //Field offset: 0x14
		public bool HidenForPlayers; //Field offset: 0x18
		public Action BaseRuleFunc; //Field offset: 0x20
		public Action EliteRuleFunc; //Field offset: 0x28

		public override object ValueObj
		{
			 get { } //Length: 3
		}

		protected Buff() { }

		public override object get_ValueObj() { }

	}

	[Obsolete]
	internal class Buff`1 : Buff
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public Buff <>4__this; //Field offset: 0x0
			public Func rule; //Field offset: 0x0

			public <>c__DisplayClass6_0() { }

			internal T <BaseRule>b__0(int level) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public Buff <>4__this; //Field offset: 0x0
			public Func rule; //Field offset: 0x0

			public <>c__DisplayClass7_0() { }

			internal T <EliteRule>b__0() { }

		}

		public T Value; //Field offset: 0x0
		public Func BaseRuleFunc; //Field offset: 0x0
		public Func EliteRuleFunc; //Field offset: 0x0

		public virtual object ValueObj
		{
			 get { } //Length: 171
		}

		public Buff`1() { }

		public Buff BaseRule(Func rule) { }

		public Buff EliteRule(Func rule) { }

		public virtual object get_ValueObj() { }

		public static T op_Implicit(Buff buff) { }

	}

	internal enum EBuffType
	{
		Simple = 0,
		Elite = 1,
		Switching = 2,
		Plebian = 3,
	}

	internal class FloatBuff : Buff
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public FloatBuff <>4__this; //Field offset: 0x10
			public float factor; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <PerLevel>b__0(int level) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public FloatBuff <>4__this; //Field offset: 0x10
			public float factor; //Field offset: 0x18

			public <>c__DisplayClass6_0() { }

			internal void <Max>b__0(int level) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public FloatBuff <>4__this; //Field offset: 0x10
			public Func rule; //Field offset: 0x18

			public <>c__DisplayClass7_0() { }

			internal void <Custom>b__0(int level) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			public FloatBuff <>4__this; //Field offset: 0x10
			public float absolute; //Field offset: 0x18

			public <>c__DisplayClass8_0() { }

			internal void <Elite>b__0() { }

		}

		public float Value; //Field offset: 0x30

		public virtual object ValueObj
		{
			 get { } //Length: 76
		}

		public FloatBuff() { }

		public override void Apply(ref float val) { }

		public override float Apply(float val) { }

		public FloatBuff Custom(Func rule) { }

		public override FloatBuff Default(float val) { }

		public FloatBuff Elite(float absolute) { }

		public virtual object get_ValueObj() { }

		public FloatBuff Max(float factor) { }

		public static float op_Implicit(FloatBuff buff) { }

		public FloatBuff PerLevel(float factor) { }

	}

	internal sealed class GainBuff : FloatBuff
	{

		public GainBuff() { }

		public virtual float Apply(float val) { }

		public virtual void Apply(ref float val) { }

	}

	internal class GrenadeBuffsInfo
	{
		public float GrenadeAnimatorSpeed; //Field offset: 0x10

		public GrenadeBuffsInfo() { }

	}

	internal sealed class LossBuff : FloatBuff
	{

		public LossBuff() { }

		public virtual float Apply(float val) { }

		public virtual void Apply(ref float val) { }

	}

	internal struct MovementParams
	{
		public float Noise; //Field offset: 0x0
		public float Overweight; //Field offset: 0x4
		public float Fatigue; //Field offset: 0x8

	}

	internal sealed class ProbabilityBuff : FloatBuff
	{
		[CompilerGenerated]
		private Action OnResult; //Field offset: 0x38

		public event Action OnResult
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public ProbabilityBuff() { }

		[CompilerGenerated]
		public void add_OnResult(Action value) { }

		[CompilerGenerated]
		public void remove_OnResult(Action value) { }

		public bool Roll() { }

		public bool Roll(float precomputed) { }

	}

	internal class ShotParams
	{
		public float Distance; //Field offset: 0x10
		public EBodyPart BodyPart; //Field offset: 0x14
		public bool HoldBreath; //Field offset: 0x18

		public ShotParams() { }

	}

	internal class SkillAction
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public string log; //Field offset: 0x10

			public <>c__DisplayClass7_0() { }

			internal void <Log>b__0(SkillAction _, float f) { }

		}

		[CompilerGenerated]
		private Action ExternalEvent; //Field offset: 0x10
		public float FactorValue; //Field offset: 0x18
		public bool SimpleCalculation; //Field offset: 0x1C
		protected float StartTime; //Field offset: 0x20

		public event Action ExternalEvent
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public SkillAction() { }

		[CompilerGenerated]
		public void add_ExternalEvent(Action value) { }

		public override void Begin() { }

		public override void Complete(float val = 1) { }

		public SkillAction Factor(float fac, bool nonWeaponSkill = true) { }

		protected void InvokeExternal(float val) { }

		public SkillAction Log(string log) { }

		[CompilerGenerated]
		public void remove_ExternalEvent(Action value) { }

	}

	internal sealed class SkillAction`1 : SkillAction
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public Func condition; //Field offset: 0x0
			public SkillAction <>4__this; //Field offset: 0x0

			public <>c__DisplayClass4_0() { }

			internal void <.ctor>b__0(float val, TFilter filter1) { }

		}

		[CompilerGenerated]
		private Action InnerEvent; //Field offset: 0x0

		public event Action InnerEvent
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public SkillAction`1() { }

		private SkillAction`1(SkillAction action, Func condition) { }

		[CompilerGenerated]
		public void add_InnerEvent(Action value) { }

		public void Complete(TFilter filter, float val = 1) { }

		[CompilerGenerated]
		public void remove_InnerEvent(Action value) { }

		public SkillAction Where(Func condition) { }

	}

	internal sealed class SkillDependency`1 : SkillAction
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public Func condition; //Field offset: 0x0
			public SkillDependency <>4__this; //Field offset: 0x0

			public <>c__DisplayClass4_0() { }

			internal void <.ctor>b__0(float val, TFilter filter1) { }

		}

		[CompilerGenerated]
		private Action InnerEvent; //Field offset: 0x0

		public event Action InnerEvent
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public SkillDependency`1() { }

		private SkillDependency`1(SkillDependency action, Func condition) { }

		[CompilerGenerated]
		public void add_InnerEvent(Action value) { }

		public void Complete(TFilter filter, float val = 1) { }

		public SkillAction Factor(Func condition) { }

		[CompilerGenerated]
		public void remove_InnerEvent(Action value) { }

	}

	internal class WeaponBuffsInfo
	{
		public float DeltaErgonomics; //Field offset: 0x10
		public float ReloadSpeed; //Field offset: 0x14
		public Vector2 RecoilSupression; //Field offset: 0x18
		public float FixSpeed; //Field offset: 0x20
		public float SwapSpeed; //Field offset: 0x24
		public float AimSpeed; //Field offset: 0x28
		public bool StiffDraw; //Field offset: 0x2C
		public float AimMovementSpeed; //Field offset: 0x30
		public bool Maxed; //Field offset: 0x34
		public float DoubleActionRecoilReduce; //Field offset: 0x38
		public float MountingBonusErgo; //Field offset: 0x3C
		public float BipodBonusErgo; //Field offset: 0x40

		public WeaponBuffsInfo() { }

	}

	public const float NO_EXPENSE_AIM_TIMING = 5; //Field offset: 0x0
	public const float FAST_AIM_TIMING = 2; //Field offset: 0x0
	public readonly Dictionary WeaponBuffs; //Field offset: 0x10
	public readonly Dictionary WeaponBoolenBuffs; //Field offset: 0x18
	public readonly FloatBuff EnduranceBuffEnduranceInc; //Field offset: 0x20
	public readonly FloatBuff EnduranceHands; //Field offset: 0x28
	public readonly FloatBuff EnduranceBuffJumpCostRed; //Field offset: 0x30
	public readonly FloatBuff EnduranceBuffBreathTimeInc; //Field offset: 0x38
	public readonly FloatBuff EnduranceBuffRestoration; //Field offset: 0x40
	public readonly FloatBuff EnduranceBreathElite; //Field offset: 0x48
	public readonly FloatBuff StrengthBuffLiftWeightInc; //Field offset: 0x50
	public readonly FloatBuff StrengthBuffSprintSpeedInc; //Field offset: 0x58
	public readonly FloatBuff StrengthBuffJumpHeightInc; //Field offset: 0x60
	public readonly FloatBuff StrengthBuffAimFatigue; //Field offset: 0x68
	public readonly FloatBuff StrengthBuffThrowDistanceInc; //Field offset: 0x70
	public readonly FloatBuff StrengthBuffMeleePowerInc; //Field offset: 0x78
	public readonly BooleanBuff StrengthBuffElite; //Field offset: 0x80
	public readonly FloatBuff StrengthBuffMeleeCrits; //Field offset: 0x88
	public readonly FloatBuff VitalityBuffBleedChanceRed; //Field offset: 0x90
	public readonly FloatBuff VitalityBuffSurviobilityInc; //Field offset: 0x98
	public readonly BooleanBuff VitalityBuffRegeneration; //Field offset: 0xA0
	public readonly BooleanBuff VitalityBuffBleedStop; //Field offset: 0xA8
	public readonly FloatBuff HealthBreakChanceRed; //Field offset: 0xB0
	public readonly FloatBuff HealthOfflineRegenerationInc; //Field offset: 0xB8
	public readonly FloatBuff HealthEnergy; //Field offset: 0xC0
	public readonly FloatBuff HealthHydration; //Field offset: 0xC8
	public readonly BooleanBuff HealthEliteAbsorbDamage; //Field offset: 0xD0
	public readonly FloatBuff HealthElitePosion; //Field offset: 0xD8
	public readonly FloatBuff StressPain; //Field offset: 0xE0
	public readonly FloatBuff StressTremor; //Field offset: 0xE8
	public readonly BooleanBuff StressBerserk; //Field offset: 0xF0
	public readonly GainBuff MetabolismRatioPlus; //Field offset: 0xF8
	public readonly FloatBuff MetabolismPoisonTime; //Field offset: 0x100
	public readonly LossBuff MetabolismMiscDebuffTime; //Field offset: 0x108
	public readonly BooleanBuff MetabolismEliteBuffNoDyhydration; //Field offset: 0x110
	public readonly FloatBuff PerceptionHearing; //Field offset: 0x118
	public readonly FloatBuff PerceptionLootDot; //Field offset: 0x120
	public readonly BooleanBuff PerceptionEliteNoIdea; //Field offset: 0x128
	public readonly FloatBuff IntellectLearningSpeed; //Field offset: 0x130
	public readonly FloatBuff IntellectWeaponMaintance; //Field offset: 0x138
	public readonly BooleanBuff IntellectEliteNaturalLearner; //Field offset: 0x140
	public readonly BooleanBuff IntellectEliteAmmoCounter; //Field offset: 0x148
	public readonly BooleanBuff IntellectEliteContainerScope; //Field offset: 0x150
	public readonly FloatBuff IntellectRepairPointsCostReduction; //Field offset: 0x158
	public readonly FloatBuff AttentionLootSpeed; //Field offset: 0x160
	public readonly FloatBuff AttentionExamine; //Field offset: 0x168
	public readonly FloatBuff AttentionEliteLuckySearch; //Field offset: 0x170
	public readonly BooleanBuff AttentionEliteExtraLootExp; //Field offset: 0x178
	public readonly FloatBuff MagDrillsLoadSpeed; //Field offset: 0x180
	public readonly FloatBuff MagDrillsUnloadSpeed; //Field offset: 0x188
	public readonly FloatBuff MagDrillsInventoryCheckSpeed; //Field offset: 0x190
	public readonly FloatBuff MagDrillsInventoryCheckAccuracy; //Field offset: 0x198
	public readonly BooleanBuff MagDrillsInstantCheck; //Field offset: 0x1A0
	public readonly BooleanBuff MagDrillsLoadProgression; //Field offset: 0x1A8
	public readonly FloatBuff CharismaBuff1; //Field offset: 0x1B0
	public readonly FloatBuff CharismaBuff2; //Field offset: 0x1B8
	public readonly FloatBuff CharismaDailyQuestsRerollDiscount; //Field offset: 0x1C0
	public readonly FloatBuff CharismaHealingDiscount; //Field offset: 0x1C8
	public readonly FloatBuff CharismaInsuranceDiscount; //Field offset: 0x1D0
	public readonly FloatBuff CharismaExfiltrationDiscount; //Field offset: 0x1D8
	public readonly FloatBuff CharismaEliteScavCaseDiscount; //Field offset: 0x1E0
	public readonly FloatBuff CharismaEliteFenceRepPenaltyReduction; //Field offset: 0x1E8
	public readonly FloatBuff CharismaEliteAdditionalDailyQuests; //Field offset: 0x1F0
	public readonly BooleanBuff CharismaEliteBuff1; //Field offset: 0x1F8
	public readonly FloatBuff CharismaEliteBuff2; //Field offset: 0x200
	public readonly LossBuff ImmunityMiscEffects; //Field offset: 0x208
	public readonly LossBuff ImmunityPoisonBuff; //Field offset: 0x210
	public readonly GainBuff ImmunityPainKiller; //Field offset: 0x218
	public readonly ProbabilityBuff ImmunityAvoidPoisonChance; //Field offset: 0x220
	public readonly ProbabilityBuff ImmunityAvoidMiscEffectsChance; //Field offset: 0x228
	public WeaponSkill Pistol; //Field offset: 0x230
	public WeaponSkill Revolver; //Field offset: 0x238
	public WeaponSkill SMG; //Field offset: 0x240
	public WeaponSkill Assault; //Field offset: 0x248
	public WeaponSkill Shotgun; //Field offset: 0x250
	public WeaponSkill Sniper; //Field offset: 0x258
	public WeaponSkill LMG; //Field offset: 0x260
	public WeaponSkill HMG; //Field offset: 0x268
	public WeaponSkill Launcher; //Field offset: 0x270
	public WeaponSkill AttachedLauncher; //Field offset: 0x278
	public WeaponSkill Misc; //Field offset: 0x280
	public WeaponSkill Melee; //Field offset: 0x288
	public WeaponSkill DMR; //Field offset: 0x290
	public Skill Throwing; //Field offset: 0x298
	public Skill AimDrills; //Field offset: 0x2A0
	public Skill RecoilControl; //Field offset: 0x2A8
	public Skill TroubleShooting; //Field offset: 0x2B0
	public FloatBuff AimMasterSpeed; //Field offset: 0x2B8
	public FloatBuff AimMasterWiggle; //Field offset: 0x2C0
	public BooleanBuff AimMasterElite; //Field offset: 0x2C8
	public FloatBuff RecoilControlImprove; //Field offset: 0x2D0
	public FloatBuff RecoilControlElite; //Field offset: 0x2D8
	public FloatBuff TroubleFixing; //Field offset: 0x2E0
	public BooleanBuff TroubleFixingDurElite; //Field offset: 0x2E8
	public BooleanBuff TroubleFixingMagElite; //Field offset: 0x2F0
	public BooleanBuff TroubleFixingAmmoElite; //Field offset: 0x2F8
	public BooleanBuff TroubleFixingExamineMalfElite; //Field offset: 0x300
	public FloatBuff ThrowingStrengthBuff; //Field offset: 0x308
	public FloatBuff ThrowingEnergyExpenses; //Field offset: 0x310
	public FloatBuff ThrowingSpeedBuff; //Field offset: 0x318
	public BooleanBuff ThrowingEliteBuff; //Field offset: 0x320
	public FloatBuff DrawSpeed; //Field offset: 0x328
	public FloatBuff AimingVolumeReduction; //Field offset: 0x330
	public BooleanBuff DrawElite; //Field offset: 0x338
	public BooleanBuff DrawTremor; //Field offset: 0x340
	public readonly Skill[] Skills; //Field offset: 0x348
	public readonly Skill[] DisplayList; //Field offset: 0x350
	private readonly List _unsubscribers; //Field offset: 0x358
	public readonly Dictionary Mastering; //Field offset: 0x360
	public readonly Dictionary WeaponSkills; //Field offset: 0x368
	[CompilerGenerated]
	private Action OnSkillLevelChanged; //Field offset: 0x370
	[CompilerGenerated]
	private Action WeaponMastered; //Field offset: 0x378
	[CompilerGenerated]
	private Action OnSkillExperienceChanged; //Field offset: 0x380
	[CompilerGenerated]
	private Action OnMasteringExperienceChanged; //Field offset: 0x388
	[CompilerGenerated]
	private Action NewWeaponMastered; //Field offset: 0x390
	public BetterValueBlender NoExpenseAimSkillTimer; //Field offset: 0x398
	public readonly BetterValueBlender FastAimTimer; //Field offset: 0x3A0
	public readonly SkillDependency SprintAction; //Field offset: 0x3A8
	public readonly SkillDependency PushUp; //Field offset: 0x3B0
	public readonly SkillAction ProneAction; //Field offset: 0x3B8
	public readonly SkillDependency MovementAction; //Field offset: 0x3C0
	public readonly SkillAction JumpAction; //Field offset: 0x3C8
	public readonly SkillAction WeaponReloadAction; //Field offset: 0x3D0
	public readonly SkillAction WeaponShotAction; //Field offset: 0x3D8
	public readonly SkillAction WeaponChamberAction; //Field offset: 0x3E0
	public readonly SkillAction WeaponFixAction; //Field offset: 0x3E8
	public readonly SkillAction WeaponDrawAction; //Field offset: 0x3F0
	public readonly SkillAction WeaponAimAction; //Field offset: 0x3F8
	public readonly SkillAction ShotAfterAim; //Field offset: 0x400
	public readonly SkillAction RecoilAction; //Field offset: 0x408
	public readonly SkillAction FistfightAction; //Field offset: 0x410
	public readonly SkillAction ThrowAction; //Field offset: 0x418
	public readonly SkillAction HoldBreathAction; //Field offset: 0x420
	public readonly SkillAction DamageTakenAction; //Field offset: 0x428
	public readonly SkillAction HealthNegativeEffect; //Field offset: 0x430
	public readonly SkillAction LowHPDuration; //Field offset: 0x438
	public readonly SkillAction OnlineAction; //Field offset: 0x440
	public readonly SkillAction UniqueLoot; //Field offset: 0x448
	public readonly SkillAction ExamineAction; //Field offset: 0x450
	public readonly SkillAction ExamineWithInstruction; //Field offset: 0x458
	public readonly SkillAction LockpickAction; //Field offset: 0x460
	public readonly SkillAction RepairAction; //Field offset: 0x468
	public readonly SkillAction FindAction; //Field offset: 0x470
	public readonly SkillAction TradeAction; //Field offset: 0x478
	public readonly SkillAction SearchAction; //Field offset: 0x480
	public readonly SkillAction RaidLoadedAmmoAction; //Field offset: 0x488
	public readonly SkillAction RaidUnloadedAmmoAction; //Field offset: 0x490
	public readonly SkillAction MagazineCheckAction; //Field offset: 0x498
	public readonly SkillAction AnySkillUp; //Field offset: 0x4A0
	public readonly SkillAction SkillProgress; //Field offset: 0x4A8
	public readonly SkillAction HydrationChanged; //Field offset: 0x4B0
	public readonly SkillAction EnergyChanged; //Field offset: 0x4B8
	public readonly SkillAction KillAction; //Field offset: 0x4C0
	public readonly SkillAction SurgeryAction; //Field offset: 0x4C8
	public readonly SkillDependency HideoutCraftTimerAction; //Field offset: 0x4D0
	public readonly SkillAction HideoutCompleteCraftAction; //Field offset: 0x4D8
	public readonly SkillAction HideoutZoneUpgradeAction; //Field offset: 0x4E0
	public readonly SkillAction UniqueCrafting; //Field offset: 0x4E8
	public readonly SkillAction StimulatorNegativeBuff; //Field offset: 0x4F0
	public readonly SkillAction Exhaustion; //Field offset: 0x4F8
	public readonly SkillAction Dehydration; //Field offset: 0x500
	public readonly SkillAction WeaponRepairedAction; //Field offset: 0x508
	public readonly SkillAction LightArmorDamageTakenAction; //Field offset: 0x510
	public readonly SkillAction HeavyArmorDamageTakenAction; //Field offset: 0x518
	public readonly Dictionary ConsumptionActions; //Field offset: 0x520
	[CompilerGenerated]
	private BonusController <BonusController>k__BackingField; //Field offset: 0x528
	[CompilerGenerated]
	private PerkManager <Perks>k__BackingField; //Field offset: 0x530
	public Skill Perception; //Field offset: 0x538
	public Skill Intellect; //Field offset: 0x540
	public Skill Attention; //Field offset: 0x548
	public Skill Immunity; //Field offset: 0x550
	public Skill Charisma; //Field offset: 0x558
	public Skill Memory; //Field offset: 0x560
	public Skill Endurance; //Field offset: 0x568
	public Skill Strength; //Field offset: 0x570
	public Skill Vitality; //Field offset: 0x578
	public Skill Health; //Field offset: 0x580
	public Skill Metabolism; //Field offset: 0x588
	public Skill StressResistance; //Field offset: 0x590
	public Skill Sniping; //Field offset: 0x598
	public Skill CovertMovement; //Field offset: 0x5A0
	public Skill ProneMovement; //Field offset: 0x5A8
	public Skill LightVests; //Field offset: 0x5B0
	public Skill HeavyVests; //Field offset: 0x5B8
	public Skill WeaponModding; //Field offset: 0x5C0
	public Skill AdvancedModding; //Field offset: 0x5C8
	public Skill Lockpicking; //Field offset: 0x5D0
	public Skill Surgery; //Field offset: 0x5D8
	public Skill Search; //Field offset: 0x5E0
	public Skill WeaponTreatment; //Field offset: 0x5E8
	public Skill MagDrills; //Field offset: 0x5F0
	public Skill Freetrading; //Field offset: 0x5F8
	public Skill Barter; //Field offset: 0x600
	public Skill Crafting; //Field offset: 0x608
	public Skill HideoutManagement; //Field offset: 0x610
	public readonly FloatBuff CovertMovementSoftSurfaceReduction; //Field offset: 0x618
	public readonly FloatBuff CovertMovementEquipment; //Field offset: 0x620
	public readonly FloatBuff CovertMovementSpeed; //Field offset: 0x628
	public readonly BooleanBuff CovertMovementElite; //Field offset: 0x630
	public readonly FloatBuff CovertMovementHardSurfaceReduction; //Field offset: 0x638
	public readonly FloatBuff ProneMovementSpeed; //Field offset: 0x640
	public readonly FloatBuff ProneMovementVolume; //Field offset: 0x648
	public readonly BooleanBuff ProneMovementEliteSprint; //Field offset: 0x650
	public readonly FloatBuff SearchBuffSpeed; //Field offset: 0x658
	public readonly BooleanBuff SearchDouble; //Field offset: 0x660
	public readonly FloatBuff SurgeryReducePenalty; //Field offset: 0x668
	public readonly FloatBuff SurgerySpeed; //Field offset: 0x670
	public readonly FloatBuff HideoutResourceConsumption; //Field offset: 0x678
	public readonly FloatBuff ZoneBonusBoost; //Field offset: 0x680
	public readonly BooleanBuff HideoutExtraSlots; //Field offset: 0x688
	public readonly FloatBuff SingleCraftTimeReduce; //Field offset: 0x690
	public readonly FloatBuff ContinueCraftTimeReduce; //Field offset: 0x698
	public readonly BooleanBuff EliteCrafting; //Field offset: 0x6A0
	public readonly FloatBuff WeaponDurabilityLosOnShotReduce; //Field offset: 0x6A8
	public readonly FloatBuff WearAmountRepairGunsReducePerLevel; //Field offset: 0x6B0
	public readonly BooleanBuff WearChanceRepairGunsReduceEliteLevel; //Field offset: 0x6B8
	public readonly FloatBuff LightVestMoveSpeedPenaltyReduction; //Field offset: 0x6C0
	public readonly FloatBuff LightVestMeleeWeaponDamageReduction; //Field offset: 0x6C8
	public readonly FloatBuff LightVestRepairDegradationReduction; //Field offset: 0x6D0
	public readonly BooleanBuff LightVestBleedingProtection; //Field offset: 0x6D8
	public readonly BooleanBuff LightVestDeteriorationChanceOnRepairReduce; //Field offset: 0x6E0
	public readonly FloatBuff HeavyVestMoveSpeedPenaltyReduction; //Field offset: 0x6E8
	public readonly FloatBuff HeavyVestBluntThroughputDamageReduction; //Field offset: 0x6F0
	public readonly FloatBuff HeavyVestRepairDegradationReduction; //Field offset: 0x6F8
	public readonly BooleanBuff HeavyVestNoBodyDamageDeflectChance; //Field offset: 0x700
	public readonly BooleanBuff HeavyVestDeteriorationChanceOnRepairReduce; //Field offset: 0x708
	public Skill BearAssaultoperations; //Field offset: 0x710
	public Skill BearAuthority; //Field offset: 0x718
	public Skill BearAksystems; //Field offset: 0x720
	public Skill BearHeavycaliber; //Field offset: 0x728
	public Skill BearRawpower; //Field offset: 0x730
	public Skill UsecArsystems; //Field offset: 0x738
	public Skill UsecDeepweaponmodding; //Field offset: 0x740
	public Skill UsecLongrangeoptics; //Field offset: 0x748
	public Skill UsecNegotiations; //Field offset: 0x750
	public Skill UsecTactics; //Field offset: 0x758
	public Skill BotReload; //Field offset: 0x760
	public Skill BotSoundGoef; //Field offset: 0x768
	public FloatBuff BotReloadSpeed; //Field offset: 0x770
	public FloatBuff BotSoundCoef; //Field offset: 0x778

	public event Action NewWeaponMastered
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnMasteringExperienceChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSkillExperienceChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSkillLevelChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action WeaponMastered
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override float AttentionEliteLuckySearchValue
	{
		 get { } //Length: 31
	}

	public override float AttentionExamineValue
	{
		 get { } //Length: 31
	}

	public override float AttentionLootSpeedValue
	{
		 get { } //Length: 31
	}

	public private BonusController BonusController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float CarryingWeightRelativeModifier
	{
		 get { } //Length: 36
	}

	public override bool IsMagDrillsInstantCheck
	{
		 get { } //Length: 30
	}

	public override bool IsSearchDouble
	{
		 get { } //Length: 30
	}

	public override bool IsTroubleFixingExamineMalfElite
	{
		 get { } //Length: 30
	}

	public override int MagDrillsLevel
	{
		 get { } //Length: 70
	}

	public private PerkManager Perks
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override float SearchBuffSpeedValue
	{
		 get { } //Length: 31
	}

	public GlobalSkillsSettings Settings
	{
		 get { } //Length: 64
	}

	private SkillManager() { }

	public SkillManager(SkillsDescriptor descriptor) { }

	[CompilerGenerated]
	private bool <CreateCombat>b__109_0(Item _) { }

	[CompilerGenerated]
	private float <CreatePractical>b__303_0(float craftTime) { }

	[CompilerGenerated]
	private float <CreatePractical>b__303_1(MovementParams movement) { }

	[CompilerGenerated]
	public void add_NewWeaponMastered(Action value) { }

	[CompilerGenerated]
	public void add_OnMasteringExperienceChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSkillExperienceChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSkillLevelChanged(Action value) { }

	[CompilerGenerated]
	public void add_WeaponMastered(Action value) { }

	public void ApplyChanges(SkillManager skillManager) { }

	private void BotSkillset() { }

	public double CalculateCharismaInsuranceDiscount(TraderInfo traderInfo) { }

	public void ChangeMasteringLevel(string weaponTemplateId, float value, bool silent = false) { }

	private void CreateCombat() { }

	private void CreateMental() { }

	private void CreatePhysical() { }

	private void CreatePractical() { }

	private void CreateWeaponSkillsDict() { }

	public override float get_AttentionEliteLuckySearchValue() { }

	public override float get_AttentionExamineValue() { }

	public override float get_AttentionLootSpeedValue() { }

	[CompilerGenerated]
	public BonusController get_BonusController() { }

	public float get_CarryingWeightRelativeModifier() { }

	public override bool get_IsMagDrillsInstantCheck() { }

	public override bool get_IsSearchDouble() { }

	public override bool get_IsTroubleFixingExamineMalfElite() { }

	public override int get_MagDrillsLevel() { }

	[CompilerGenerated]
	public PerkManager get_Perks() { }

	public override float get_SearchBuffSpeedValue() { }

	public GlobalSkillsSettings get_Settings() { }

	private Skill[] GetBearSpecial() { }

	public float GetBuffedGrenadeExpense(float raw) { }

	public float GetEffectiveness(int skillPointsEarned) { }

	public GrenadeBuffsInfo GetGrenadeInfo(Item grenade, bool isAI) { }

	[CanBeNull]
	public Mastering GetMastering(string templateId) { }

	[CanBeNull]
	public Mastering GetMasteringGroup(string groupId) { }

	public Skill GetSkill(ESkillId skillId) { }

	private Skill[] GetUsecSpecial() { }

	public Buff[] GetWeaponBuffs(Type ofType) { }

	public WeaponBuffsInfo GetWeaponInfo(Item weapon) { }

	public int GetWeaponKillCount(string weaponTemplateId) { }

	public void Init(BonusController bonusController, PerkManager perkManager = null) { }

	public static MasteringGroup MasteringGroup(string templateId) { }

	public Mastering MasterNewWeapon(MasteringGroup group, float progress = 0, int killCount = 0) { }

	public void OnWeaponDraw(Item item) { }

	public void RefreshPerkDependentState() { }

	[CompilerGenerated]
	public void remove_NewWeaponMastered(Action value) { }

	[CompilerGenerated]
	public void remove_OnMasteringExperienceChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSkillExperienceChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSkillLevelChanged(Action value) { }

	[CompilerGenerated]
	public void remove_WeaponMastered(Action value) { }

	[CompilerGenerated]
	private void set_BonusController(BonusController value) { }

	[CompilerGenerated]
	private void set_Perks(PerkManager value) { }

	public void StartClientMode() { }

	public void Terminate() { }

	public bool TryGetSkill(ESkillId skillId, out Skill skill) { }

}

