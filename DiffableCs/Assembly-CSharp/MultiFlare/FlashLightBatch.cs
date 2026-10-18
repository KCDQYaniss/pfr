namespace MultiFlare;

public class FlashLightBatch : FlareBatch
{
	private readonly FlareOverlapSettings _settings; //Field offset: 0x58
	private readonly LightStorage _lightStorage; //Field offset: 0x60

	public virtual bool IsInstant
	{
		 get { } //Length: 3
	}

	public FlashLightBatch(ProFlareAtlas atlas, FlareOverlapSettings settings, LightStorage lightStorage) { }

	public virtual bool get_IsInstant() { }

	protected virtual JobHandle ScheduleInternal(JobHandle dependsOn, NativeList flares, NativeList gpuData) { }

}

