namespace EFT;

public sealed class NonWavesSpawnScenario : MonoBehaviour
{
	private const float MIN_PERIOD_CHECK = 10; //Field offset: 0x0
	private AbstractGame _game; //Field offset: 0x20
	private Location _location; //Field offset: 0x28
	private BotsController _botsController; //Field offset: 0x30
	private WDictionary _botDifficultiesWights; //Field offset: 0x38
	private WDictionary _wildTypesWeights; //Field offset: 0x40
	private NonWaveGroupScenario _groupScenario; //Field offset: 0x48
	private bool _maxWasReached; //Field offset: 0x50
	private bool _started; //Field offset: 0x51
	private bool _isSpawnTime; //Field offset: 0x52
	private Nullable _botSpawnTime; //Field offset: 0x54
	private float _lastCheckTime; //Field offset: 0x5C
	private float _botSpawnPeriodCheck; //Field offset: 0x60
	[CompilerGenerated]
	private CountTypeBotWave[] <NonWaves>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; //Field offset: 0x70

	public int BotMax
	{
		 get { } //Length: 344
	}

	public private bool Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal CountTypeBotWave[] NonWaves
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public NonWavesSpawnScenario() { }

	internal static NonWavesSpawnScenario Create(AbstractGame game, Location location, BotsController botsController) { }

	public int get_BotMax() { }

	[CompilerGenerated]
	public bool get_Enabled() { }

	[CompilerGenerated]
	internal CountTypeBotWave[] get_NonWaves() { }

	public void ImplementWaveSettings(WavesSettings wavesSettings) { }

	private void Init() { }

	private void InitBaseWight() { }

	private void RefreshPreStartProfiles() { }

	public void Run() { }

	[CompilerGenerated]
	private void set_Enabled(bool value) { }

	[CompilerGenerated]
	private void set_NonWaves(CountTypeBotWave[] value) { }

	public void Stop() { }

	public void Update() { }

}

