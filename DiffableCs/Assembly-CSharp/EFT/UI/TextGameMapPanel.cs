namespace EFT.UI;

public sealed class TextGameMapPanel : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__11_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__11_1(TextGameLocationMarker marker) { }

	}

	[SerializeField]
	private Button _closeButton; //Field offset: 0x80
	[SerializeField]
	private Image _mapImage; //Field offset: 0x88
	[SerializeField]
	private RectTransform _locationsContainer; //Field offset: 0x90
	[SerializeField]
	private TextGameLocationMarker _locationTemplate; //Field offset: 0x98
	[SerializeField]
	private GameObject _playerPawn; //Field offset: 0xA0
	[SerializeField]
	private Dictionary _mapTemplates; //Field offset: 0xA8
	private ISaveStateStorage _saveStateStorage; //Field offset: 0xB0
	private MappedStatVariable _locationVariable; //Field offset: 0xB8
	private readonly List _locationObjects; //Field offset: 0xC0
	private ObjectPool _locationMarkersPool; //Field offset: 0xC8
	private Dictionary _locations; //Field offset: 0xD0

	public TextGameMapPanel() { }

	[CompilerGenerated]
	private TextGameLocationMarker <Show>b__11_0() { }

	public virtual void Close() { }

	private void DrawMap() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(ISaveStateStorage saveStateStorage) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

