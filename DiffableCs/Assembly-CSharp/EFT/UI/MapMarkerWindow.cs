namespace EFT.UI;

[Obfuscation(Exclude = True)]
public class MapMarkerWindow : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public ToggleData toggleDataSave; //Field offset: 0x10
		public MapMarkerWindow <>4__this; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <Awake>b__2(bool value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public MapMarkerType type; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal bool <SelectToggle>b__0(ToggleData toggleData) { }

	}

	internal class ToggleData
	{
		public MapMarkerType Type; //Field offset: 0x10
		public Toggle Toggle; //Field offset: 0x18

		public ToggleData() { }

	}

	[SerializeField]
	private RectTransform _mainWindow; //Field offset: 0x20
	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x28
	[SerializeField]
	private Button _closeButton; //Field offset: 0x30
	[SerializeField]
	private DefaultUIButton _acceptButton; //Field offset: 0x38
	[SerializeField]
	private ValidationInputField _note; //Field offset: 0x40
	[SerializeField]
	private CustomTextMeshProUGUI _lettersCounter; //Field offset: 0x48
	[SerializeField]
	private ToggleData[] _toggles; //Field offset: 0x50
	private Action _acceptAction; //Field offset: 0x58
	private Action _cancelAction; //Field offset: 0x60
	private MapMarkerType _selectedType; //Field offset: 0x68

	public MapMarkerWindow() { }

	[CompilerGenerated]
	private void <Awake>b__11_0() { }

	[CompilerGenerated]
	private void <Awake>b__11_1() { }

	private void Awake() { }

	public void FillWithData(MapMarker marker) { }

	public void Hide() { }

	public void MarkerTypeChangedHandler(MapMarkerType type, bool value) { }

	private void OnDestroy() { }

	private void SelectToggle(MapMarkerType type) { }

	public void Show(Vector2 position, Action acceptAction, Action cancelAction) { }

	private void Start() { }

	private void TextChangedHandler(string value) { }

	private void UpdateLettersCounter() { }

}

