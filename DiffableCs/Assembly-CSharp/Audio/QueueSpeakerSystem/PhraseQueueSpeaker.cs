namespace Audio.QueueSpeakerSystem;

public class PhraseQueueSpeaker : QueueSpeakerBase
{
	[IsReadOnly]
	private struct QueueData
	{
		public readonly SoundBankWithSettings Bank; //Field offset: 0x0
		public readonly bool Stereo; //Field offset: 0x8

		public QueueData(SoundBankWithSettings bank, bool stereo) { }

	}

	private const float DELAY_BETWEEN_CLIPS = 1; //Field offset: 0x0
	private readonly Queue _phraseQueue; //Field offset: 0x18
	private readonly Transform _transform; //Field offset: 0x20
	private readonly BetterSource _source; //Field offset: 0x28
	private float _timeToPlayNextClip; //Field offset: 0x30
	private int _lastBankImportance; //Field offset: 0x34

	public virtual bool IsPlaying
	{
		 get { } //Length: 30
	}

	public PhraseQueueSpeaker(Transform speakerTransform, BetterSource source) { }

	public virtual void Dispose() { }

	public virtual bool get_IsPlaying() { }

	protected virtual void OnPlay(SoundBankWithSettings bank, bool stereo = false) { }

	protected virtual void OnStop() { }

	protected virtual void OnUpdate(float dt) { }

}

