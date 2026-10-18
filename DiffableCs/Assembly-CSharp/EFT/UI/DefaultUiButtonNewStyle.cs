namespace EFT.UI;

[ExecuteInEditMode]
[UsedImplicitly]
public class DefaultUiButtonNewStyle : UIElement, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	[UsedImplicitly]
	internal enum EButtonState
	{
		Normal = 0,
		Hover = 1,
		Pressed = 2,
		Disabled = 3,
	}

	[SerializeField]
	private Dictionary _states; //Field offset: 0x70
	[SerializeField]
	private List _labels; //Field offset: 0x78
	private bool _hover; //Field offset: 0x80
	private bool _press; //Field offset: 0x81
	private bool _enabled; //Field offset: 0x82
	private string _tooltip; //Field offset: 0x88
	private CancellationToken _tooltipToken; //Field offset: 0x90
	private CanvasGroup _canvasGroup; //Field offset: 0x98
	private BindableEvent _onClick; //Field offset: 0xA0
	private BindableEvent _onMouseOver; //Field offset: 0xA8
	private BindableEvent _onMouseOut; //Field offset: 0xB0

	public CanvasGroup CanvasGroup
	{
		 get { } //Length: 405
	}

	public bool IsInteractive
	{
		 get { } //Length: 8
	}

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	public IBindableEvent OnMouseOut
	{
		 get { } //Length: 8
	}

	public IBindableEvent OnMouseOver
	{
		 get { } //Length: 8
	}

	private bool TooltipActive
	{
		private get { } //Length: 111
	}

	public DefaultUiButtonNewStyle() { }

	public CanvasGroup get_CanvasGroup() { }

	public bool get_IsInteractive() { }

	public IBindableEvent get_OnClick() { }

	public IBindableEvent get_OnMouseOut() { }

	public IBindableEvent get_OnMouseOver() { }

	private bool get_TooltipActive() { }

	[UsedImplicitly]
	private void OnDisable() { }

	[UsedImplicitly]
	private void OnEnable() { }

	public void SetAvailability(bool interactive, string tooltip = null) { }

	public void SetLabel(string label) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	private void UpdateState() { }

}

