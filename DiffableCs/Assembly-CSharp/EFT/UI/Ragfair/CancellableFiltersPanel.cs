namespace EFT.UI.Ragfair;

public sealed class CancellableFiltersPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public RagFair ragfair; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0(CancellableFilter item, CancellableFilterPanel view) { }

		internal void <Show>b__1(CancellableFilter item, CancellableFilterPanel view) { }

	}

	[CompilerGenerated]
	private sealed class <Co_Wait>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CancellableFiltersPanel <>4__this; //Field offset: 0x20

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
		public <Co_Wait>d__15(int <>1__state) { }

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

	[SerializeField]
	private GameObject _verticalPanel; //Field offset: 0x70
	[SerializeField]
	private Button _expandButton; //Field offset: 0x78
	[SerializeField]
	private CancellableFilterPanel _horizontalFilterPanel; //Field offset: 0x80
	[SerializeField]
	private RectTransform _horizontalContainer; //Field offset: 0x88
	[SerializeField]
	private CancellableFilterPanel _verticalFilterPanel; //Field offset: 0x90
	[SerializeField]
	private RectTransform _verticalContainer; //Field offset: 0x98
	private CancellableFilters _filters; //Field offset: 0xA0
	private bool _expandedStatus; //Field offset: 0xA8
	private Coroutine _waitCoroutine; //Field offset: 0xB0

	public CancellableFiltersPanel() { }

	[CompilerGenerated]
	private void <Awake>b__9_0() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<Co_Wait>d__15))]
	private IEnumerator Co_Wait() { }

	private void SetExpandedStatus(bool status) { }

	private void SetHorizontalContainerStatus() { }

	private void SetVerticalContainerStatus() { }

	private void SetVerticalPanelPosition() { }

	public void Show(RagFair ragfair) { }

}

