namespace EFT.Hideout;

public sealed class AmbianceController : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private struct <ChangeLightStatus>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AmbianceController <>4__this; //Field offset: 0x20
		public ELightStatus status; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PerformInteraction>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AmbianceController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private List _ambianceObjects; //Field offset: 0x60
	[SerializeField]
	private HideoutAudioBackground _audioBackground; //Field offset: 0x68
	private IEnumerable _datas; //Field offset: 0x70
	[CompilerGenerated]
	private ELightStatus <GlobalLightStatus>k__BackingField; //Field offset: 0x78

	public private ELightStatus GlobalLightStatus
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public AmbianceController() { }

	[AsyncStateMachine(typeof(<ChangeLightStatus>d__10))]
	private Task ChangeLightStatus(ELightStatus status) { }

	public void EnergySupplyChanged(bool isOn) { }

	[CompilerGenerated]
	public ELightStatus get_GlobalLightStatus() { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__11))]
	private Task PerformInteraction() { }

	public void ReplayCurrentStatus() { }

	[CompilerGenerated]
	private void set_GlobalLightStatus(ELightStatus value) { }

	public void Show(IEnumerable datas, bool isEnergyOn) { }

}

