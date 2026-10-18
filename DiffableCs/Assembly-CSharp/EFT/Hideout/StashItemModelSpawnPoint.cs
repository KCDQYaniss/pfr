namespace EFT.Hideout;

public class StashItemModelSpawnPoint : MonoBehaviour
{
	protected readonly List _items; //Field offset: 0x20

	public bool IsEmpty
	{
		 get { } //Length: 157
	}

	public StashItemModelSpawnPoint() { }

	public void AddItem(StashItemModel item) { }

	public override void Clear() { }

	public bool get_IsEmpty() { }

	public bool HasItem(StashItemModel item) { }

	public override void RemoveItem(StashItemModel item) { }

}

