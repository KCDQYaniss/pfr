//Type is in global namespace

public class PixelationController
{
	internal enum PixelationMode
	{
		Point = 0,
		CRT = 1,
		None = 10,
	}

	private static readonly int _pixelBlockCount; //Field offset: 0x0
	private static readonly int _pixelBlockSize; //Field offset: 0x4
	private static readonly int _pixelationMask; //Field offset: 0x8
	private static readonly int _alpha; //Field offset: 0xC
	private static readonly int _pixelationTempRT; //Field offset: 0x10
	private Camera _camera; //Field offset: 0x10
	private ThermalVision _thermalVision; //Field offset: 0x18
	private Material _material; //Field offset: 0x20

	private static PixelationController() { }

	public PixelationController(ThermalVision thermalVision, Camera camera) { }

	private Material GetMaterial() { }

	private void SetMaterialProperties() { }

	public void UpdateTexture(CommandBuffer commandBuffer) { }

}

