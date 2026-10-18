namespace EFT.Vaulting;

public abstract class BaseVaultingAudioController : IDisposable
{
	private const float SURFACE_CHECK_RAYCAST_OFFSET = 0.5; //Field offset: 0x0
	private const float VAULTING_POINT_HEIGHT_OFFSET = 0.1; //Field offset: 0x0
	private const float VAULTING_SPHERE_CAST_RADIUS = 0.1; //Field offset: 0x0
	private readonly IVaultingParameters _vaultingParameters; //Field offset: 0x10
	private readonly Sounds _sounds; //Field offset: 0x18
	private readonly BetterAudio _betterAudio; //Field offset: 0x20
	private readonly SpatialAudioSystem _spatialSystem; //Field offset: 0x28
	private readonly Dictionary _soundBySurface; //Field offset: 0x30
	private readonly LayerMask _castMask; //Field offset: 0x38
	private int _rolloff; //Field offset: 0x3C
	private SoundBank _gearSoundBank; //Field offset: 0x40
	private float _baseVolume; //Field offset: 0x48
	protected readonly EVaultingSoundType SoundType; //Field offset: 0x4C
	protected readonly IVaultingSoundsEvents VaultingEvents; //Field offset: 0x50
	protected readonly IPlayer Player; //Field offset: 0x58
	protected ESurfaceSound CurrentObstacleSurface; //Field offset: 0x60
	protected ESurfaceSound CurrentTerrainSurface; //Field offset: 0x64

	protected BaseVaultingAudioController(Sounds sounds, BetterAudio betterAudio, SpatialAudioSystem spatialSystem, IVaultingSoundsEvents vaultingEvents, IVaultingParameters vaultingParams, IPlayer player, EVaultingSoundType vaultingSoundType) { }

	private void ChooseGearBank() { }

	public override void Dispose() { }

	private void FillSoundDictionary() { }

	protected abstract float GetDistanceToCamera() { }

	private void Init() { }

	protected override void OnEnd(IAnimatorEventParameter eventParameter) { }

	protected override void OnGrab(IAnimatorEventParameter eventParameter) { }

	protected override void OnSlide(IAnimatorEventParameter eventParameter) { }

	protected override void OnStart(IAnimatorEventParameter eventParameter) { }

	protected override void PlayGearSound(bool stereo = true) { }

	protected void PlaySound(SoundBank bank, in VolumeRange volumeRange, bool stereo = true) { }

	protected void PlaySound(SoundBank bank, float minVolume = 0.1, float maxVolume = 1, bool stereo = true) { }

	public void SetBaseVolume(float volume) { }

	protected void SetSourceRolloff(int rolloff) { }

	protected override void Subscribe() { }

	private bool TryGetSurface(in RaycastHit hit, out ESurfaceSound surface) { }

	private bool TryGetSurfaceByRaycast(Vector3 startPos, Vector3 endPos, float maxDistance, out ESurfaceSound surface) { }

	private bool TryGetSurfaceBySphereCast(Vector3 startPos, Vector3 direction, float radius, float maxDistance, out ESurfaceSound surface) { }

	protected bool TryGetSurfaceSet(ESurfaceSound surface, out SurfaceSet surfaceSet) { }

	protected bool TryGetVaultingSoundElement(EVaultingSoundState soundState, ESurfaceSound surfaceSound, out VaultingSoundElement soundElement) { }

	protected override void Unsubscribe() { }

	private void UpdateObstacleSurface() { }

	private void UpdateTerrainSurface() { }

}

