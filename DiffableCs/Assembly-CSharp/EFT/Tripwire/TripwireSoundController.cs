namespace EFT.Tripwire;

public class TripwireSoundController : ITripwireSoundController, IDisposable
{
	private const float SURFACE_CHECK_RAYCAST_OFFSET = 1; //Field offset: 0x0
	private const float RELEASE_SOURCE_DELAY_OFFSET = 0.5; //Field offset: 0x0
	private readonly TripwireSoundStorageSO _soundStorage; //Field offset: 0x10
	private readonly bool _isFirstPerson; //Field offset: 0x18
	private ESurfaceSound _plantSurface; //Field offset: 0x1C

	public TripwireSoundController(int playerRaidId) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	private EOcclusionTest GetOcclusionTest() { }

	private void PlayAtPoint(IAudioClipContainer clipContainer, Vector3 position, bool spatialize = false) { }

	private void PlayAtPointWithDelay(IAudioClipContainer clipContainer, Vector3 position, float delay, bool spatialize = false) { }

	public override void PlayCollisionSound(Vector3 grenadePos) { }

	public override void PlayFuzeSound(Vector3 grenadePos) { }

	public override void PlayPinSound(Vector3 grenadePos) { }

	public override void PlayPlantSound(Vector3 startPos) { }

}

