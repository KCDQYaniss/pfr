//Type is in global namespace

public class CameraBufferProvider
{
	private static readonly int _cameraCopyColorBufferId; //Field offset: 0x0
	private const string BUFFER_NAME = "CameraBufferProvider"; //Field offset: 0x0
	private static CameraBufferProvider _instance; //Field offset: 0x8
	private readonly CommandBufferManager _commandBufferManager; //Field offset: 0x10

	public static CameraBufferProvider Instance
	{
		 get { } //Length: 634
	}

	private static CameraBufferProvider() { }

	public CameraBufferProvider() { }

	private bool CanBeRendered(Camera targetCamera, Camera currentCamera) { }

	public void Clear() { }

	public static CameraBufferProvider get_Instance() { }

	private bool Render(Camera camera, out CommandBuffer cmd) { }

	public bool TryGetBuffer(Camera targetCamera, Camera currentCamera, out CommandBuffer cmd) { }

}

