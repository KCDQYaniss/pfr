namespace EFT.Repairing;

public interface IRepairer
{

	public float CurrencyCoefficient
	{
		 get { } //Length: 0
	}

	public string LocalizedName
	{
		 get { } //Length: 0
	}

	public int LoyaltyLevel
	{
		 get { } //Length: 0
	}

	public int MaxLoyaltyLevel
	{
		 get { } //Length: 0
	}

	public string RepairerId
	{
		 get { } //Length: 0
	}

	public double Standing
	{
		 get { } //Length: 0
	}

	public MongoID[] Targets
	{
		 get { } //Length: 0
	}

	public float get_CurrencyCoefficient() { }

	public string get_LocalizedName() { }

	public int get_LoyaltyLevel() { }

	public int get_MaxLoyaltyLevel() { }

	public string get_RepairerId() { }

	public double get_Standing() { }

	public MongoID[] get_Targets() { }

	public Task GetAndAssignAvatar(Image image, CancellationToken cancellationToken) { }

	public Vector2 GetDegradationValues(RepairableComponent repairable, Item item) { }

	public double GetRepairPriceCoefficient(Item item) { }

	public float GetRepairQuality(Item item) { }

	public Task RepairItems(RepairItem repairItems, RepairKit draggedRepairKit = null) { }

	public bool TryGetEnhancementChance(Item item, float receiveDurabilityPercent, out double enhancementChance) { }

}

