namespace EFT.UI;

public sealed class TraderRequirementIcon : UIElement
{
	[CompilerGenerated]
	private struct <SetAvatar>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TraderSettings traderSettings; //Field offset: 0x20
		public TraderRequirementIcon <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image _avatar; //Field offset: 0x70
	[SerializeField]
	private GameObject _loader; //Field offset: 0x78
	[SerializeField]
	private RankPanel _rankPanel; //Field offset: 0x80

	public TraderRequirementIcon() { }

	[AsyncStateMachine(typeof(<SetAvatar>d__4))]
	private Task SetAvatar(TraderSettings traderSettings) { }

	public void Show(TraderRequirement requirement) { }

}

