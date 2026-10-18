namespace EFT.UI.HealthTreatment;

public sealed class HealthEffectObserver : IHealthObserver, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public HealthEffectObserver <>4__this; //Field offset: 0x10
		public Action handler; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal void <Subscribe>b__0() { }

	}

	[CompilerGenerated]
	private readonly Type <EffectType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <TreatmentName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <TreatmentCost>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List <Effects>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly TraderInfo <TraderInfo>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly Profile <Profile>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly OfflineHealthController <HealthController>k__BackingField; //Field offset: 0x40
	private float _healPrice; //Field offset: 0x48
	[CompilerGenerated]
	private Action _onChange; //Field offset: 0x50

	private event Action _onChange
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public override bool Active
	{
		 get { } //Length: 63
	}

	public private List Effects
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Type EffectType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override EHealthFactorType FactorType
	{
		 get { } //Length: 6
	}

	private OfflineHealthController HealthController
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	private static HealPriceSettings PriceSettings
	{
		private get { } //Length: 73
	}

	private Profile Profile
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	private TraderInfo TraderInfo
	{
		[CompilerGenerated]
		private get { } //Length: 76
	}

	public private override float TreatmentCost
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public override string TreatmentName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public HealthEffectObserver(Type effectType, Profile profile, OfflineHealthController healthController, TraderInfo traderInfo) { }

	[CompilerGenerated]
	private void add__onChange(Action value) { }

	public override void ApplyTreatment() { }

	private bool CheckEffect(IHealthEffect effect) { }

	public override void Dispose() { }

	public override bool get_Active() { }

	[CompilerGenerated]
	public List get_Effects() { }

	[CompilerGenerated]
	public Type get_EffectType() { }

	public override EHealthFactorType get_FactorType() { }

	[CompilerGenerated]
	private OfflineHealthController get_HealthController() { }

	private static HealPriceSettings get_PriceSettings() { }

	[CompilerGenerated]
	private Profile get_Profile() { }

	[CompilerGenerated]
	private TraderInfo get_TraderInfo() { }

	[CompilerGenerated]
	public override float get_TreatmentCost() { }

	[CompilerGenerated]
	public override string get_TreatmentName() { }

	private void OnEffectChanged(IHealthEffect effect) { }

	[CompilerGenerated]
	private void remove__onChange(Action value) { }

	[CompilerGenerated]
	private void set_Effects(List value) { }

	[CompilerGenerated]
	private void set_TreatmentCost(float value) { }

	public override void Store(HealthTreatmentData treatmentData, out float cost) { }

	public override Action Subscribe(Action handler) { }

	public override void Unsubscribe(Action handler) { }

	private void Update() { }

}

