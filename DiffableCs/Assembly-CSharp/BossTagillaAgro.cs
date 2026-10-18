//Type is in global namespace

public class BossTagillaAgro : BossTagilla
{
	private const string AGRO_HELPERS_EVENT = "AGRO_HELPERS_EVENT"; //Field offset: 0x0
	private const string MASS_HELPERS_EVENT = "MASS_HELPERS_EVENT"; //Field offset: 0x0
	private const int _ENEMIES_TO_SPAWN = 3; //Field offset: 0x0
	private const int MAX_PREWARERPLANTED = 10; //Field offset: 0x0
	private const float SDIST_PREWARM = 225; //Field offset: 0x0
	public const float SDIST_SAFE_PREWARM = 16; //Field offset: 0x0
	private float PERIOD_TO_CALL; //Field offset: 0x48
	private int _calledTimes; //Field offset: 0x4C
	private AIPeriodAction _periodCheckHelpersTime; //Field offset: 0x50
	private AIPeriodAction _periodCheckHelpersMany; //Field offset: 0x58
	private List _listOfPrewarms; //Field offset: 0x60
	private bool _isMinesPrewarmed; //Field offset: 0x68
	private bool _isManyEnemiesCalled; //Field offset: 0x69

	public BossTagillaAgro(BotOwner owner, BotBoss bossLogic) { }

	public virtual void BossLogicUpdate() { }

	private void ChecksHelpers() { }

	private void ChecksHelpersMany() { }

	private void PrewarmMines() { }

}

