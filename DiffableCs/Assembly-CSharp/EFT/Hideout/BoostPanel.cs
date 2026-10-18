namespace EFT.Hideout;

public sealed class BoostPanel : AbstractPanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__3_0() { }

	}

	[CompilerGenerated]
	private struct <ShowContents>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BoostPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private RequirementsPanel _boostRequirementsPanel; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _boostButton; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _boostInfo; //Field offset: 0xB8

	public BoostPanel() { }

	private void Awake() { }

	public virtual void Close() { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<ShowContents>d__4))]
	public virtual Task ShowContents() { }

}

