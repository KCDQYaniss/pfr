namespace MultiFlare;

public class GameCameraRenderer : CameraRenderer
{
	private readonly SSAA _ssaa; //Field offset: 0x20

	public GameCameraRenderer(Camera camera) { }

	public virtual void StartRendering() { }

}

