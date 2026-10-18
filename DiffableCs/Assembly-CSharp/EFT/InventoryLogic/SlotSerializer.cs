namespace EFT.InventoryLogic;

public class SlotSerializer : ISerializer
{
	internal class SlotProps
	{
		public ItemFilter[] filters; //Field offset: 0x10

		public SlotProps() { }

	}

	public string _name; //Field offset: 0x10
	public bool _required; //Field offset: 0x18
	public SlotProps _props; //Field offset: 0x20
	public bool _mergeSlotWithChildren; //Field offset: 0x28
	public string _proto; //Field offset: 0x30
	public bool _isPlateSlot; //Field offset: 0x38
	public bool _isPatronSlot; //Field offset: 0x39

	public SlotSerializer() { }

	public override Slot Deserialize() { }

	public override object Serialize(Slot t) { }

}

