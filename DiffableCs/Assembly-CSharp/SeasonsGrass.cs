//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SeasonsGrass")]
[Obfuscation(Exclude = True)]
public sealed class SeasonsGrass : ScriptableObject
{
	[CompilerGenerated]
	private struct <Load>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ResourceKey resourceKey; //Field offset: 0x20
		private IEasyAssets <assets>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsGrass <>4__this; //Field offset: 0x20
		public SeasonGrass seasonGrass; //Field offset: 0x28
		private Task <bumpTask>5__2; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private SeasonGrass SummerGrass; //Field offset: 0x18
	[SerializeField]
	private SeasonGrass AutumnGrass; //Field offset: 0x58
	[SerializeField]
	private SeasonGrass AutumnLateGrass; //Field offset: 0x98
	[SerializeField]
	private SeasonGrass SpringGrass; //Field offset: 0xD8
	[SerializeField]
	private SeasonGrass SpringEarlyGrass; //Field offset: 0x118
	[SerializeField]
	private SeasonGrass WinterGrass; //Field offset: 0x158
	private bool _loaded; //Field offset: 0x198
	private ESeason _season; //Field offset: 0x199
	private Texture2D _texture; //Field offset: 0x1A0
	private Texture2D _bump; //Field offset: 0x1A8
	private Color _detailHealthyColor; //Field offset: 0x1B0
	private Color _detailDryColor; //Field offset: 0x1C0
	private Color _windWaveTintColor; //Field offset: 0x1D0

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsGrass() { }

	public void Fix(GPUInstancerDetailPrototype prototype) { }

	private static AbstractLogger get_Logger() { }

	private Task Load(in SeasonGrass seasonGrass) { }

	[AsyncStateMachine(typeof(<Load>d__25))]
	[ItemCanBeNull]
	private Task Load(ResourceKey resourceKey) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__24))]
	private Task LoadAsync(SeasonGrass seasonGrass) { }

	public Task LoadAutumn() { }

	public Task LoadAutumnLate() { }

	public Task LoadSpring() { }

	public Task LoadSpringEarly() { }

	public Task LoadSummer() { }

	public Task LoadWinter() { }

	public void Unload() { }

}

