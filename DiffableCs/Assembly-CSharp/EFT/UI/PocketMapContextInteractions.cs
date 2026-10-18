namespace EFT.UI;

public sealed class PocketMapContextInteractions : ContextInteractions
{
	private MapMarker _marker; //Field offset: 0x38
	private Vector2 _markerPos; //Field offset: 0x40
	private Action _markerCreate; //Field offset: 0x48
	private Action _markerDelete; //Field offset: 0x50
	private Action _markerEdit; //Field offset: 0x58

	public PocketMapContextInteractions(MapMarker marker, Vector2 markerPos, Action markerCreate, Action markerDelete, Action markerEdit) { }

	private void CreateMarker() { }

	private void DeleteMarker() { }

	private void EditMarker() { }

	protected virtual void ExecuteInteractionInternal(EPocketMapContextInteractions interaction) { }

	public virtual bool IsActive(EPocketMapContextInteractions button) { }

	public virtual IResult IsInteractive(EPocketMapContextInteractions button) { }

}

