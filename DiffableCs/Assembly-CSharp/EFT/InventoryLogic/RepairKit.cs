namespace EFT.InventoryLogic;

public class RepairKit : SpecItem
{
	[Component]
	[JsonProperty("RepairKit")]
	public readonly RepairKitComponent RepairKitComponent; //Field offset: 0x78
	private RepairKitTemplate _template; //Field offset: 0x80

	public int MaxRepairResource
	{
		 get { } //Length: 32
	}

	public RepairKitTemplate RepairKitTemplate
	{
		 get { } //Length: 8
	}

	public float RepairQuality
	{
		 get { } //Length: 34
	}

	public ERepairStrategyType[] RepairStrategyTypes
	{
		 get { } //Length: 33
	}

	public float Resource
	{
		 get { } //Length: 19
	}

	public MongoID[] TargetItemFilter
	{
		 get { } //Length: 33
	}

	public RepairKit(string id, RepairKitTemplate template) { }

	public bool CanRepair(Item item) { }

	public virtual bool Compare(Item item) { }

	public bool CompareType(Item item) { }

	public int get_MaxRepairResource() { }

	public RepairKitTemplate get_RepairKitTemplate() { }

	public float get_RepairQuality() { }

	public ERepairStrategyType[] get_RepairStrategyTypes() { }

	public float get_Resource() { }

	public MongoID[] get_TargetItemFilter() { }

}

