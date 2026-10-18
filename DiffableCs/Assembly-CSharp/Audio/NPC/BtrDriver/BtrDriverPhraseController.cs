namespace Audio.NPC.BtrDriver;

public class BtrDriverPhraseController : PhraseController
{
	private const float MUTTER_PHRASES_MIN_COOLDOWN = 25; //Field offset: 0x0
	private const float MUTTER_PHRASES_MAX_COOLDOWN = 30; //Field offset: 0x0
	private readonly IQueueSpeaker _speaker; //Field offset: 0x10
	private readonly IDialogueEventHandler _eventHandler; //Field offset: 0x18
	private float _nextMutterPhrasePlayTime; //Field offset: 0x20
	private readonly BtrDriverSoundDataContainer _driverSoundDataContainer; //Field offset: 0x28

	public BtrDriverPhraseController(BtrDriverSoundBankContainer soundContainer, Transform speakerTransform) { }

	private float CalculateMutterNextPlayingTime() { }

	public virtual void Dispose() { }

	private void OnEventReceived() { }

	protected virtual void OnUpdate(float dt) { }

	private void ResetMutterCooldown() { }

}

