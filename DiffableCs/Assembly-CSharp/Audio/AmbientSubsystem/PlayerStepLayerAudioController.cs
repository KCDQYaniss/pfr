namespace Audio.AmbientSubsystem;

public class PlayerStepLayerAudioController : IPlayerStepAudioController, IDisposable
{
	private const float DEFAULT_SURFACE_MULTIPLIER = 0; //Field offset: 0x0
	private const float MAX_STEP_VOLUME = 1; //Field offset: 0x0
	private readonly float _minStepVolume; //Field offset: 0x10
	private readonly float _overallVolumeMultiplier; //Field offset: 0x14
	private Dictionary _banks; //Field offset: 0x18
	private BetterSource _source; //Field offset: 0x20
	private ESurfaceSound _currentSurface; //Field offset: 0x28
	private bool _isUnderRoof; //Field offset: 0x2C
	private readonly IPlayer _player; //Field offset: 0x30
	private bool _isSourceInit; //Field offset: 0x38

	public PlayerStepLayerAudioController(SurfaceSet surfaceSet, IPlayer player, float minStepVolume = 0.1, bool useOcclusion = false, ESeasonStatus season = 0) { }

	protected override float CalculateFinalVolume(float baseStepVolume, SoundBank bank, bool stereo) { }

	public override void Dispose() { }

	private void FillBanks(SurfaceSet surfaceSet) { }

	private float GetSurfaceVolumeMult() { }

	private void Init(SurfaceSet surfaceSet, IPlayer player, bool useOcclusion) { }

	protected override void InitializeSource(IPlayer player, bool useOcclusion) { }

	public override void Play(EAudioMovementState movementState, EnvironmentType environment, float distance = 0, float baseStepVolume = 1, float blendParameter = 0, bool stereo = false) { }

	private void PlayerEnvironmentChangedHandler(int playerRaidId, EnvironmentType env) { }

	private void ReleaseSource() { }

	public void SetUseOcclusion(bool useOcclusion) { }

	protected bool TryGetBank(EAudioMovementState movementState, out SoundBank bank) { }

	public override void UpdateSoundRolloff(float rolloff) { }

	public override void UpdateSurface(ESurfaceSound surface) { }

	public override void UpdateUnderRoofStatus(bool isUnderRoof) { }

}

