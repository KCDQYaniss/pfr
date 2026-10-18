//Type is in global namespace

public class BotCallForHelp : BotData
{
	private const float COMPUTE_PATH_LENGTH_PERIOD = 0.35; //Field offset: 0x0
	private const float SAVAGE_CALL_PERIOD = 5; //Field offset: 0x0
	private PanicType _originalPanicType; //Field offset: 0x18
	private float _pathToEnemyLength; //Field offset: 0x1C
	private float _prevComputePathLengthTime; //Field offset: 0x20
	private float _lastSavageCallTime; //Field offset: 0x24
	private bool _savagesCalled; //Field offset: 0x28
	private EnemyInfo _prevTarget; //Field offset: 0x30

	private BotGlobalsBossSettings BossSettings
	{
		private get { } //Length: 45
	}

	public BotCallForHelp(BotOwner owner) { }

	private bool BotMayBeCalled(BotOwner neutral) { }

	public void CallForSavages() { }

	private void FreeBot(BotOwner neutral) { }

	public void FreeSavages(BotOwner target) { }

	private BotGlobalsBossSettings get_BossSettings() { }

	private bool MayFreeSavages() { }

	private float PathToEnemyLengthByNavMesh() { }

	private bool TryCallBot(BotOwner calledBot) { }

	public bool WantCallForSavages() { }

}

