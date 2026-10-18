namespace EFT.UI;

public sealed class ActionPanel : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public ActionPanel <>4__this; //Field offset: 0x10
		public AvailableInteractionState interactionState; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal InteractionButton <AvailableInteractionStateChangedHandler>b__0(InteractionAction arg) { }

		internal Transform <AvailableInteractionStateChangedHandler>b__1(InteractionAction arg) { }

		internal void <AvailableInteractionStateChangedHandler>b__2(InteractionAction model, InteractionButton view) { }

	}

	private const float TRANSITION_SPEED = 5; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _itemName; //Field offset: 0x80
	[SerializeField]
	private GameObject _itemPanel; //Field offset: 0x88
	[SerializeField]
	private GameObject _errorPanel; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _errorText; //Field offset: 0x98
	[SerializeField]
	private Image _progressBar; //Field offset: 0xA0
	[SerializeField]
	private UIPointer _pointer; //Field offset: 0xA8
	[SerializeField]
	private InteractionButton _interactionButtonTemplate; //Field offset: 0xB0
	[SerializeField]
	private RectTransform _interactionButtonsContainer; //Field offset: 0xB8
	[SerializeField]
	private Vector2 _aimingShift; //Field offset: 0xC0
	[SerializeField]
	private QuestPointerCalculationModule _questPointerCalculationModule; //Field offset: 0xC8
	[SerializeField]
	private Image _upLeftQuestItemPointer; //Field offset: 0xD0
	[SerializeField]
	private Image _upRightQuestItemPointer; //Field offset: 0xD8
	[SerializeField]
	private Image _downLeftQuestItemPointer; //Field offset: 0xE0
	[SerializeField]
	private Image _downRightQuestItemPointer; //Field offset: 0xE8
	private Vector2 _defaultInteractionPosition; //Field offset: 0xF0
	private ViewList _viewList; //Field offset: 0xF8
	private GamePlayerOwner _owner; //Field offset: 0x100
	private bool _cursorIsOn; //Field offset: 0x108
	private bool _senseIsOn; //Field offset: 0x109
	private float _pointerCurrentAlpha; //Field offset: 0x10C
	private float _pointerTargetAlpha; //Field offset: 0x110
	private bool _showQuestPointer; //Field offset: 0x114
	private bool _questPointerIsInvisible; //Field offset: 0x115
	private bool _isInit; //Field offset: 0x116
	private bool _isAiming; //Field offset: 0x117
	private Vector2 _defaultPointerSize; //Field offset: 0x118

	public ActionPanel() { }

	[CompilerGenerated]
	private void <Show>b__29_1() { }

	[CompilerGenerated]
	private void <Show>g__OnHandsControllerChanged|29_0(AbstractHandsController oldValue, AbstractHandsController newValue) { }

	private void AimingChangedHandler(bool isAiming) { }

	private void ApplyQuestCornerAlphas(float targetUl, float targetUr, float targetDl, float targetDr) { }

	private void AvailableInteractionStateChangedHandler(AvailableInteractionState interactionState) { }

	private void CalculateDefaultPointerImageSize() { }

	private void ForceHideQuestPointer() { }

	public void Hide() { }

	private void HideCursor() { }

	private void SetInteractionButtonsPosition(bool isDefaultPosition) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	internal void Show(GamePlayerOwner owner) { }

	private void ShowHandCursor() { }

	public void ShowPointer(bool b) { }

	private void ShowProhibitCursor() { }

	private void Start() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

	public void UpdateClosestQuestItemPos(bool haveAnyQuestItem, Vector3 nearestQuestItem) { }

	private void UpdatePointerAlpha() { }

	public void UpdateQuestItemPointer() { }

}

