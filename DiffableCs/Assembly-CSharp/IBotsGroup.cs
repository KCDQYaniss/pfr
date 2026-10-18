//Type is in global namespace

public interface IBotsGroup
{

	public IBotGame BotGame
	{
		 get { } //Length: 0
	}

	public IBotZone BotZone
	{
		 get { } //Length: 0
	}

	public BotDifficulty InitialBotDifficulty
	{
		 get { } //Length: 0
	}

	public WildSpawnType InitialBotType
	{
		 get { } //Length: 0
	}

	public int MembersCount
	{
		 get { } //Length: 0
	}

	public IBotGame get_BotGame() { }

	public IBotZone get_BotZone() { }

	public BotDifficulty get_InitialBotDifficulty() { }

	public WildSpawnType get_InitialBotType() { }

	public int get_MembersCount() { }

	public IBotOwner Member(int i) { }

}

