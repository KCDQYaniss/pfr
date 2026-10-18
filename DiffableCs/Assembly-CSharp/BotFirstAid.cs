//Type is in global namespace

public class BotFirstAid : BotAbstractMedsToPart
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__39_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RefreshMeds>b__39_0(MedKit kit) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public BotFirstAid <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18
		public Callback <>9__1; //Field offset: 0x20

		public <>c__DisplayClass42_0() { }

		internal void <ApplyToSelf>b__0(Result hands) { }

		internal void <ApplyToSelf>b__1(Result applyResult) { }

	}

	private static readonly EDamageEffectType[] bleeds; //Field offset: 0x0
	protected float _lastEndTime; //Field offset: 0x50
	private bool _shallUseInSafe; //Field offset: 0x54
	private bool _isBleedingLight; //Field offset: 0x55
	private bool _isBleedingHeavy; //Field offset: 0x56
	private bool _errorPrinted; //Field offset: 0x57
	[CompilerGenerated]
	private Action OnNoDamagedParts; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnStartApply; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnEndApply; //Field offset: 0x68
	[CompilerGenerated]
	private bool <Damaged>k__BackingField; //Field offset: 0x70

	public event Action OnEndApply
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnNoDamagedParts
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnStartApply
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool Damaged
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool Have2Do
	{
		 get { } //Length: 38
	}

	public bool IsBleeding
	{
		 get { } //Length: 13
	}

	public float LastEndTime
	{
		 get { } //Length: 6
	}

	protected override float min_percent
	{
		 get { } //Length: 9
	}

	private static BotFirstAid() { }

	public BotFirstAid(BotOwner owner, Action callback) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public void add_OnEndApply(Action value) { }

	[CompilerGenerated]
	public void add_OnNoDamagedParts(Action value) { }

	[CompilerGenerated]
	public void add_OnStartApply(Action value) { }

	private void ApplyToSelf(Nullable varianAnim = null, Action callback = null) { }

	private bool CanHealDamageEffectType(Meds med, EDamageEffectType damageEffectType) { }

	private bool CanUseByTime() { }

	public void CheckParts() { }

	public virtual void Dispose() { }

	protected override void FindDamagedPart() { }

	protected override void FirstAidApplied() { }

	[CompilerGenerated]
	public bool get_Damaged() { }

	public bool get_Have2Do() { }

	public bool get_IsBleeding() { }

	public float get_LastEndTime() { }

	protected override float get_min_percent() { }

	public void GetDamaged() { }

	public float GetHpPercent(EBodyPart percent) { }

	public bool IsPartDamaged(EBodyPart partType) { }

	public void Refresh() { }

	protected override void RefreshMeds() { }

	[CompilerGenerated]
	public void remove_OnEndApply(Action value) { }

	[CompilerGenerated]
	public void remove_OnNoDamagedParts(Action value) { }

	[CompilerGenerated]
	public void remove_OnStartApply(Action value) { }

	[CompilerGenerated]
	public void set_Damaged(bool value) { }

	public override void SetRandomPartToHeal() { }

	public bool ShallStartUse() { }

	private void StopUse() { }

	public void TryApplyToCurrentPart(Nullable varianAnim = null, Action callback = null) { }

}

