namespace EFT.Interactive;

public class LootPointNode
{
	public ItemTemplate Template; //Field offset: 0x10
	public string Name; //Field offset: 0x18
	public string Id; //Field offset: 0x20
	public readonly List Children; //Field offset: 0x28
	private bool _open; //Field offset: 0x30

	public LootPointNode() { }

	public string GetReadableName() { }

}

