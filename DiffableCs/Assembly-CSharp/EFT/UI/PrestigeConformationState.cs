namespace EFT.UI;

public sealed class PrestigeConformationState : EftScreenState
{
	[CompilerGenerated]
	private struct <ShowState>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeConformationState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string DESCRIPTION_KEY = "Prestige/Conformation/Text"; //Field offset: 0x0
	private const string DESCRIPTION_PVE_KEY = "Prestige/Conformation/Text/Pve"; //Field offset: 0x0
	[SerializeField]
	private Image _levelLastImage; //Field offset: 0x90
	[SerializeField]
	private Image _levelCurrentImage; //Field offset: 0x98
	[SerializeField]
	private Image _levelNextImage; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _layoutHolder; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _eftSaveLabel; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _arenaSaveLabel; //Field offset: 0xB8
	[SerializeField]
	private RectTransform _arenaBlock; //Field offset: 0xC0
	[SerializeField]
	private LocalizedText _description; //Field offset: 0xC8
	[SerializeField]
	private float _animationDuration; //Field offset: 0xD0
	[SerializeField]
	private int _animationStartValue; //Field offset: 0xD4
	[SerializeField]
	private Ease _animationEase; //Field offset: 0xD8
	private TweenerCore _layoutTween; //Field offset: 0xE0
	private bool _firstTimeShow; //Field offset: 0xE8

	public PrestigeConformationState() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	public virtual void Close() { }

	public void Init(int prestigeLevelToSet, EGameMode gameMode = 0) { }

	[AsyncStateMachine(typeof(<ShowState>d__16))]
	public virtual Task ShowState() { }

}

