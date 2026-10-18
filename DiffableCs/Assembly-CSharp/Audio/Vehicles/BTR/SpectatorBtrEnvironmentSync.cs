namespace Audio.Vehicles.BTR;

public class SpectatorBtrEnvironmentSync
{
	private const int INVALID_PLAYER_ID = -1; //Field offset: 0x0
	private readonly BtrSoundController _soundController; //Field offset: 0x10
	private EnvironmentType _spectateListenerEnvironment; //Field offset: 0x18
	private int _spectateTargetPlayerId; //Field offset: 0x1C
	private Action _unsubscribe; //Field offset: 0x20

	public SpectatorBtrEnvironmentSync(BtrSoundController soundController) { }

	private void ApplyListenerEnvironment(EnvironmentType environment, bool fast, IPlayer player) { }

	private static EnvironmentType DeriveEnvironmentFromBtrState(EPlayerBtrState btrState) { }

	public void Dispose() { }

	public void EndObservedPassengerTransition(ObservedPlayerView player) { }

	private static float GetBetterAudioTransitionTime(EnvironmentType environment, bool fast) { }

	public void Initialize() { }

	private bool IsCurrentSpectateTarget(int playerId) { }

	private static bool IsInsideBtr(EPlayerBtrState btrState) { }

	public void NotifyTargetBtrTransition(ObservedPlayerView player, bool fast) { }

	private void OnSpectateTargetChanged(LocalSpectatorTargetChangedEvent targetEvent) { }

}

