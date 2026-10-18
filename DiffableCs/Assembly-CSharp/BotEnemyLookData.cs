//Type is in global namespace

public class BotEnemyLookData : BotData
{
	private const float CHECK_PERIOD_SAFE = 0.5; //Field offset: 0x0
	private const float DIST_TO_CHECK = 20; //Field offset: 0x0
	private float _prevCheckTime; //Field offset: 0x18
	private float _nextCheckPeriod; //Field offset: 0x1C
	private float _prevResult; //Field offset: 0x20
	private readonly float _checkPeriod; //Field offset: 0x24
	private readonly bool _onlyIfVisible; //Field offset: 0x28

	public BotEnemyLookData(BotOwner owner, bool onlyIfVisible) { }

	public void DoCheck() { }

	public bool IsEnemyLookAtMeForPeriod(float period) { }

}

