//Type is in global namespace

public sealed class CommandBufferManager
{
	private readonly Dictionary _versions; //Field offset: 0x10
	public readonly Dictionary Cameras; //Field offset: 0x18
	public readonly string BufferName; //Field offset: 0x20
	public readonly CameraEvent CameraEvent; //Field offset: 0x28

	public CommandBufferManager(string bufferName, CameraEvent cameraEvent) { }

	public void Destroy() { }

	private static CommandBuffer Find(Camera camera, CameraEvent cameraEvent, string name) { }

	public static CommandBuffer FindOrCreate(Camera camera, CameraEvent cameraEvent, string name) { }

	public CommandBuffer TryGetOrCreate(Camera camera) { }

	public bool TryGetOrCreate(out CommandBuffer buffer) { }

	public bool UpdateVersion(Camera camera, int version, out CommandBuffer buffer) { }

}

