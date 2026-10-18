//Type is in global namespace

public class BossKillaSearchData : BotSearchData
{
	private float _nextGotToPoint; //Field offset: 0x50
	private float _comeCloseTime; //Field offset: 0x54

	public BossKillaSearchData(BotOwner owner) { }

	public virtual void Activate() { }

	private void TryGoTo(Vector3 currPosition) { }

	private void TryGoToCover() { }

	public virtual void UpdateByNode() { }

}

