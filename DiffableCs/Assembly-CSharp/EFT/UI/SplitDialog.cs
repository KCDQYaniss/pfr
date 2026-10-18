namespace EFT.UI;

public sealed class SplitDialog : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	internal enum ESplitDialogType
	{
		Int = 0,
		Float = 1,
		Step = 2,
	}

	[SerializeField]
	private RectTransform _window; //Field offset: 0x20
	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x28
	[SerializeField]
	private Button _closeButton; //Field offset: 0x30
	[SerializeField]
	private Button _acceptButton; //Field offset: 0x38
	[SerializeField]
	private StepSlider _stepSlider; //Field offset: 0x40
	[SerializeField]
	private IntSlider _intSlider; //Field offset: 0x48
	[SerializeField]
	private CustomTextMeshProUGUI _title; //Field offset: 0x50
	private Action _acceptAction; //Field offset: 0x58
	private Action _cancelAction; //Field offset: 0x60
	private Action _acceptButtonClicked; //Field offset: 0x68

	public SplitDialog() { }

	[CompilerGenerated]
	private void <Awake>b__11_0() { }

	[CompilerGenerated]
	private void <Show>b__13_0() { }

	[CompilerGenerated]
	private void <Show>b__13_1() { }

	[CompilerGenerated]
	private void <UpdateAcceptSubscription>b__15_0() { }

	public void Accept() { }

	public void Awake() { }

	private void CorrectPosition() { }

	public void Hide() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public void Show(string title, int maxValue, Vector2 position, Action acceptAction, Action cancelAction, ESplitDialogType type = 2) { }

	public void Show(string title, int minSliderValue, int maxSliderValue, int minValue, int maxValue, int currentValue, Vector2 position, Action acceptAction, Action cancelAction, ESplitDialogType type = 2, bool allowZero = false) { }

	private void UpdateAcceptSubscription(Action action) { }

}

