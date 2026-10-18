//Type is in global namespace

public class FilterTab : Tab
{
	[SerializeField]
	private Image _filterIcon; //Field offset: 0x90
	private RectTransform _iconRect; //Field offset: 0x98

	public FilterTab() { }

	protected virtual void OnAwake() { }

	public void SetIcon(Sprite icon) { }

	internal virtual void SetInteractable(bool active) { }

}

