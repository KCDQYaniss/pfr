//Type is in global namespace

public class BotAmbushData : BotData
{
	private const int MAX_AMBUSH_DANGER_LEVEL = 1; //Field offset: 0x0
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0x18

	public BotAmbushData(BotOwner owner) { }

	public CoverSearchData GetCoverSearchData() { }

	public bool HaveCover() { }

	public void SetCoverAtMiddle(CustomNavigationPoint coverInMiddle) { }

	public bool TryGetAmbushPoint(out CustomNavigationPoint ambushPoint) { }

}

