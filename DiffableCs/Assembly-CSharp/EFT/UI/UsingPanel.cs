namespace EFT.UI;

public class UsingPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <Progress>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UsingPanel <>4__this; //Field offset: 0x20
		public float duration; //Field offset: 0x28

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
		public <Progress>d__14(int <>1__state) { }

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
	private CustomTextMeshProUGUI _caption; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _itemName; //Field offset: 0x78
	[SerializeField]
	private Image _progressBarImage; //Field offset: 0x80
	[SerializeField]
	private Color _defaultColor; //Field offset: 0x88
	[SerializeField]
	private Color _examineColor; //Field offset: 0x98
	private DateTime _startTime; //Field offset: 0xA8
	private DateTime _endTime; //Field offset: 0xB0
	private Coroutine _progressCoroutine; //Field offset: 0xB8
	private IHealthEffect _effect; //Field offset: 0xC0

	public UsingPanel() { }

	private void Cleanup() { }

	public virtual void Close() { }

	public void Init(IHealthController healthController, InventoryController itemController) { }

	private void OnEffectRemoved(IHealthEffect effect) { }

	private void OnEffectStarted(IHealthEffect effect) { }

	private void OnPlayerExamining(ExamineItemEventArgs args) { }

	[IteratorStateMachine(typeof(<Progress>d__14))]
	private IEnumerator Progress(float duration) { }

	private void ShowPanel(string itemName, float useTime) { }

}

