//Type is in global namespace

public class BossGluharFollowersSearchData : BotSearchData
{
	private float _nextGotToPoint; //Field offset: 0x50
	private float _comeCloseTime; //Field offset: 0x54
	private BossGluhar _bossGluhar; //Field offset: 0x58

	public BossGluharFollowersSearchData(BotOwner owner) { }

	public virtual void Activate() { }

	private void TryGoTo(Vector3 currPosition) { }

	private void TryGoToCover() { }

	public virtual void UpdateByNode() { }

}

