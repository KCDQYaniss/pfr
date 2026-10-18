namespace EFT.Hideout;

public class GeneratorBehaviour : AreaBehaviour, IConsumer, IGenerator, IHideoutStart, IDisposable, IConsumerAreaBehaviour
{
	private const int WARNING_THRESHOLD_PERCENTAGE = 5; //Field offset: 0x0
	public static readonly BindableEvent OnGeneratorInstalledHandler; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsGeneratorInstalled>k__BackingField; //Field offset: 0x8
	private static AreaDetailsData _fuelDetails; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnConsumableItemChanged; //Field offset: 0x68
	[CompilerGenerated]
	private Action OnWorkingStateChanged; //Field offset: 0x70
	private HideoutNotification _fuelAlertNotification; //Field offset: 0x78
	private HideoutNotification _emptyFuelNotification; //Field offset: 0x80
	private ResourceConsumer _resourceConsumer; //Field offset: 0x88
	private bool _isWorking; //Field offset: 0x90

	public override event Action OnConsumableItemChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnWorkingStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override bool Changeable
	{
		 get { } //Length: 39
	}

	public override float Consumption
	{
		 get { } //Length: 44
	}

	public override float ConsumptionReduction
	{
		 get { } //Length: 31
	}

	public static AreaDetailsData FuelDetails
	{
		 get { } //Length: 270
	}

	public virtual bool HasError
	{
		 get { } //Length: 49
	}

	public private static bool IsGeneratorInstalled
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		private set { } //Length: 89
	}

	public private override bool IsWorking
	{
		 get { } //Length: 8
		private set { } //Length: 74
	}

	public override ResourceConsumer ResourceConsumer
	{
		 get { } //Length: 175
	}

	public bool SwitchedOn
	{
		 get { } //Length: 30
	}

	public override BarterItem[] UsingItems
	{
		 get { } //Length: 30
	}

	private static GeneratorBehaviour() { }

	public GeneratorBehaviour() { }

	[CompilerGenerated]
	public override void add_OnConsumableItemChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnWorkingStateChanged(Action value) { }

	private void BonusChangedHandler(bool isActive, EBonusType bonusType) { }

	public override void Dispose() { }

	public override bool get_Changeable() { }

	public override float get_Consumption() { }

	public override float get_ConsumptionReduction() { }

	public static AreaDetailsData get_FuelDetails() { }

	public virtual bool get_HasError() { }

	[CompilerGenerated]
	public static bool get_IsGeneratorInstalled() { }

	public override bool get_IsWorking() { }

	public override ResourceConsumer get_ResourceConsumer() { }

	public bool get_SwitchedOn() { }

	public override BarterItem[] get_UsingItems() { }

	public virtual void Init(AreaData area, AreaInfo profileInfo, InventoryController inventoryController, IEftSession session) { }

	protected virtual void Init(AreaData data) { }

	public override void InstallConsumableItems(BarterItem[] installedSupplies) { }

	protected virtual void LevelUpdatedHandler() { }

	private void OnStatusChangedHandler() { }

	[CompilerGenerated]
	public override void remove_OnConsumableItemChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnWorkingStateChanged(Action value) { }

	[CompilerGenerated]
	private static void set_IsGeneratorInstalled(bool value) { }

	private void set_IsWorking(bool value) { }

	public override void SetSwitchedStatus(bool isOn) { }

	public override void Start(float profileDecayTime) { }

	private void UpdateConsumptionData() { }

	private void UpdateDetails() { }

	private void UpdateSlotsData() { }

	public override bool Work(float deltaTime) { }

}

