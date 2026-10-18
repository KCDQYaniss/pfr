//Type is in global namespace

public class BotsGroupGrenade
{
	private const float STANDART_PERIOD = 2; //Field offset: 0x0
	private const float START_PERIOD = 5; //Field offset: 0x0
	private int _throwCount; //Field offset: 0x10
	private float _endThrow; //Field offset: 0x14
	private float _nextPossibleThrowRequest; //Field offset: 0x18

	public BotsGroupGrenade() { }

	public bool CanThrow() { }

	public bool CanThrowByGroup() { }

	public void SetThrowRequest() { }

	public void ThrowGrenade(BotOwner thrower) { }

}

