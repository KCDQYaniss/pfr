namespace EFT;

public class PlayerRecorderController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public PlayerRecorderController <>4__this; //Field offset: 0x10
		public RecorderItem recorder; //Field offset: 0x18
		public TapeItem tape; //Field offset: 0x20

		public <>c__DisplayClass40_0() { }

		internal void <CreateRecorderHandler>b__0() { }

		internal void <CreateRecorderHandler>b__1() { }

		internal void <CreateRecorderHandler>b__2() { }

		internal void <CreateRecorderHandler>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <FindTapes>d__33 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TapeItem <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Inventory inventory; //Field offset: 0x28
		public Inventory <>3__inventory; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38

		private override TapeItem System.Collections.Generic.IEnumerator<EFT.InventoryLogic.TapeItem>.Current
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
		public <FindTapes>d__33(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.TapeItem>.GetEnumerator() { }

		[DebuggerHidden]
		private override TapeItem System.Collections.Generic.IEnumerator<EFT.InventoryLogic.TapeItem>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private RecorderButtonPressedDelegate OnPressButtonAnimationComplete; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnStartAudio; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnStopAudio; //Field offset: 0x20
	private readonly Dictionary _insertedTapes; //Field offset: 0x28
	private readonly InventoryController _controller; //Field offset: 0x30
	private TapeItem _nextTape; //Field offset: 0x38
	private StudyItemPlayerOperation _activeOperation; //Field offset: 0x40
	private RecorderItem _activeRecorder; //Field offset: 0x48
	private RecorderItem _animatingRecorder; //Field offset: 0x50

	public event RecorderButtonPressedDelegate OnPressButtonAnimationComplete
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnStartAudio
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnStopAudio
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public TapeItem ActiveTape
	{
		 get { } //Length: 133
	}

	public bool HasActiveOperation
	{
		 get { } //Length: 9
	}

	public PlayerRecorderController(InventoryController inventoryController) { }

	[CompilerGenerated]
	public void add_OnPressButtonAnimationComplete(RecorderButtonPressedDelegate value) { }

	[CompilerGenerated]
	public void add_OnStartAudio(Action value) { }

	[CompilerGenerated]
	public void add_OnStopAudio(Action value) { }

	private void BreakRecorderHandler(TapeItem tape) { }

	private void ClearTapeInRecorders(TapeItem tape) { }

	public RecorderHandler CreateRecorderHandler(RecorderItem recorder) { }

	private void EjectTapeHandler(RecorderItem recorder) { }

	public IEnumerable FindTapes() { }

	[IteratorStateMachine(typeof(<FindTapes>d__33))]
	public static IEnumerable FindTapes(Inventory inventory) { }

	public TapeItem get_ActiveTape() { }

	public bool get_HasActiveOperation() { }

	public TapeItem GetNextTape() { }

	private void InsertTapeHandler(RecorderItem recorder, TapeItem tape) { }

	public bool IsAnyRecorderActive() { }

	public bool IsAnyRecorderPlaying() { }

	public bool IsOperationActive(StudyItemBaseOperation operation) { }

	public bool IsRecorderActive(RecorderItem recorder) { }

	public bool IsRecorderEnabled() { }

	public bool IsRecorderInSpecSlot(RecorderItem recorder) { }

	public bool IsRecorderPlaying(RecorderItem recorder) { }

	private void PlayTapeHandler(RecorderItem recorder) { }

	[CompilerGenerated]
	public void remove_OnPressButtonAnimationComplete(RecorderButtonPressedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnStartAudio(Action value) { }

	[CompilerGenerated]
	public void remove_OnStopAudio(Action value) { }

	public void SetActiveOperation(StudyItemPlayerOperation operation) { }

	public void SetTapeToPlay(TapeItem nextTape) { }

	public void StartPlayingAudioClip(TapeItem tape, RecorderItem recorder) { }

	public void StopOperation(bool immediate, out Task completionTask) { }

	public void StopPlayingAudioClip() { }

	public bool TryFindEquippedRecorder(out RecorderItem recorder) { }

	public static bool TryFindEquippedRecorderInInventory(Inventory inventory, out RecorderItem recorder) { }

	public bool TryGetNextTape(out TapeItem nextTape) { }

	private static bool TryGetSpecSlots(Inventory inventory, out Slot[] slots) { }

}

