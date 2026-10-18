namespace EFT.UI;

[Obfuscation(Exclude = True)]
public class NoteWindow : MonoBehaviour
{
	[SerializeField]
	private RectTransform _mainWindow; //Field offset: 0x20
	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x28
	[SerializeField]
	private Button _closeButton; //Field offset: 0x30
	[SerializeField]
	private TMP_InputField _note; //Field offset: 0x38
	[SerializeField]
	private CustomTextMeshProUGUI _lettersCounter; //Field offset: 0x40
	[SerializeField]
	private DefaultUIButton _button; //Field offset: 0x48
	private Action _acceptAction; //Field offset: 0x50
	private Action _cancelAction; //Field offset: 0x58

	private RectTransform RectTransform
	{
		private get { } //Length: 146
	}

	public NoteWindow() { }

	[CompilerGenerated]
	private void <Awake>b__10_0() { }

	[CompilerGenerated]
	private void <Awake>b__10_1() { }

	public void Awake() { }

	public void FillData(Note note) { }

	private RectTransform get_RectTransform() { }

	public void Hide() { }

	public void Show(Action acceptAction, Action cancelAction) { }

	public void TextChangedHandler(string value) { }

	public void TitleChangedHandler(string value) { }

	public void UpdateAcceptButton() { }

}

