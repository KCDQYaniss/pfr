namespace EFT.UI;

public sealed class ToggleSelectableTab : Tab
{

	protected virtual bool CanHandlePointerClick
	{
		 get { } //Length: 5
	}

	public ToggleSelectableTab() { }

	protected virtual bool get_CanHandlePointerClick() { }

	public virtual void HandlePointerClick(bool isSelectedNow) { }

}

