//Type is in global namespace

public class BotDogFight : BotData
{
	private const float DIST_TO_BACK = 2; //Field offset: 0x0
	private float _nextRecalc; //Field offset: 0x18
	private float _posibleCheckCanGo; //Field offset: 0x1C
	private bool _pursuitInProgress; //Field offset: 0x20
	private readonly NavMeshPath _pathCached; //Field offset: 0x28
	[CompilerGenerated]
	private BotDogFightStatus <DogFightState>k__BackingField; //Field offset: 0x30

	public private BotDogFightStatus DogFightState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotDogFight(BotOwner owner) { }

	private bool CheckSpaceForRetreat(out Vector3 trgPos) { }

	public void Fight() { }

	[CompilerGenerated]
	public BotDogFightStatus get_DogFightState() { }

	private bool IsPathGood(NavMeshPath path, float straighDist) { }

	public void ManualUpdate() { }

	[CompilerGenerated]
	private void set_DogFightState(BotDogFightStatus value) { }

	public bool ShallStartCauseHavePlace() { }

	private void StartShootFromPlace() { }

}

