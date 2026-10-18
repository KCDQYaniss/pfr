namespace EFT.UI;

public class InventoryCustomizationSelector : MonoBehaviour
{
	[CompilerGenerated]
	private struct <ValidateRoot>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryCustomizationSelector <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class TooltipController
	{
		private readonly SimpleTooltip _tooltip; //Field offset: 0x10
		private object _owner; //Field offset: 0x18

		public TooltipController(SimpleTooltip tooltip) { }

		public void HideTooltip(object owner) { }

		public void ShowTooltip(string message, object owner) { }

	}

	[SerializeField]
	private InventoryCustomizationSelectorButton _selectedItem; //Field offset: 0x20
	[SerializeField]
	private InventoryCustomizationSelectorButton _buttonTemplate; //Field offset: 0x28
	[SerializeField]
	private TMP_Text _label; //Field offset: 0x30
	[SerializeField]
	private Transform _buttonsContainer; //Field offset: 0x38
	[SerializeField]
	private CanvasGroup _buttonsRoot; //Field offset: 0x40
	[SerializeField]
	private Button _toggleButton; //Field offset: 0x48
	[SerializeField]
	private Image _toggleBackground; //Field offset: 0x50
	[SerializeField]
	private Transform _buttonArrow; //Field offset: 0x58
	[SerializeField]
	private RectTransform _closeSafeClickArea; //Field offset: 0x60
	[SerializeField]
	private RectTransform _openSafeClickArea; //Field offset: 0x68
	[SerializeField]
	private CanvasGroup _canvasToHide; //Field offset: 0x70
	[SerializeField]
	private float _tweenTime; //Field offset: 0x78
	private List _buttons; //Field offset: 0x80
	private bool _isOpen; //Field offset: 0x88
	private Action _suitSelectedHandler; //Field offset: 0x90
	private InventoryCustomizationSelectorButton _activeElement; //Field offset: 0x98
	private TooltipController _tooltipController; //Field offset: 0xA0
	private bool _rootSizeValidated; //Field offset: 0xA8
	private Tween _fadeTween; //Field offset: 0xB0

	public bool IsPointerOverlap
	{
		 get { } //Length: 209
	}

	private RectTransform SafeClickArea
	{
		private get { } //Length: 19
	}

	public InventoryCustomizationSelector() { }

	private void Awake() { }

	private void ButtonClickHandler(InventoryCustomizationSelectorButton sender) { }

	public void Close() { }

	private Tween DoShow() { }

	public bool get_IsPointerOverlap() { }

	private RectTransform get_SafeClickArea() { }

	public void Init(IEnumerable suits, CustomizationSuite selectedItem, Action suitSelectedHandler, bool isMatching) { }

	private void MainButtonClickHandler(InventoryCustomizationSelectorButton _) { }

	public void SetOpenState(bool isOpen) { }

	private void ToggleOpenState() { }

	[AsyncStateMachine(typeof(<ValidateRoot>d__30))]
	private Task ValidateRoot() { }

}

