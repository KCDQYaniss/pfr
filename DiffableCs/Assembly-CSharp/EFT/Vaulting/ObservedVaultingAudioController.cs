namespace EFT.Vaulting;

public class ObservedVaultingAudioController : BaseVaultingAudioController
{
	private readonly ObservedPlayerView _observedPlayer; //Field offset: 0x68
	private readonly PlayerAudioSettings _audioSettings; //Field offset: 0x70
	private EnvironmentType _environment; //Field offset: 0x78

	private bool PlayAtListener
	{
		private get { } //Length: 30
	}

	public ObservedVaultingAudioController(Sounds sounds, BetterAudio betterAudio, SpatialAudioSystem spatialSystem, IVaultingSoundsEvents vaultingEvents, IVaultingParameters vaultingParams, ObservedPlayerView player, EVaultingSoundType vaultingSoundType, PlayerAudioSettings audioSettings) { }

	private bool get_PlayAtListener() { }

	protected virtual float GetDistanceToCamera() { }

	protected virtual void OnEnd(IAnimatorEventParameter eventParameter) { }

	protected virtual void OnGrab(IAnimatorEventParameter eventParameter) { }

	protected virtual void OnSlide(IAnimatorEventParameter eventParameter) { }

	protected virtual void OnStart(IAnimatorEventParameter eventParameter) { }

	private void SetEnvironment(int playerRaidId, EnvironmentType environment) { }

	protected virtual void Unsubscribe() { }

	private void UpdateSourceRolloff(EAudioMovementState movementState) { }

}

