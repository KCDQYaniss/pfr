namespace EFT;

public sealed class BonusController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__31_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <ToDescriptor>b__31_0(BonusCollection bonus) { }

	}

	[CompilerGenerated]
	private sealed class <get_ActiveBonuses>d__15 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EBonusType <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public BonusController <>4__this; //Field offset: 0x20
		private Enumerator <>7__wrap1; //Field offset: 0x28

		private override EBonusType System.Collections.Generic.IEnumerator<EFT.EBonusType>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <get_ActiveBonuses>d__15(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.EBonusType>.GetEnumerator() { }

		[DebuggerHidden]
		private override EBonusType System.Collections.Generic.IEnumerator<EFT.EBonusType>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetAttachedBonuses>d__30 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Bonus <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public BonusController <>4__this; //Field offset: 0x28
		private EAreaType areaType; //Field offset: 0x30
		public EAreaType <>3__areaType; //Field offset: 0x34
		private Enumerator <>7__wrap1; //Field offset: 0x38

		private override Bonus System.Collections.Generic.IEnumerator<EFT.Bonus>.Current
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
		public <GetAttachedBonuses>d__30(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Bonus>.GetEnumerator() { }

		[DebuggerHidden]
		private override Bonus System.Collections.Generic.IEnumerator<EFT.Bonus>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class BonusCollection
	{
		[CompilerGenerated]
		private sealed class <ToDescriptors>d__14 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private BonusDescriptor <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x20
			public BonusCollection <>4__this; //Field offset: 0x28
			private Enumerator <>7__wrap1; //Field offset: 0x30

			private override BonusDescriptor System.Collections.Generic.IEnumerator<EFT.BonusDescriptor>.Current
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
			public <ToDescriptors>d__14(int <>1__state) { }

			private void <>m__Finally1() { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.Generic.IEnumerable<EFT.BonusDescriptor>.GetEnumerator() { }

			[DebuggerHidden]
			private override BonusDescriptor System.Collections.Generic.IEnumerator<EFT.BonusDescriptor>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private readonly List _bonuses; //Field offset: 0x10
		[CompilerGenerated]
		private Bonus <Result>k__BackingField; //Field offset: 0x18

		public private Bonus Result
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public BonusCollection(Bonus bonus) { }

		public void Add(Bonus bonus) { }

		private void CalculateResult() { }

		public double CalculateValue(double input) { }

		[CompilerGenerated]
		public Bonus get_Result() { }

		private void HandleBoost() { }

		public bool HasBonus() { }

		public void Remove(Bonus bonus) { }

		[CompilerGenerated]
		private void set_Result(Bonus value) { }

		public void SetBoost(double boostValue) { }

		[IteratorStateMachine(typeof(<ToDescriptors>d__14))]
		public IEnumerable ToDescriptors() { }

		private bool TryGetBonus(MongoID id, out Bonus bonus) { }

	}

	[CompilerGenerated]
	private Action OnBonusChanged; //Field offset: 0x10
	private readonly Dictionary _activeBonuses; //Field offset: 0x18
	private readonly List _seasonalBonuses; //Field offset: 0x20
	private readonly HashSet _seasonalBonusIds; //Field offset: 0x28
	private SkillManager _skillManager; //Field offset: 0x30
	[CompilerGenerated]
	private string <StashTemplateId>k__BackingField; //Field offset: 0x38

	public event Action OnBonusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	[JsonIgnore]
	public IEnumerable ActiveBonuses
	{
		[IteratorStateMachine(typeof(<get_ActiveBonuses>d__15))]
		 get { } //Length: 175
	}

	private float BoostValue
	{
		private get { } //Length: 48
	}

	[JsonIgnore]
	public private string StashTemplateId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BonusController(IEnumerable bonuses, SkillManager skillManager) { }

	[CompilerGenerated]
	private bool <ToDescriptor>b__31_1(BonusDescriptor descriptor) { }

	[CompilerGenerated]
	public void add_OnBonusChanged(Action value) { }

	public void AddBonus(Bonus bonus, bool silent = false) { }

	public void AddSeasonalBonus(Bonus bonus, bool silent = true) { }

	private double Calculate(Enum type, double input) { }

	public double Calculate(EBonusType type, double input) { }

	public double Calculate(Skill skill, double input) { }

	public void ClearSeasonalBonuses(bool silent = true) { }

	[IteratorStateMachine(typeof(<get_ActiveBonuses>d__15))]
	public IEnumerable get_ActiveBonuses() { }

	private float get_BoostValue() { }

	[CompilerGenerated]
	public string get_StashTemplateId() { }

	[IteratorStateMachine(typeof(<GetAttachedBonuses>d__30))]
	public IEnumerable GetAttachedBonuses(EAreaType areaType) { }

	private void HandleBonusBoost(Bonus bonus) { }

	public bool HasBonus(EBonusType type) { }

	private void InitSkillManager(SkillManager skillManager) { }

	[CompilerGenerated]
	public void remove_OnBonusChanged(Action value) { }

	public void RemoveBonus(Bonus bonus, bool silent = false) { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_StashTemplateId(string value) { }

	private void SetBoost() { }

	public static void SetSingleton(BonusController bonusController) { }

	private void SkillLevelChangedHandler(BaseSkill baseSkill) { }

	public BonusDescriptor[] ToDescriptor() { }

}

