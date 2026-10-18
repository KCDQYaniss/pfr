namespace EFT;

public interface IRaidSettings`1
{

	public bool CanShowGroupPreview
	{
		 get { } //Length: 0
	}

	public bool Local
	{
		 get { } //Length: 0
	}

	public int MaxGroupCount
	{
		 get { } //Length: 0
	}

	public EPlayersSpawnPlace PlayersSpawnPlace
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ERaidMode RaidMode
	{
		 get { } //Length: 0
	}

	public Location SelectedLocation
	{
		 get { } //Length: 0
	}

	public ESideType Side
	{
		 get { } //Length: 0
	}

	public void Apply(TRaidSettings raidSettings) { }

	public void ApplyFromBackend(TRaidSettings raidSettings) { }

	public TRaidSettings Clone() { }

	public bool get_CanShowGroupPreview() { }

	public bool get_Local() { }

	public int get_MaxGroupCount() { }

	public EPlayersSpawnPlace get_PlayersSpawnPlace() { }

	public ERaidMode get_RaidMode() { }

	public Location get_SelectedLocation() { }

	public ESideType get_Side() { }

	public object GetCreateRaidGroupParams() { }

	public EMatchingStatus GetMatchingStatus(int groupCount, EMatchingType matchingType) { }

	public object GetUpdateStatusParams() { }

	public void set_PlayersSpawnPlace(EPlayersSpawnPlace value) { }

}

