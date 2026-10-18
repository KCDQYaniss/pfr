namespace EFT.UI.DragAndDrop;

public sealed class ItemViewExamineComponent : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private struct <StartAnimation>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemViewExamineComponent <>4__this; //Field offset: 0x20
		private Task <timer>5__2; //Field offset: 0x28
		private double <startTime>5__3; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TextMeshProUGUI _progressLabel; //Field offset: 0x60
	[SerializeField]
	private Slider _progressSlider; //Field offset: 0x68
	private float _duration; //Field offset: 0x70
	private CancellationTokenSource _taskCancellation; //Field offset: 0x78

	public ItemViewExamineComponent() { }

	public void Destroy() { }

	private void SetProgress(float progress) { }

	public void Show(float duration) { }

	[AsyncStateMachine(typeof(<StartAnimation>d__5))]
	private Task StartAnimation() { }

}

