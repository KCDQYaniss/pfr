//Type is in global namespace

public class Stamina
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public Stamina <>4__this; //Field offset: 0x10
		public Consumption consumption; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

		internal void <AddConsumption>b__0() { }

	}

	public const float EXHAUSTED_THRESHOLD = 15; //Field offset: 0x0
	public float Current; //Field offset: 0x10
	public float Overuse; //Field offset: 0x14
	public readonly Compute TotalCapacity; //Field offset: 0x18
	public readonly Compute SelfRestoration; //Field offset: 0x20
	public float DisableRestoration; //Field offset: 0x28
	public BindableList Consumptions; //Field offset: 0x30
	[CompilerGenerated]
	private float <BuffRestoration>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <ConsumptionMultiplier>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <Multiplier>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnExpired; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnThresholdPass; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnChanged; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnValueChanged; //Field offset: 0x60
	private bool _forceMode; //Field offset: 0x68
	private int _lastOnValueChanged; //Field offset: 0x6C

	public event Action OnChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnExpired
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnThresholdPass
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public float BuffRestoration
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float ConsumptionMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	private float ExcessiveUsePenalty
	{
		private get { } //Length: 31
	}

	public bool Exhausted
	{
		 get { } //Length: 16
	}

	public bool ForceMode
	{
		 get { } //Length: 5
		 set { } //Length: 11
	}

	public float Multiplier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float NormalValue
	{
		 get { } //Length: 103
	}

	public Stamina(Compute capacityFunc, Compute restorationFunc) { }

	[CompilerGenerated]
	public void add_OnChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnExpired(Action value) { }

	[CompilerGenerated]
	public void add_OnThresholdPass(Action value) { }

	[CompilerGenerated]
	public void add_OnValueChanged(Action value) { }

	public Action AddConsumption(Consumption consumption) { }

	public bool CanAdd(Consumption consumption) { }

	public float Consume(Consumption consumption, bool fromDamage = false) { }

	[CompilerGenerated]
	public float get_BuffRestoration() { }

	[CompilerGenerated]
	public float get_ConsumptionMultiplier() { }

	private float get_ExcessiveUsePenalty() { }

	public bool get_Exhausted() { }

	public bool get_ForceMode() { }

	[CompilerGenerated]
	public float get_Multiplier() { }

	public float get_NormalValue() { }

	public void HandleExpiration() { }

	public void InvokeChangedAction() { }

	public void Process(float dt) { }

	[CompilerGenerated]
	public void remove_OnChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnExpired(Action value) { }

	[CompilerGenerated]
	public void remove_OnThresholdPass(Action value) { }

	[CompilerGenerated]
	public void remove_OnValueChanged(Action value) { }

	public void RemoveConsumption(Consumption consumption) { }

	[CompilerGenerated]
	public void set_BuffRestoration(float value) { }

	[CompilerGenerated]
	public void set_ConsumptionMultiplier(float value) { }

	public void set_ForceMode(bool value) { }

	[CompilerGenerated]
	public void set_Multiplier(float value) { }

	public void UpdateStamina(float stamina) { }

}

