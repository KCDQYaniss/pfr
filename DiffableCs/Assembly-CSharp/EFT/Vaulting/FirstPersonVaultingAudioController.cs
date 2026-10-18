namespace EFT.Vaulting;

public class FirstPersonVaultingAudioController : BaseVaultingAudioController
{

	public FirstPersonVaultingAudioController(Sounds sounds, BetterAudio betterAudio, SpatialAudioSystem spatialSystem, IVaultingSoundsEvents vaultingEvents, IVaultingParameters vaultingParams, Player player, EVaultingSoundType vaultingSoundType) { }

	protected virtual float GetDistanceToCamera() { }

	protected virtual void OnEnd(IAnimatorEventParameter eventParameter) { }

	protected virtual void OnGrab(IAnimatorEventParameter eventParameter) { }

	protected virtual void OnSlide(IAnimatorEventParameter eventParameter) { }

	protected virtual void OnStart(IAnimatorEventParameter eventParameter) { }

}

