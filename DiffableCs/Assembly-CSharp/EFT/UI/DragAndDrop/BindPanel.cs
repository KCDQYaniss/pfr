namespace EFT.UI.DragAndDrop;

public sealed class BindPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CrtRebuildLayout>d__4 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BindPanel <>4__this; //Field offset: 0x20

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
		public <CrtRebuildLayout>d__4(int <>1__state) { }

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
	private CustomTextMeshProUGUI _hotKey; //Field offset: 0x20
	private bool _rebuildLayout; //Field offset: 0x28

	public BindPanel() { }

	[IteratorStateMachine(typeof(<CrtRebuildLayout>d__4))]
	private IEnumerator CrtRebuildLayout() { }

	public void Hide() { }

	private void OnEnable() { }

	public void Show(EBoundItem slotName) { }

}

