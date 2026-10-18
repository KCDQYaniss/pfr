//Type is in global namespace

public class ClientLoginResult
{
	public bool Queued; //Field offset: 0x10
	public double BanTime; //Field offset: 0x18
	public IEftSession Session; //Field offset: 0x20
	public ITradingSession TradingSession; //Field offset: 0x28
	public double UtcTime; //Field offset: 0x30
	public string AccountId; //Field offset: 0x38

	public ClientLoginResult() { }

}

