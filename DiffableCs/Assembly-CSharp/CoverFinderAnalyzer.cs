//Type is in global namespace

public class CoverFinderAnalyzer : BotData
{
	private const float MEASURE_PERIOD = 1; //Field offset: 0x0
	private const int TOO_MUCH_PER_PERIOD = 5; //Field offset: 0x0
	private float _lastCalcCover; //Field offset: 0x18
	private float _lastSecCover; //Field offset: 0x1C
	private int _inSecTimes; //Field offset: 0x20
	private readonly bool _isInited; //Field offset: 0x24

	public CoverFinderAnalyzer(BotOwner botOwner) { }

	public void DoCalcCover() { }

}

