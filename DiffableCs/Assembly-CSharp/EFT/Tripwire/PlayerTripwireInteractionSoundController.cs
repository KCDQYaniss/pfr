namespace EFT.Tripwire;

public class PlayerTripwireInteractionSoundController : ISoundInteractionController, IDisposable
{
	private const float CHECK_DISTANCE_MULTIPLIER = 2; //Field offset: 0x0
	private readonly bool _isFirstPerson; //Field offset: 0x10
	private readonly IPlayer _player; //Field offset: 0x18
	private readonly BetterAudio _betterAudio; //Field offset: 0x20
	private readonly TripwireSoundStorageSO _soundStorage; //Field offset: 0x28
	private BetterSource _source; //Field offset: 0x30

	public PlayerTripwireInteractionSoundController(IPlayer player) { }

	public override void Dispose() { }

	private bool IsInRange(Vector3 position, float maxDistance, float mult = 1) { }

	public override void PlayInteractionSound(bool hasSpecialItem = false) { }

	private void ReleaseSource() { }

	public override void StopInteractionSound(bool interactionSuccess, bool hasSpecialItem = false) { }

	private void StopLoopSound() { }

}

