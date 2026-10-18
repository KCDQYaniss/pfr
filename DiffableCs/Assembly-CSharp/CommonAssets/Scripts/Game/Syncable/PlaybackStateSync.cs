namespace CommonAssets.Scripts.Game.Syncable;

public class PlaybackStateSync : ISyncAble
{
	[SerializeField]
	private HandlerPlaybackStateBase[] _playbackHandlers; //Field offset: 0x28
	private bool _hasPlaybackSnapshot; //Field offset: 0x30
	private PlaybackSnapshot _playbackSnapshot; //Field offset: 0x34
	private bool _hasPlayStartAnchor; //Field offset: 0x3C
	private float _playStartAuthorityTime; //Field offset: 0x40

	public PlaybackStateSync() { }

	private void Awake() { }

	public virtual void Deserialize(IBitReaderStream readerStream) { }

	private void OnHandlerPlaybackChanged(bool isPlaying) { }

	private void RestorePlaybackSnapshot() { }

	public virtual void Serialize(IBitWriterStream writerStream) { }

}

