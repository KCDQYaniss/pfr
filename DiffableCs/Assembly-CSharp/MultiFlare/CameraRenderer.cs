namespace MultiFlare;

public class CameraRenderer
{
	private const CameraEvent InjectionEvent = 17; //Field offset: 0x0
	[CompilerGenerated]
	private readonly CommandBuffer <CommandBuffer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Camera <Camera>k__BackingField; //Field offset: 0x18

	public Camera Camera
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected CommandBuffer CommandBuffer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CameraRenderer(Camera camera) { }

	public void ApplyRenderCommands(FlareBatch batch) { }

	public void Dispose() { }

	[CompilerGenerated]
	public Camera get_Camera() { }

	[CompilerGenerated]
	protected CommandBuffer get_CommandBuffer() { }

	public virtual int GetHashCode() { }

	public override void StartRendering() { }

}

