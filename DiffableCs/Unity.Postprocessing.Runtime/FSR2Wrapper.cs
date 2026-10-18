//Type is in global namespace

public class FSR2Wrapper
{
	private ComputeShader _autogenReactiveShader; //Field offset: 0x10
	private ComputeShader _tcrAutogenShader; //Field offset: 0x18
	private ComputeShader _computeLuminancePyramidShader; //Field offset: 0x20
	private ComputeShader _reconstructPreviousDepthShader; //Field offset: 0x28
	private ComputeShader _depthClipShader; //Field offset: 0x30
	private ComputeShader _lockShader; //Field offset: 0x38
	private ComputeShader _accumulateShader; //Field offset: 0x40
	private ComputeShader _rcasShader; //Field offset: 0x48
	private CommandBuffer _cmdBuf; //Field offset: 0x50
	private CommandBuffer _cmdBufBeforeAlpha; //Field offset: 0x58
	private CommandBuffer _cmdBufAfterAlpha; //Field offset: 0x60
	private RenderTexture _upscaledBuf; //Field offset: 0x68
	private RenderTexture _beforeAlpha; //Field offset: 0x70
	private RenderTexture _beforeAlphaPrev0; //Field offset: 0x78
	private RenderTexture _beforeAlphaPrev1; //Field offset: 0x80
	private RenderTexture _afterAlpha; //Field offset: 0x88
	private RenderTexture _afterAlphaPrev0; //Field offset: 0x90
	private RenderTexture _afterAlphaPrev1; //Field offset: 0x98
	private RenderTexture _spd_global_atomic; //Field offset: 0xA0
	private RenderTexture _img_mip; //Field offset: 0xA8
	private RenderTexture _exposure; //Field offset: 0xB0
	private RenderTexture _reactive_mask; //Field offset: 0xB8
	private RenderTexture _transparency_and_composition_mask; //Field offset: 0xC0
	private RenderTexture _dilated_motion_vectors0; //Field offset: 0xC8
	private RenderTexture _dilated_motion_vectors1; //Field offset: 0xD0
	private RenderTexture _internal_upscaled_color0; //Field offset: 0xD8
	private RenderTexture _internal_upscaled_color1; //Field offset: 0xE0
	private RenderTexture _lock_status0; //Field offset: 0xE8
	private RenderTexture _lock_status1; //Field offset: 0xF0
	private RenderTexture _prepared_input_color; //Field offset: 0xF8
	private RenderTexture _luma_history0; //Field offset: 0x100
	private RenderTexture _luma_history1; //Field offset: 0x108
	private RenderTexture _lock_input_luma; //Field offset: 0x110
	private RenderTexture _new_locks; //Field offset: 0x118
	private RenderTexture _dilatedDepth; //Field offset: 0x120
	private RenderTexture _dilated_reactive_masks; //Field offset: 0x128
	private RenderTexture _reconstructed_previous_nearest_depth; //Field offset: 0x130
	private Camera _mainCamera; //Field offset: 0x138
	private MaterialPropertyBlock _propertiesOut; //Field offset: 0x140
	private int mipCount; //Field offset: 0x148
	private bool isOddFrame; //Field offset: 0x14C
	private int frameNum; //Field offset: 0x150
	private float jitterPhaseCount; //Field offset: 0x154
	private Material _matCopySources; //Field offset: 0x158
	private Mesh _mesh; //Field offset: 0x160
	private int[] rcasConfig; //Field offset: 0x168
	private int[] zeroIntVec; //Field offset: 0x170
	private float[] zeroFloatVec; //Field offset: 0x178
	private int[] renderSize; //Field offset: 0x180
	private int[] displaySize; //Field offset: 0x188
	private float[] jitterVec; //Field offset: 0x190
	private float[] deviceToViewDepthVec; //Field offset: 0x198
	private float[] tempFloatVec; //Field offset: 0x1A0
	private int[] tempIntVec; //Field offset: 0x1A8
	private bool _bAfterAlphaSourceIsChanged; //Field offset: 0x1B0
	private RenderTargetIdentifier _rtAfterAlphaSource; //Field offset: 0x1B8

	public FSR2Wrapper(ComputeShader autogenReactiveShader, ComputeShader tcrAutogenShader, ComputeShader computeLuminancePyramidShader, ComputeShader reconstructPreviousDepthShader, ComputeShader depthClipShader, ComputeShader lockShader, ComputeShader accumulateShader, ComputeShader RCASShader, Material CopyDLSSSourcesMat) { }

	private void CalcDeviceDepthToViewSpaceDepthParams(Camera camera) { }

	private void CreateTextureInternal(ref RenderTexture renderTexture, int width, int height, GraphicsFormat format, string name) { }

	private void CreateTextureInternal(ref RenderTexture renderTexture, int width, int height, RenderTextureFormat format, string name) { }

	public void OnDestroy() { }

	public void PrepareOutput(RenderTexture source, RenderTexture destination, Vector2 jitter, int sampleCount, Camera mainCamera, bool opticOrCollimator, CommandBuffer externalCommandBuffer) { }

	private void ReleaseRenderTexture(ref RenderTexture renderTexture) { }

	private void Set_cbFSR2_Constants(ComputeShader shader, CommandBuffer cmdBuf) { }

	public void SetAfterTransparentRT(RenderTexture rt) { }

}

