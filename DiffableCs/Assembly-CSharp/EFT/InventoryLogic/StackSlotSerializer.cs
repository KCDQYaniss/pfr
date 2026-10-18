namespace EFT.InventoryLogic;

public sealed class StackSlotSerializer : ISerializer
{
	internal sealed class StackSlotProps
	{
		[JsonProperty("filters")]
		public ItemFilter[] Filters; //Field offset: 0x10

		public StackSlotProps() { }

	}

	[JsonProperty("_name")]
	public string Name; //Field offset: 0x10
	[JsonProperty("_max_count")]
	public int MaxCount; //Field offset: 0x18
	[JsonProperty("_props")]
	public StackSlotProps Props; //Field offset: 0x20

	public StackSlotSerializer() { }

	public override StackSlot Deserialize() { }

	public override object Serialize(StackSlot t) { }

}

