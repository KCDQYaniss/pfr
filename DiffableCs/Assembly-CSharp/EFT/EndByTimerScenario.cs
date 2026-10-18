namespace EFT;

internal sealed class EndByTimerScenario : MonoBehaviour
{
	public interface IGame : IGame
	{

		public void StopGame() { }

	}

	private IGame _game; //Field offset: 0x20
	private GameTimer _timer; //Field offset: 0x28
	[CompilerGenerated]
	private GameStatus <MonitoredGameStatus>k__BackingField; //Field offset: 0x30

	internal GameStatus MonitoredGameStatus
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public EndByTimerScenario() { }

	internal static EndByTimerScenario Create(IGame game) { }

	[CompilerGenerated]
	internal GameStatus get_MonitoredGameStatus() { }

	[CompilerGenerated]
	internal void set_MonitoredGameStatus(GameStatus value) { }

	private void Update() { }

}

