//Type is in global namespace

public class LastSoundsController
{
	private const float DIST_IS_KILLER_SQR = 25; //Field offset: 0x0
	private const int neutralSoundsCount = 100; //Field offset: 0x0
	private const int neutralSoundsCountHalf = 50; //Field offset: 0x0
	private const float OlD_TIME = 5; //Field offset: 0x0
	public NeutralSound[] NeutralSounds; //Field offset: 0x10
	private int _lastNeutralSoundIndex; //Field offset: 0x18
	private bool isCycle; //Field offset: 0x1C
	private BotsGroup _group; //Field offset: 0x20
	[CompilerGenerated]
	private ZeroGoalTarget <ZeroGoalTarget>k__BackingField; //Field offset: 0x28

	public private ZeroGoalTarget ZeroGoalTarget
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public LastSoundsController(BotsGroup group) { }

	public void AddNeutralSound(IPlayer player, Vector3 position) { }

	[CompilerGenerated]
	public ZeroGoalTarget get_ZeroGoalTarget() { }

	public NeutralSound GetLastSound() { }

	public IPlayer PossibleKiller(Vector3 pos, float time) { }

	[CompilerGenerated]
	private void set_ZeroGoalTarget(ZeroGoalTarget value) { }

}

