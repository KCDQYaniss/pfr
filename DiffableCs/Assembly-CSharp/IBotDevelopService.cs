//Type is in global namespace

public interface IBotDevelopService
{

	public event Action OnPlayerDataAdded
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnPlayerDataRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public GameWorld GameWorld
	{
		 get { } //Length: 0
	}

	public bool IsDeveloperMode
	{
		 get { } //Length: 0
	}

	public Player MyPlayer
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnPlayerDataAdded(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerDataRemoved(Action value) { }

	public GameWorld get_GameWorld() { }

	public bool get_IsDeveloperMode() { }

	public Player get_MyPlayer() { }

	public List GetGroupData() { }

	public DebugBotProfilesStructContainer GetProfilesData() { }

	public void Initialize(int playerId = 0) { }

	[CompilerGenerated]
	public void remove_OnPlayerDataAdded(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerDataRemoved(Action value) { }

	public void SetNetworkDataUpdateKd(float networkDataUpdateKd) { }

}

