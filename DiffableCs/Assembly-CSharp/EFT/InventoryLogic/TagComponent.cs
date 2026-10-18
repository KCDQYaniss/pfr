namespace EFT.InventoryLogic;

public sealed class TagComponent : ItemComponent
{
	public const int MAX_TAG_NAME_LENGTH = 16; //Field offset: 0x0
	public static readonly Color[] TagColors; //Field offset: 0x0
	[DefaultValue(0)]
	[Diffable]
	public int Color; //Field offset: 0x18
	[DefaultValue(null)]
	[Diffable]
	public string Name; //Field offset: 0x20

	public bool IsEmpty
	{
		 get { } //Length: 26
	}

	private static TagComponent() { }

	public TagComponent(Item item) { }

	public bool get_IsEmpty() { }

	public OperationResult Set(string name, int color, bool simulate) { }

}

