namespace EFT.UI;

public sealed class AcceptQuestChangeWindow : DialogWindow
{
	[CompilerGenerated]
	private struct <SetAvatar>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AcceptQuestChangeWindow <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TextMeshProUGUI _traderReplica; //Field offset: 0xD8
	[SerializeField]
	private TextMeshProUGUI _timer; //Field offset: 0xE0
	[SerializeField]
	private Image _avatar; //Field offset: 0xE8
	[SerializeField]
	private GameObject _loader; //Field offset: 0xF0
	[SerializeField]
	private GameObject _priceContainer; //Field offset: 0xF8
	[SerializeField]
	private GameObject[] _timerElements; //Field offset: 0x100
	[SerializeField]
	private PriceRow _priceRowOriginal; //Field offset: 0x108
	private readonly List _spawnedPrices; //Field offset: 0x110
	private AcceptQuestChangeArgs _arguments; //Field offset: 0x118
	private bool _isBlockInput; //Field offset: 0x130
	private DateTime _lastTimerUpdate; //Field offset: 0x138

	protected virtual bool CloseOnAccept
	{
		 get { } //Length: 3
	}

	public AcceptQuestChangeWindow() { }

	[CompilerGenerated]
	private void <SetPrice>b__20_0(SingleLineInfo priceInfo) { }

	[CompilerGenerated]
	private void <SetTimer>b__19_0(GameObject te) { }

	protected virtual void Accept() { }

	public virtual void Close() { }

	public virtual void Decline() { }

	protected virtual bool get_CloseOnAccept() { }

	[AsyncStateMachine(typeof(<SetAvatar>d__21))]
	private Task SetAvatar() { }

	private void SetInputInteractive(bool status) { }

	private void SetPrice() { }

	private void SetTimer() { }

	public DialogWindowContext Show(AcceptQuestChangeArgs arguments) { }

	protected virtual void Update() { }

	private void UpdateTimer() { }

}

