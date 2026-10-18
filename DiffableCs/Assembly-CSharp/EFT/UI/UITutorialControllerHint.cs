namespace EFT.UI;

public class UITutorialControllerHint : UIElement
{
	[CompilerGenerated]
	private struct <DelayedRebuild>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UITutorialControllerHint <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private RectTransform _arrow; //Field offset: 0x70
	[SerializeField]
	private RectTransform _hintBlock; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _indexLabel; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _textLabel; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _finisherLabel; //Field offset: 0x90

	public UITutorialControllerHint() { }

	[AsyncStateMachine(typeof(<DelayedRebuild>d__6))]
	private Task DelayedRebuild() { }

	private void SetPosition(RectTransform target, Vector2Int anchor, bool isHorizontal, float textBlockOffset) { }

	public void Show(RectTransform target, Vector2Int anchor, bool isHorizontal, float textBlockOffset, string indexText, string mainText, string finisherText) { }

}

