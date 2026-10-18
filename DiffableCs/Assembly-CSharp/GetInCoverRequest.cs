//Type is in global namespace

internal class GetInCoverRequest : BotRequest
{
	private Nullable _nearestPoint; //Field offset: 0x70
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0x80
	private float _nextCheckCoverInMiddle; //Field offset: 0x88
	private float _endAfterTake; //Field offset: 0x8C

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 3
	}

	public GetInCoverRequest(Player requester, Nullable nearestPoint, float period = 0) { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	protected CoverSearchData CoverData() { }

	public virtual void Dispose() { }

	public virtual AICoreActionEnd EndHoldPosition() { }

	public virtual bool FindPoint(CoverSearchData data, Func func, bool checkCurrent, out CustomNavigationPoint customNavigationPoint) { }

	public virtual EBotRequestMode get_RequestMode() { }

	protected void RecheckCoverAtMiddle() { }

}

