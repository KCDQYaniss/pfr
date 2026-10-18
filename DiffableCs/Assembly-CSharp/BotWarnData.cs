//Type is in global namespace

public class BotWarnData : BotData
{
	private WarnPlayerRequest _warnPlayerRequest; //Field offset: 0x18

	public WarnPlayerRequest WarnPlayerRequest
	{
		 get { } //Length: 5
	}

	public BotWarnData(BotOwner owner) { }

	public void Dispose() { }

	public WarnPlayerRequest get_WarnPlayerRequest() { }

	public void ManualUpdate() { }

	public void StopWarn() { }

	public bool ThrowWarnPlayerRequest(IPlayer playerToWarn, PlayerWarnData dataWarn) { }

}

