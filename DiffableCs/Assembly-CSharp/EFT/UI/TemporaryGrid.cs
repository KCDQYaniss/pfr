namespace EFT.UI;

public sealed class TemporaryGrid : IDisposable
{
	public readonly Grid Grid; //Field offset: 0x10
	private readonly HashSet _owners; //Field offset: 0x18

	public TemporaryGrid(IEnumerable items, int width, int height, bool isFlexible) { }

	public override void Dispose() { }

	private void OnItemRemoved(RemoveItemEventArgs eventArgs) { }

}

