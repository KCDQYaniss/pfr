namespace EFT.Impostors;

internal abstract class ImpostorsCameraContextAbstract
{
	private CommandBuffer _cameraCommandBuffer; //Field offset: 0x10
	[CompilerGenerated]
	private Camera <Camera>k__BackingField; //Field offset: 0x18

	public private override Camera Camera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CommandBuffer CameraCommandBuffer
	{
		 get { } //Length: 5
	}

	private static CameraEvent CameraEvent
	{
		private get { } //Length: 6
	}

	protected ImpostorsCameraContextAbstract(Camera camera) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public override Camera get_Camera() { }

	public CommandBuffer get_CameraCommandBuffer() { }

	private static CameraEvent get_CameraEvent() { }

	[CompilerGenerated]
	private void set_Camera(Camera value) { }

}

