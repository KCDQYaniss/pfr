namespace EFT.InventoryLogic;

public class GridSerializer : ISerializer
{
	internal class GridProps
	{
		public int cellsH; //Field offset: 0x10
		public int cellsV; //Field offset: 0x14
		public int maxCount; //Field offset: 0x18
		public int maxWeight; //Field offset: 0x1C
		public ItemFilter[] filters; //Field offset: 0x20

		public GridProps() { }

	}

	public string _name; //Field offset: 0x10
	public GridProps _props; //Field offset: 0x18

	public GridSerializer() { }

	public override Grid Deserialize() { }

	public override object Serialize(Grid grid) { }

}

