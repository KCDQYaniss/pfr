namespace CommonAssets.Scripts.Audio.RadioSystem;

public class BroadcastGrid
{
	private readonly Queue _broadcastQueue; //Field offset: 0x10
	private readonly BroadcastItemsContainer _itemsContainer; //Field offset: 0x18
	private readonly BroadcastRule _rule; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 65
	}

	public BroadcastGrid(BroadcastItemsContainer itemsContainer, BroadcastRule rule) { }

	private void ApplyRules() { }

	public int get_Count() { }

	public void RebuildGrid() { }

	private bool TryAddBroadcastItem(EBroadcastItemType itemType) { }

	public bool TryGetBroadcastItemData(out BroadcastItemData item) { }

}

