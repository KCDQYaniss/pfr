namespace Audio.QueueSpeakerSystem;

public class QueueSpeakerBase : IQueueSpeaker, IDisposable
{
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; //Field offset: 0x10

	public private override bool IsPlaying
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public QueueSpeakerBase() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public override bool get_IsPlaying() { }

	public override void ManualUpdate(float dt = 0) { }

	protected override void OnPlay(SoundBankWithSettings bank, bool stereo = false) { }

	protected override void OnStop() { }

	protected override void OnUpdate(float dt) { }

	public override void Play(SoundBankWithSettings bank, bool stereo = false) { }

	[CompilerGenerated]
	private void set_IsPlaying(bool value) { }

	public override void Stop() { }

}

