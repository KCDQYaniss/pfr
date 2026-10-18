//Type is in global namespace

public class AnimatorSync : ISyncAble
{
	[SerializeField]
	private Animator _animator; //Field offset: 0x28

	private int LayerIndex
	{
		private get { } //Length: 3
	}

	public AnimatorSync() { }

	public virtual void Deserialize(IBitReaderStream readerStream) { }

	private int get_LayerIndex() { }

	private void ReadParameters(IBitReaderStream reader) { }

	public virtual void Serialize(IBitWriterStream writer) { }

	private void Start() { }

	private void WriteParameters(IBitWriterStream writer) { }

}

