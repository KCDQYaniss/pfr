//Type is in global namespace

public class SyncableAudioMuteState : ISyncAble
{
	[SerializeField]
	private HandlerAudioSourceMute[] _handlersAudioSourceMute; //Field offset: 0x28
	private Nullable _state; //Field offset: 0x30

	public SyncableAudioMuteState() { }

	[CompilerGenerated]
	private void <Start>b__2_0(bool nextState) { }

	public virtual void Deserialize(IBitReaderStream readerStream) { }

	private void RestoreState() { }

	public virtual void Serialize(IBitWriterStream writerStream) { }

	private void Start() { }

}

