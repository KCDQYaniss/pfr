//Type is in global namespace

public class BotBewarePlantedMine : BotData
{
	private const float SDITS_TO_WORK_WITH = 25; //Field offset: 0x0
	private float _nextCheck; //Field offset: 0x18
	private PlantedMineAIInfo _deactivating; //Field offset: 0x20
	private bool _nextChance; //Field offset: 0x28
	private bool _isAtProcessDeactivating; //Field offset: 0x29
	private float _deativateFinish; //Field offset: 0x2C
	private AIPeriodAction _pringError; //Field offset: 0x30
	private float _distCheck; //Field offset: 0x38
	private bool _lastDistCheck; //Field offset: 0x3C
	private float POSSIBLE_TIME_ENEMY_TO_DEAC; //Field offset: 0x40

	public PlantedMineAIInfo DeactivatingPlace
	{
		 get { } //Length: 5
	}

	public BotBewarePlantedMine(BotOwner owner) { }

	public void Activate() { }

	private void ActivateInfoPrint() { }

	public bool CanDeactivate() { }

	public void Dispose() { }

	public void DoDeactivateCurrent() { }

	public PlantedMineAIInfo get_DeactivatingPlace() { }

	private void OnDisposed(PlantedMineAIInfo obj) { }

	private void OnVoxelChange(NavGraphVoxelSimple obj) { }

	private void SetMineToDeactivate(PlantedMineAIInfo toDeactivate) { }

	public void Update() { }

}

