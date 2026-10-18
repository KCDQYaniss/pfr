//Type is in global namespace

[AddComponentMenu("Image Effects/HBAO Integrated")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class HBAO_Integrated : HBAO_Core
{
	private CommandBuffer _hbaoCommandBuffer; //Field offset: 0xF0
	private IntegrationStage _integrationStage; //Field offset: 0xF8
	private Resolution _resolution; //Field offset: 0xFC
	private DisplayMode _displayMode; //Field offset: 0x100
	private RenderingPath _renderingPath; //Field offset: 0x104
	private bool _hdr; //Field offset: 0x108
	private int _width; //Field offset: 0x10C
	private int _height; //Field offset: 0x110
	private Quality _aoQuality; //Field offset: 0x114
	private Deinterleaving _deinterleaving; //Field offset: 0x118
	private bool _useMultiBounce; //Field offset: 0x11C
	private bool _colorBleedingEnabled; //Field offset: 0x11D
	private Blur _blurAmount; //Field offset: 0x120
	private bool _prepareInitialCommandBuffer; //Field offset: 0x124

	public HBAO_Integrated() { }

	protected virtual void CheckParameters() { }

	private void ClearCommandBuffer() { }

	private CameraEvent GetCameraEvent() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void OnPreRender() { }

	private void PrepareCommandBufferHBAO(CameraEvent cameraEvent) { }

	private void PrepareCommandBufferHBAODeinterleaved2x(CameraEvent cameraEvent) { }

	private void PrepareCommandBufferHBAODeinterleaved4x(CameraEvent cameraEvent) { }

	private void RenderHBAO(CameraEvent cameraEvent) { }

}

