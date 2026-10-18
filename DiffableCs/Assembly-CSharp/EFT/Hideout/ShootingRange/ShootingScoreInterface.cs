namespace EFT.Hideout.ShootingRange;

public class ShootingScoreInterface : MonoBehaviour
{
	[CompilerGenerated]
	private struct <StartBeforeTraining>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShootingScoreInterface <>4__this; //Field offset: 0x20
		public int seconds; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartCountdown>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ShootingScoreInterface <>4__this; //Field offset: 0x28
		public float delay; //Field offset: 0x30
		public float duration; //Field offset: 0x34
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartTraining>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShootingScoreInterface <>4__this; //Field offset: 0x20
		public int seconds; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private GameObject _beforeTraining; //Field offset: 0x20
	[SerializeField]
	private GameObject _training; //Field offset: 0x28
	[SerializeField]
	private TextMeshProUGUI _countdownValue; //Field offset: 0x30
	[SerializeField]
	private Color _defaultCountdownColor; //Field offset: 0x38
	[SerializeField]
	private Color _finalCountdownColor; //Field offset: 0x48
	[SerializeField]
	private int _finalCountdownSeconds; //Field offset: 0x58
	[SerializeField]
	private GameObject _timeLeft; //Field offset: 0x60
	[SerializeField]
	private TextMeshProUGUI _timeLeftValue; //Field offset: 0x68
	[SerializeField]
	private TextMeshProUGUI _currentScoreValue; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _bestScoreValue; //Field offset: 0x78
	[SerializeField]
	private AudioSource _audioSignal; //Field offset: 0x80
	private Color _currentColor; //Field offset: 0x88
	private CancellationTokenSource _cancellation; //Field offset: 0x98

	public ShootingScoreInterface() { }

	public string FormatScore(int value) { }

	public string FormatSeconds(int value) { }

	public string FormatTime(int value) { }

	public void HideTimeLeft() { }

	public void ResetCountdown() { }

	public void SetBestScore(int value) { }

	public void SetCountdown(int value) { }

	public void SetCurrentScore(int value) { }

	public void SetTimeLeft(int value) { }

	public void SetTimeLeftColor(Color value) { }

	public void ShowBeforeTraining() { }

	public void ShowTimeLeft() { }

	public void ShowTraining() { }

	[AsyncStateMachine(typeof(<StartBeforeTraining>d__12))]
	public Task StartBeforeTraining(int seconds, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<StartCountdown>d__15))]
	public void StartCountdown(float delay, float duration) { }

	[AsyncStateMachine(typeof(<StartTraining>d__13))]
	public Task StartTraining(int seconds, CancellationToken cancellationToken) { }

	public void StopCountdown() { }

}

