namespace UI.Seasons;

public class SeasonRanksDataStorage
{
	public SeasonsRankInfo[] RanksInfo; //Field offset: 0x10
	public SeasonsRanksPlayerState PlayerState; //Field offset: 0x18
	public SeasonsLeaderboardInfo LeaderboardInfo; //Field offset: 0x20
	public DateTime LeaderboardLastUpdate; //Field offset: 0x28

	public SeasonRanksDataStorage() { }

}

