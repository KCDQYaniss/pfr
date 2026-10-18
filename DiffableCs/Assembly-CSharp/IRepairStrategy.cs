//Type is in global namespace

public interface IRepairStrategy
{

	public IRepairer CurrentRepairer
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IEnumerable Repairers
	{
		 get { } //Length: 0
	}

	public List RepairKitsCollections
	{
		 get { } //Length: 0
	}

	public void AddRepairKitToRepairers(RepairKit repairKit) { }

	public bool BrokenItemError() { }

	public bool CanRepair(IRepairer repairer, MongoID[] excludedCategories) { }

	public float Durability() { }

	public IRepairer get_CurrentRepairer() { }

	public IEnumerable get_Repairers() { }

	public List get_RepairKitsCollections() { }

	public ValueTuple GetBuffState() { }

	public int GetCurrencyPrice(float amount) { }

	public float GetCurrentDurabilityFraction() { }

	public Vector2 GetDegradationValues(float repairAmount) { }

	public float GetMaxDurabilityFraction() { }

	public double GetPriceRate() { }

	public double GetRepairPrice(float repairValue, RepairKitsCollection repairKit) { }

	public float GetRepairQuality() { }

	public float GetRepairQualityForDisplay() { }

	public float HowMuchRepairScoresCanAccept() { }

	public bool IsEligibleForBuff() { }

	public bool IsNoCorrespondingArea() { }

	public float MaxDurability() { }

	public string RepairabilityText(bool isRepairKit) { }

	public Task RepairItem(float repairAmount, RepairKit draggedRepairKit) { }

	public void set_CurrentRepairer(IRepairer value) { }

	public int TemplateDurability() { }

	public bool TryGetEnhancementChance(float repairAmount, out double enhancementChance) { }

}

