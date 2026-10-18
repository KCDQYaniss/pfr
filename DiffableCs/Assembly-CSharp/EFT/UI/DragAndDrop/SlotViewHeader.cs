namespace EFT.UI.DragAndDrop;

public sealed class SlotViewHeader : ButtonFeedback
{
	[CompilerGenerated]
	private Action OnSelected; //Field offset: 0xA8
	[SerializeField]
	private Image _arrow; //Field offset: 0xB0
	[SerializeField]
	private GameObject _backgroundSelected; //Field offset: 0xB8
	[SerializeField]
	private GameObject _backgroundIdle; //Field offset: 0xC0
	[SerializeField]
	private Sprite _arrowSelected; //Field offset: 0xC8
	[SerializeField]
	private Sprite _arrowIdle; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _headerText; //Field offset: 0xD8
	[SerializeField]
	private Color _idleColor; //Field offset: 0xE0
	[SerializeField]
	private Color _selectedColor; //Field offset: 0xF0
	private bool _isSelected; //Field offset: 0x100

	public event Action OnSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public SlotViewHeader() { }

	[CompilerGenerated]
	public void add_OnSelected(Action value) { }

	public virtual bool get_Interactable() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	[CompilerGenerated]
	public void remove_OnSelected(Action value) { }

	public virtual void set_Interactable(bool value) { }

	public void SetSelected(bool selected, bool sendCallback = true) { }

	private void SetSelectedVisual(bool selected) { }

	public void Show(string header, bool canBeSelected) { }

}

