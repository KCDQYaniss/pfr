namespace EFT.UI;

public class QuestItemRow : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Action onClick; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private struct <FadeOut>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestItemRow <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TMP_Text _label; //Field offset: 0x20
	[SerializeField]
	private DefaultUIButton _button; //Field offset: 0x28
	[SerializeField]
	private Graphic _background; //Field offset: 0x30
	[SerializeField]
	private Color _defaultBackground; //Field offset: 0x38
	[SerializeField]
	private Color _actualBackground; //Field offset: 0x48
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x58

	public QuestItemRow() { }

	[AsyncStateMachine(typeof(<FadeOut>d__7))]
	public Task FadeOut() { }

	public void Show(Quest quest, Item item, bool isTargetLocation, Action onClick) { }

}

