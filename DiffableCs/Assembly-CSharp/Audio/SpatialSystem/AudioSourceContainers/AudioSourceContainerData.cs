namespace Audio.SpatialSystem.AudioSourceContainers;

public class AudioSourceContainerData : IDataContainer
{
	private const int POOL_SIZE = 50; //Field offset: 0x0
	private const int INCREASE_POOL_STEP = 5; //Field offset: 0x0
	private readonly PoolWithoutAlloc _audioContainersPool; //Field offset: 0x10
	private int _nextID; //Field offset: 0x18

	public AudioSourceContainerData() { }

	public AudioSourceContainer GetContainer(Transform transform, EOcclusionTest test) { }

	public void ReturnContainer(AudioSourceContainer container) { }

}

