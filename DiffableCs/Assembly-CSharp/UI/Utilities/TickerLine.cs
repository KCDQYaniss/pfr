namespace UI.Utilities;

public sealed class TickerLine : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Process>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TickerLine <>4__this; //Field offset: 0x20
		private CancellationToken <token>5__2; //Field offset: 0x28
		private float <contentSize>5__3; //Field offset: 0x30
		private float <boundsSize>5__4; //Field offset: 0x34
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private RectTransform _bounds; //Field offset: 0x20
	[SerializeField]
	private RectTransform _content; //Field offset: 0x28
	[SerializeField]
	private float _startTime; //Field offset: 0x30
	[SerializeField]
	private float _force; //Field offset: 0x34
	[SerializeField]
	private bool _autoStart; //Field offset: 0x38
	private bool _isEnable; //Field offset: 0x39
	private CancellationTokenSource _tokenSrc; //Field offset: 0x40

	public TickerLine() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[AsyncStateMachine(typeof(<Process>d__10))]
	private Task Process() { }

	private void Start() { }

	public void StartProcess() { }

	public void StopProcess() { }

}

