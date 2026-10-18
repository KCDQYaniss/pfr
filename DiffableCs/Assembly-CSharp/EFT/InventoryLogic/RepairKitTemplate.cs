namespace EFT.InventoryLogic;

public class RepairKitTemplate : SpecItemTemplate
{
	[JsonProperty("MaxRepairResource")]
	public int MaxRepairResource; //Field offset: 0x150
	[JsonProperty("TargetItemFilter")]
	public MongoID[] TargetItemFilter; //Field offset: 0x158
	[JsonProperty("RepairQuality")]
	public float RepairQuality; //Field offset: 0x160
	[JsonProperty("RepairStrategyTypes")]
	public ERepairStrategyType[] RepairStrategyTypes; //Field offset: 0x168

	public RepairKitTemplate() { }

}

