namespace CommonAssets.Scripts.Game;

public sealed class EndByExitTrigerScenario : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Player player; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <StartExtraction>b__0(LocationEscape x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Player player; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <CancelExtraction>b__0(LocationEscape x) { }

	}

	internal interface IGame : IGame
	{

		public Task StopSession(string profileId, ExitStatus exitStatus, string exitName) { }

		public Task StopSession(int playerRaidId, ExitStatus exitStatus, string exitName) { }

	}

	private sealed class LocationEscape
	{
		public readonly Player Player; //Field offset: 0x10
		public readonly ExfiltrationPoint Trigger; //Field offset: 0x18
		public readonly float StartTime; //Field offset: 0x20

		public LocationEscape(Player player, ExfiltrationPoint trigger, float startTime) { }

	}

	private IGame _game; //Field offset: 0x20
	private ExfiltrationPoint[] _exitTriggers; //Field offset: 0x28
	private readonly List _escapes; //Field offset: 0x30
	private readonly Queue _confirmed; //Field offset: 0x38
	private readonly List _monitoredEP; //Field offset: 0x40

	public EndByExitTrigerScenario() { }

	private void CancelExtraction(ExfiltrationPoint trigger, Player player) { }

	public static EndByExitTrigerScenario Create(IGame game) { }

	private void OnStatusChangedHandler(ExfiltrationPoint point, EExfiltrationStatus prevStatus) { }

	public void Run() { }

	private void StartExtraction(ExfiltrationPoint trigger, Player player) { }

	public void Stop() { }

	private void Update() { }

}

