//Type is in global namespace

public class DebugTextPanelWithManualLayout : MonoBehaviour
{
	private static readonly char[] NEW_LINE_SEPARATOR; //Field offset: 0x0
	[SerializeField]
	private Text _dataLineTemplate; //Field offset: 0x20
	private readonly List _linesCache; //Field offset: 0x28
	private int _activeLinesCount; //Field offset: 0x30
	private RectTransform _rectTransf; //Field offset: 0x38

	private float LinesHeight
	{
		private get { } //Length: 277
	}

	public RectTransform RectTransform
	{
		 get { } //Length: 176
	}

	private static DebugTextPanelWithManualLayout() { }

	public DebugTextPanelWithManualLayout() { }

	private Text AddLine() { }

	private float get_LinesHeight() { }

	public RectTransform get_RectTransform() { }

	private void OnDestroy() { }

	public void Start() { }

	public void UpdateText(string text) { }

}

