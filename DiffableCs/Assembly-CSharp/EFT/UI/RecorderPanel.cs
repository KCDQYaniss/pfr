namespace EFT.UI;

public sealed class RecorderPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <Start>d__18 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RecorderPanel <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Start>d__18(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const string TIME_FORMAT = "mm\:ss"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnTapeStartPlaying; //Field offset: 0x70
	[SerializeField]
	private RectTransform _buttons; //Field offset: 0x78
	[SerializeField]
	private DefaultUIButton _playButton; //Field offset: 0x80
	[SerializeField]
	private DefaultUIButton _pauseButton; //Field offset: 0x88
	[SerializeField]
	private DefaultUIButton _stopButton; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _currentTimeLabel; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _totalTimeLabel; //Field offset: 0xA0
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0xA8
	[SerializeField]
	private GameObject _activeState; //Field offset: 0xB0
	[SerializeField]
	private GameObject _inactiveState; //Field offset: 0xB8
	private TapeItem _activeTape; //Field offset: 0xC0
	private AudioClip _clip; //Field offset: 0xC8
	private InventoryController _inventoryController; //Field offset: 0xD0
	private StudyItemBaseOperation _operation; //Field offset: 0xD8

	public event Action OnTapeStartPlaying
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RecorderPanel() { }

	[CompilerGenerated]
	private void <Show>b__19_0() { }

	[CompilerGenerated]
	public void add_OnTapeStartPlaying(Action value) { }

	private void Awake() { }

	private string GetTimeString(float time) { }

	private void PauseSound() { }

	private void PauseTape() { }

	private void PlaySound() { }

	private void PlayTape() { }

	[CompilerGenerated]
	public void remove_OnTapeStartPlaying(Action value) { }

	private void SetButtonState(EStudyState state) { }

	public void Show(TapeItem tape, InventoryController inventoryController, bool enabled) { }

	[IteratorStateMachine(typeof(<Start>d__18))]
	private IEnumerator Start() { }

	private void StopSound() { }

	private void StopTape() { }

	private void StudyItemProgressChanged(Item item, float progress, EStudyState state) { }

}

