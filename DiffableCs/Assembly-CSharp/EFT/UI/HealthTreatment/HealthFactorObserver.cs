namespace EFT.UI.HealthTreatment;

public abstract class HealthFactorObserver : IHealthFactorObserver, IHealthObserver, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public HealthFactorObserver <>4__this; //Field offset: 0x10
		public Action handler; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <Subscribe>b__0() { }

	}

	[CompilerGenerated]
	private Action _onChange; //Field offset: 0x10
	[CompilerGenerated]
	private string <TreatmentName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <ValueToHeal>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <TreatmentCost>k__BackingField; //Field offset: 0x24
	protected OfflineHealthController HealthController; //Field offset: 0x28
	private Profile _profile; //Field offset: 0x30
	private TraderInfo _traderInfo; //Field offset: 0x38

	private event Action _onChange
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public override bool Active
	{
		 get { } //Length: 102
	}

	public abstract EHealthFactorType FactorType
	{
		 get { } //Length: 0
	}

	protected abstract float HealPrice
	{
		 get { } //Length: 0
	}

	protected static HealPriceSettings PriceSettings
	{
		 get { } //Length: 73
	}

	public private override float TreatmentCost
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private override string TreatmentName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override float ValueToHeal
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	protected HealthFactorObserver() { }

	[CompilerGenerated]
	private void add__onChange(Action value) { }

	public override void ApplyTreatment() { }

	protected void ChangeHandler() { }

	public override IHealthFactorObserver Clone(Profile profile, OfflineHealthController healthController, TraderInfo traderInfo) { }

	public abstract void Dispose() { }

	public override bool get_Active() { }

	public abstract EHealthFactorType get_FactorType() { }

	protected abstract float get_HealPrice() { }

	protected static HealPriceSettings get_PriceSettings() { }

	[CompilerGenerated]
	public override float get_TreatmentCost() { }

	[CompilerGenerated]
	public override string get_TreatmentName() { }

	[CompilerGenerated]
	public override float get_ValueToHeal() { }

	protected abstract float GetValueToHeal() { }

	private void Init(Profile profile, OfflineHealthController healthController, TraderInfo traderInfo) { }

	protected abstract void Init() { }

	[CompilerGenerated]
	private void remove__onChange(Action value) { }

	[CompilerGenerated]
	private void set_TreatmentCost(float value) { }

	[CompilerGenerated]
	private void set_TreatmentName(string value) { }

	[CompilerGenerated]
	private void set_ValueToHeal(float value) { }

	public abstract void Store(HealthTreatmentData treatmentData, out float cost) { }

	public override Action Subscribe(Action handler) { }

	public override void Unsubscribe(Action handler) { }

	private void Update() { }

}

