//Type is in global namespace

public class AlwaysSearchData : BotSearchData
{
	private float _nextGotToPoint; //Field offset: 0x50
	private float _nextGotToPointCheck; //Field offset: 0x54
	private Vector3 _littleRndCache; //Field offset: 0x58
	private float _littleRndRefreshCacheTime; //Field offset: 0x64
	private float _comeCloseTime; //Field offset: 0x68

	public AlwaysSearchData(BotOwner owner) { }

	public virtual void Activate() { }

	private void TryGoTo(Vector3 currPosition) { }

	private void TryGoToCover() { }

	public virtual void UpdateByNode() { }

}

