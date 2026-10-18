namespace EFT.UI;

public abstract class ValidateDeviceIdScreen`2 : BaseScreen
{
	[SerializeField]
	private CustomTextMeshProInputField _deviceIdInputField; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _errorLabel; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _cancelButton; //Field offset: 0x0

	protected ValidateDeviceIdScreen`2() { }

	[CompilerGenerated]
	private void <Awake>b__4_0() { }

	[CompilerGenerated]
	private void <Awake>b__4_1() { }

	[CompilerGenerated]
	private void <Awake>b__4_2(string arg) { }

	private void Awake() { }

	public void ErrorShow(string err) { }

	private void Proceed() { }

	public virtual void Show(TController controller) { }

	private void Show() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

