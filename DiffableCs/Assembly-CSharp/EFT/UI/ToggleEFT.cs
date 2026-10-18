namespace EFT.UI;

[DisallowMultipleComponent]
[ExecuteInEditMode]
[UsedImplicitly]
public sealed class ToggleEFT : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[UsedImplicitly]
	internal enum EToggleInternalState
	{
		Disabled = 0,
		On = 1,
		OnHover = 2,
		OnPressed = 3,
		Off = 4,
		OffHover = 5,
		OffPressed = 6,
	}

	[UsedImplicitly]
	internal enum EToggleState
	{
		Disabled = 0,
		On = 1,
		Off = 2,
	}

	private readonly BindableEvent _onStateChange; //Field offset: 0x70
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private ToggleGroupEFT _toggleGroup; //Field offset: 0x78
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private List _disabledStateObjects; //Field offset: 0x80
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private List _onStateObjects; //Field offset: 0x88
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private List _onHoverStateObjects; //Field offset: 0x90
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private List _onPressedStateObjects; //Field offset: 0x98
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private List _offStateObjects; //Field offset: 0xA0
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private List _offHoverStateObjects; //Field offset: 0xA8
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private List _offPressedStateObjects; //Field offset: 0xB0
	private Dictionary _states; //Field offset: 0xB8
	private bool _enabled; //Field offset: 0xC0
	private bool _isOn; //Field offset: 0xC1
	private bool _hover; //Field offset: 0xC2
	private bool _click; //Field offset: 0xC3

	private EToggleInternalState CurrentState
	{
		private set { } //Length: 1591
	}

	public bool IsOn
	{
		 get { } //Length: 8
	}

	public IBindableEvent OnStateChange
	{
		 get { } //Length: 5
	}

	private Dictionary States
	{
		private get { } //Length: 602
	}

	public ToggleEFT() { }

	public virtual void Close() { }

	public bool get_IsOn() { }

	public IBindableEvent get_OnStateChange() { }

	private Dictionary get_States() { }

	[UsedImplicitly]
	private void OnApplicationFocus(bool hasFocus) { }

	[UsedImplicitly]
	private void OnDisable() { }

	private void set_CurrentState(EToggleInternalState value) { }

	private void SetClick(bool clickState) { }

	private void SetHover(bool hoverState) { }

	public void Show(EToggleState state) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	private void UpdateState() { }

}

