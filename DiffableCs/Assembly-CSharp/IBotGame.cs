//Type is in global namespace

public interface IBotGame
{

	public event Action UpdateByUnity
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public BossSpawnScenario BossSpawnScenario
	{
		 get { } //Length: 0
	}

	public BotsController BotsController
	{
		 get { } //Length: 0
	}

	public GameDateTime GameDateTime
	{
		 get { } //Length: 0
	}

	public Location Location
	{
		 get { } //Length: 0
	}

	public GameStatus Status
	{
		 get { } //Length: 0
	}

	public IWeatherCurve WeatherCurve
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_UpdateByUnity(Action value) { }

	public Task BotDespawn(BotOwner bot) { }

	public BossSpawnScenario get_BossSpawnScenario() { }

	public BotsController get_BotsController() { }

	public GameDateTime get_GameDateTime() { }

	public Location get_Location() { }

	public GameStatus get_Status() { }

	public IWeatherCurve get_WeatherCurve() { }

	[CompilerGenerated]
	public void remove_UpdateByUnity(Action value) { }

}

