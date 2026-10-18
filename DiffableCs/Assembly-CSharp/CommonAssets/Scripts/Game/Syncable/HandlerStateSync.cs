namespace CommonAssets.Scripts.Game.Syncable;

public class HandlerStateSync : ISyncAble
{
	[SerializeField]
	private HandlerStateBase[] _handlerStates; //Field offset: 0x28
	private Nullable _state; //Field offset: 0x30

	public HandlerStateSync() { }

	[CompilerGenerated]
	private void <Start>b__2_0(bool nextState) { }

	public virtual void Deserialize(IBitReaderStream readerStream) { }

	private void RestoreState() { }

	public virtual void Serialize(IBitWriterStream writerStream) { }

	private void Start() { }

}

