//Type is in global namespace

public class BotNeutralsCheskData : BotData
{
	private const float PERIOD_CHECK = 5; //Field offset: 0x0
	private IPlayer _closestsVisible; //Field offset: 0x18
	private float _periodUpdate; //Field offset: 0x20
	private float _settedTime; //Field offset: 0x24

	public IPlayer ClosestsVisible
	{
		 get { } //Length: 5
	}

	public BotNeutralsCheskData(BotOwner owner) { }

	public bool CanSeeNeautral(IPlayer player) { }

	public void Dispose() { }

	public IPlayer get_ClosestsVisible() { }

	public bool IsInPeriod() { }

	public void ManualUpdate() { }

	private void OnIPlayerDeadOrUnspawn(IPlayer obj) { }

	private void SetClosests(IPlayer player) { }

}

