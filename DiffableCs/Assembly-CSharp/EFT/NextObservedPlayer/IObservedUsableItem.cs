namespace EFT.NextObservedPlayer;

public interface IObservedUsableItem
{

	public void Disable() { }

	public void Initialize(GameObject gameObject) { }

	public void UpdateData(ObservedUsableItemUpdatedData observedUsableItemUpdatedData) { }

}

