namespace EFT.Hideout;

public class AirFilteringUnitBehaviour : AreaBehaviour, IConsumer, IUpdate, IHideoutStart, IEnergyDependentBehaviour, IConsumerAreaBehaviour
{
	[CompilerGenerated]
	private Action OnConsumableItemChanged; //Field offset: 0x68
	private ResourceConsumer _resourceConsumer; //Field offset: 0x70

	public override event Action OnConsumableItemChanged
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

	public override ResourceConsumer ResourceConsumer
	{
		 get { } //Length: 175
	}

	public override BarterItem[] UsingItems
	{
		 get { } //Length: 30
	}

	public AirFilteringUnitBehaviour() { }

	[CompilerGenerated]
	public override void add_OnConsumableItemChanged(Action value) { }

	public override void EnergyGenerationChanged(bool isOn) { }

	public override bool get_Changeable() { }

	public override float get_Consumption() { }

	public override float get_ConsumptionReduction() { }

	public override ResourceConsumer get_ResourceConsumer() { }

	public override BarterItem[] get_UsingItems() { }

	public virtual void Init(AreaData area, AreaInfo profileInfo, InventoryController inventoryController, IEftSession session) { }

	public override void InstallConsumableItems(BarterItem[] installedSupplies) { }

	protected virtual void LevelUpdatedHandler() { }

	private void OnItemResourceEndedHandler(Item item, int index) { }

	private void OnStatusChangedHandler() { }

	[CompilerGenerated]
	public override void remove_OnConsumableItemChanged(Action value) { }

	public override void Start(float profileDecayTime) { }

	public override void Update(float deltaTime) { }

	private void UpdateConsumptionData() { }

	private void UpdateSlotsData() { }

}

