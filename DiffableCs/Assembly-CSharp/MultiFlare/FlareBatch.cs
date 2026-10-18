namespace MultiFlare;

public class FlareBatch : IFlareBatch
{
	protected const int InterLoopBatchCount = 100; //Field offset: 0x0
	private static readonly int FlareBufferId; //Field offset: 0x0
	private readonly ProFlareAtlas _atlas; //Field offset: 0x10
	private readonly BatchSettings _settings; //Field offset: 0x18
	private readonly LightStorage _lightStorage; //Field offset: 0x20
	private GraphicsBuffer _gpuBuffer; //Field offset: 0x28
	private NativeList _flares; //Field offset: 0x30
	private NativeList _gpuData; //Field offset: 0x38
	private JobHandle _handle; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Material <Material>k__BackingField; //Field offset: 0x50

	public override int Capacity
	{
		 get { } //Length: 80
	}

	public override bool IsInstant
	{
		 get { } //Length: 3
	}

	public override int Length
	{
		 get { } //Length: 80
	}

	public override Material Material
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static FlareBatch() { }

	public FlareBatch(ProFlareAtlas atlas, BatchSettings settings, LightStorage lightStorage) { }

	public void Add(int lightIndex, Flare flare) { }

	public void ApplyRenderCommands(CommandBuffer commandBuffer) { }

	public void Complete() { }

	public void Dispose() { }

	public override int get_Capacity() { }

	public override bool get_IsInstant() { }

	public override int get_Length() { }

	[CompilerGenerated]
	public override Material get_Material() { }

	private void LogWarning() { }

	public void Remove(int removedLightIndex, int replacedLightIndex) { }

	private void ResizeBuffers() { }

	public void Schedule(JobHandle dependsOn) { }

	protected override JobHandle ScheduleInternal(JobHandle dependsOn, NativeList flares, NativeList gpuData) { }

}

