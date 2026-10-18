//Type is in global namespace

public class StuckFPSController
{
	private ThermalVision _thermalVision; //Field offset: 0x10
	private RenderTexture _lastFrame; //Field offset: 0x18
	private float _lastTimeOfCapturedFrame; //Field offset: 0x20

	public StuckFPSController(ThermalVision thermalVision) { }

	public void Destroy() { }

	public void UpdateTexture(CommandBuffer commandBuffer, Camera camera) { }

}

