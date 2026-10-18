namespace EFT.Hideout;

public interface IConsumer
{

	public event Action OnConsumableItemChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool Changeable
	{
		 get { } //Length: 0
	}

	public float Consumption
	{
		 get { } //Length: 0
	}

	public float ConsumptionReduction
	{
		 get { } //Length: 0
	}

	public AdditionalSlotsBonus Slots
	{
		 get { } //Length: 0
	}

	public BarterItem[] UsingItems
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnConsumableItemChanged(Action value) { }

	public bool get_Changeable() { }

	public float get_Consumption() { }

	public float get_ConsumptionReduction() { }

	public AdditionalSlotsBonus get_Slots() { }

	public BarterItem[] get_UsingItems() { }

	public void InstallConsumableItems(BarterItem[] installedSupplies) { }

	[CompilerGenerated]
	public void remove_OnConsumableItemChanged(Action value) { }

}

