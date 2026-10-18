namespace EFT.UI.HealthTreatment;

public sealed class TreatmentWrapper : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public TreatmentWrapper <>4__this; //Field offset: 0x10
		public HealthEffectObserver effectObserver; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <.ctor>b__0(OfflineHealthController healthController, TraderInfo traderInfo, HealthTreatmentView viewInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public TreatmentWrapper <>4__this; //Field offset: 0x10
		public IHealthFactorObserver factorObserver; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal void <.ctor>b__0(OfflineHealthController healthController, TraderInfo traderInfo, HealthTreatmentView viewInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public TreatmentWrapper <>4__this; //Field offset: 0x10
		public Action handler; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <Subscribe>b__0() { }

	}

	private sealed class TreatmentsComparer : IComparer
	{
		public static readonly TreatmentsComparer Instance; //Field offset: 0x0

		private static TreatmentsComparer() { }

		private TreatmentsComparer() { }

		public override int Compare(TreatmentWrapper item1, TreatmentWrapper item2) { }

	}

	public BindableEvent OnSelect; //Field offset: 0x10
	public readonly Action ShowViewAction; //Field offset: 0x18
	private readonly Type _effectType; //Field offset: 0x20
	private readonly EHealthFactorType _factorType; //Field offset: 0x28
	[CompilerGenerated]
	private Action _onChange; //Field offset: 0x30
	private HealthTreatmentView _viewInstance; //Field offset: 0x38
	private bool _selected; //Field offset: 0x40
	private IHealthObserver _healthObserver; //Field offset: 0x48
	[CompilerGenerated]
	private HealthTreatmentView <TreatmentView>k__BackingField; //Field offset: 0x50

	private event Action _onChange
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public bool Active
	{
		 get { } //Length: 78
	}

	public static IComparer Comparer
	{
		 get { } //Length: 83
	}

	public float CurrentTreatmentCost
	{
		 get { } //Length: 78
	}

	public IHealthObserver Observer
	{
		 get { } //Length: 5
	}

	public private bool Selected
	{
		 get { } //Length: 5
		private set { } //Length: 42
	}

	public private HealthTreatmentView TreatmentView
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private HealthTreatmentView ViewInstance
	{
		private get { } //Length: 5
		private set { } //Length: 251
	}

	public TreatmentWrapper(IHealthFactorObserver factorObserver, HealthTreatmentFactorView view) { }

	public TreatmentWrapper(HealthEffectObserver effectObserver, HealthTreatmentEffectView view) { }

	[CompilerGenerated]
	private void <set_ViewInstance>b__28_0(bool selected) { }

	[CompilerGenerated]
	private void add__onChange(Action value) { }

	public void Apply() { }

	public override void Dispose() { }

	public bool get_Active() { }

	public static IComparer get_Comparer() { }

	public float get_CurrentTreatmentCost() { }

	public IHealthObserver get_Observer() { }

	public bool get_Selected() { }

	[CompilerGenerated]
	public HealthTreatmentView get_TreatmentView() { }

	private HealthTreatmentView get_ViewInstance() { }

	private void Init(IHealthObserver effectObserver, HealthTreatmentView view) { }

	private void OnChangeHandler() { }

	[CompilerGenerated]
	private void remove__onChange(Action value) { }

	public void Select(bool selected) { }

	private void set_Selected(bool value) { }

	[CompilerGenerated]
	private void set_TreatmentView(HealthTreatmentView value) { }

	private void set_ViewInstance(HealthTreatmentView value) { }

	public void Store(HealthTreatmentData treatmentData, out float cost) { }

	public Action Subscribe(Action handler) { }

	public void Unsubscribe(Action handler) { }

}

