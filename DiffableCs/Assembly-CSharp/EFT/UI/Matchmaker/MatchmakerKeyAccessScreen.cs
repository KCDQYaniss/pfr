namespace EFT.UI.Matchmaker;

public sealed class MatchmakerKeyAccessScreen : MatchmakerEftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Show>b__14_0(KeyValuePair x) { }

	}

	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB0
	[SerializeField]
	private GameObject _previewPanel; //Field offset: 0xB8
	[SerializeField]
	private WeaponPreview _preview; //Field offset: 0xC0
	[SerializeField]
	private CameraImage _previewImage; //Field offset: 0xC8
	[SerializeField]
	private float _autoRotationSpeed; //Field offset: 0xD0
	[SerializeField]
	private GameObject _noKeycardPanel; //Field offset: 0xD8
	[SerializeField]
	private TMP_Text _warningText; //Field offset: 0xE0
	private bool _isManualRotating; //Field offset: 0xE8
	private bool _autoRotationOn; //Field offset: 0xE9
	private Item _defaultKey; //Field offset: 0xF0
	private int _defaultRequiredCount; //Field offset: 0xF8

	public MatchmakerKeyAccessScreen() { }

	[CompilerGenerated]
	private void <Start>b__11_0(PointerEventData pointerData) { }

	[CompilerGenerated]
	private void <Start>b__11_1(PointerEventData pointerData) { }

	[CompilerGenerated]
	private void <Start>b__11_2() { }

	public virtual void Close() { }

	private void Hide() { }

	private void RefreshItem() { }

	public virtual void Show(KeyAccessScreenController controller) { }

	private void Show(InventoryController itemController, IReadOnlyDictionary requiredKeyCount) { }

	private void Start() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

