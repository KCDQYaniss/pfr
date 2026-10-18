namespace EFT.UI;

[ExecuteInEditMode]
[UsedImplicitly]
public sealed class ToggleButton : UIElement, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private Sprite _onSprite; //Field offset: 0x78
	[SerializeField]
	private Sprite _offSprite; //Field offset: 0x80
	[SerializeField]
	private Graphic _labelOn; //Field offset: 0x88
	[SerializeField]
	private Graphic _labelOff; //Field offset: 0x90
	[SerializeField]
	private bool _interactable; //Field offset: 0x98
	[SerializeField]
	private bool _isOn; //Field offset: 0x99
	private CanvasGroup _canvasGroup; //Field offset: 0xA0
	public readonly BindableEvent OnToggle; //Field offset: 0xA8

	private CanvasGroup CanvasGroup
	{
		private get { } //Length: 393
	}

	public bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 484
	}

	public bool IsOn
	{
		 get { } //Length: 8
		 set { } //Length: 25
	}

	public ToggleButton() { }

	private CanvasGroup get_CanvasGroup() { }

	public bool get_Interactable() { }

	public bool get_IsOn() { }

	private void OnEnable() { }

	private void OnValidate() { }

	public void set_Interactable(bool value) { }

	public void set_IsOn(bool value) { }

	public void SetValueSilently(bool isOn) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	private void UpdateValue(bool notify = false) { }

}

