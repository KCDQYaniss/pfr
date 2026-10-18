namespace Audio.SpatialSystem;

public class AudioBakeDataSerializer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Action onError; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal void <ReadAndWriteToDataContainerAsync>b__0(Exception ex) { }

	}

	private readonly AudioBakeDataWriter _bakeDataWriter; //Field offset: 0x10
	private readonly AudioBakeDataReader _bakeDataReader; //Field offset: 0x18

	public AudioBakeDataSerializer() { }

	public Coroutine ReadAndWriteToDataContainerAsync(MonoBehaviour runner, string bakeDataPath, SpatialAudioDataContainer dataContainer, CancellationToken cancellationToken, Action onDone = null, Action onError = null) { }

	public void Write(SerializableAudioRoutesBakeData bakeDataSo, string pathToSave) { }

}

