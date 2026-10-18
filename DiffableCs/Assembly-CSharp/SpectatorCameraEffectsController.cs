//Type is in global namespace

public class SpectatorCameraEffectsController
{
	private readonly SpectatorHeadDeviceCameraEffectsController _headDevice; //Field offset: 0x10
	private SpectatorBlindnessCameraEffectsController _blindness; //Field offset: 0x18

	public SpectatorCameraEffectsController() { }

	public void ApplyBlindness(ObservedPlayerView observedPlayer, bool isLive) { }

	public void ApplyFaceShield(ObservedPlayerView observedPlayer) { }

	public void ClearBlindness() { }

	public void ResetEffects() { }

	public void SyncFromObservedPlayer(ObservedPlayerView observedPlayer) { }

}

