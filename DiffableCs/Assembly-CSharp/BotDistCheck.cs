//Type is in global namespace

public class BotDistCheck : BotData
{
	private const int LENGHT = 10; //Field offset: 0x0
	private const int LENGHT1 = 9; //Field offset: 0x0
	private readonly float[] dist; //Field offset: 0x18
	private int _lastIndex; //Field offset: 0x20
	private float _lastSum; //Field offset: 0x24

	public BotDistCheck(BotOwner owner) { }

	public bool CheckIsBadVal(float v, float isGood) { }

}

