namespace EFT.Interactive;

public class LootPointViewer : MonoBehaviour
{
	private LootPoint _lootPoint; //Field offset: 0x20
	private List _views; //Field offset: 0x28
	[CompilerGenerated]
	private Item <CurrentItem>k__BackingField; //Field offset: 0x30

	public private Item CurrentItem
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private LootPoint LootPoint
	{
		private get { } //Length: 154
	}

	public LootPointViewer() { }

	public void Clear() { }

	[CompilerGenerated]
	public Item get_CurrentItem() { }

	private LootPoint get_LootPoint() { }

	[CompilerGenerated]
	private void set_CurrentItem(Item value) { }

	public void ShowItem(Item item) { }

}

