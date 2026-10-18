namespace WindowsManagerUtilities;

internal class CameraRenderData
{
	public CommandBuffer CmdBufCulling; //Field offset: 0x10
	public CommandBuffer CmdBufAfterTransparent; //Field offset: 0x18
	public CommandBuffer CmdBufBeforeTransparent; //Field offset: 0x20
	public ComputeBuffer FrustumPlanes; //Field offset: 0x28
	public ComputeBuffer FrustumPNFactors; //Field offset: 0x30
	public ComputeBuffer DrawArgsBufferForeground; //Field offset: 0x38
	public ComputeBuffer DrawArgsBufferBackground; //Field offset: 0x40
	public ComputeBuffer InstancesIDsAfterFrustumCullingForeground; //Field offset: 0x48
	public ComputeBuffer InstancesIDsAfterFrustumCullingBackground; //Field offset: 0x50
	public ComputeBuffer InstancesIDsCountForeground; //Field offset: 0x58
	public ComputeBuffer InstancesIDsCountBackground; //Field offset: 0x60
	public ComputeBuffer OcclusionComputeGroupsCountForegroundBuffer; //Field offset: 0x68
	public ComputeBuffer OcclusionComputeGroupsCountBackgroundBuffer; //Field offset: 0x70
	public ComputeBuffer CameraProjViewMatrixBuffer; //Field offset: 0x78
	public ComputeBuffer CameraParameters; //Field offset: 0x80
	public ComputeBuffer UnpackedOffsetsBuffer; //Field offset: 0x88
	public List ProjViewMatrix; //Field offset: 0x90
	public GPUInstancerHiZOcclusionGenerator HiZGenerator; //Field offset: 0x98
	public MBOIT_Scattering MBOITScattering; //Field offset: 0xA0
	public DistantShadow DistantShadowComponent; //Field offset: 0xA8
	public RenderTexture MomentsRT; //Field offset: 0xB0
	public RenderTexture MomentsRTBackground; //Field offset: 0xB8
	public RenderTexture MomentsRT1; //Field offset: 0xC0
	public RenderTexture MomentsRT1Background; //Field offset: 0xC8
	public RenderTexture FogAlphaRT; //Field offset: 0xD0
	public RenderTexture FogAlphaRTBackground; //Field offset: 0xD8
	public RenderTexture MomentsRT_Quarter; //Field offset: 0xE0
	public RenderTexture MomentsRT1_Quarter; //Field offset: 0xE8
	public RenderTexture TransparentOutput_Quarter; //Field offset: 0xF0
	public RenderTexture TransparentOutput_QuarterBlurBuf; //Field offset: 0xF8
	public RenderTexture TransparentOutput_HiRes; //Field offset: 0x100
	public RenderTexture TransparentOutput_HiResBlurBuf; //Field offset: 0x108
	public RenderTexture TransmittanceSumRcp; //Field offset: 0x110
	public RenderTexture TransmittanceSumRcpBackground; //Field offset: 0x118
	public RenderTexture TransmittanceSumRcpQuarter; //Field offset: 0x120
	public RenderTexture StubDepth; //Field offset: 0x128
	public RenderTexture StubDepth_Quarter; //Field offset: 0x130
	public RenderTexture OpaqueRT; //Field offset: 0x138
	public RenderTexture TransparentsRT; //Field offset: 0x140
	public RenderTexture ForegroundRT; //Field offset: 0x148
	public RenderTexture ScatterBlurBuffer0; //Field offset: 0x150
	public RenderTexture ScatterBlurBuffer1; //Field offset: 0x158
	public Material WindowsMaterial; //Field offset: 0x160
	public int RenderTexturesWidth; //Field offset: 0x168
	public int RenderTexturesHeight; //Field offset: 0x16C
	public Vector3[] PNFactorsBuffer; //Field offset: 0x170
	public RenderTargetIdentifier[] _oitRTIs0; //Field offset: 0x178
	public RenderTargetIdentifier[] _oitRTIsBackground; //Field offset: 0x180
	public RenderTargetIdentifier[] _oitQuarterRTIs; //Field offset: 0x188
	public RenderTargetIdentifier _oitSumRcp; //Field offset: 0x190
	public RenderTargetIdentifier _oitSumRcpBackground; //Field offset: 0x1B8
	public RenderTargetIdentifier _oitSumRcpQuarter; //Field offset: 0x1E0
	public RenderTargetIdentifier _stubDepthRTI; //Field offset: 0x208
	public RenderTargetIdentifier _stubDepthQuarterRTI; //Field offset: 0x230
	public RenderTargetIdentifier _opaqueRTI; //Field offset: 0x258
	public RenderTargetIdentifier _transparentsRTI; //Field offset: 0x280
	public RenderTargetIdentifier _foregroundMBOITResult; //Field offset: 0x2A8
	public RenderTargetIdentifier _transparentOutputQuarterRTI; //Field offset: 0x2D0
	public RenderTargetIdentifier _transparentOutputQuarterBlurBufRTI; //Field offset: 0x2F8
	public RenderTargetIdentifier _finalOutputTarget; //Field offset: 0x320
	public GraphicsFence _unpackedIndexesWriteFence; //Field offset: 0x348
	public RenderTargetIdentifier[] _rtisToClear; //Field offset: 0x358
	public RenderTargetIdentifier[] _rtisToClearBackground; //Field offset: 0x360
	public RenderTargetIdentifier[] _rtisQuarterToClear; //Field offset: 0x368
	public RenderTexture _intermediateRT; //Field offset: 0x370
	public RenderTexture _intermediateRTOut; //Field offset: 0x378
	public RenderTargetIdentifier _intermediateRTI; //Field offset: 0x380
	public SSAA _ssaa; //Field offset: 0x3A8
	public bool _mboitScattering; //Field offset: 0x3B0
	public bool _isScatterThermalVisionIsEnabled; //Field offset: 0x3B1
	public bool _todScatteringEnabled; //Field offset: 0x3B2
	public RenderTexture _distantShadowLowResDepth; //Field offset: 0x3B8
	public Renderer[] _particlesRenderers; //Field offset: 0x3C0

	public CameraRenderData() { }

	private void DestroyRenderTexture(ref RenderTexture rt) { }

	public int GetCameraHeight(Camera camera) { }

	public int GetCameraWidth(Camera camera) { }

	public bool IsMBOITScatterToggled() { }

	public bool MBOITScatter() { }

	public void Release() { }

	private void ReleaseComputeBuffers() { }

	public void ReleaseRenderTextures() { }

	private void ReleaseSingleComputeBuffer(ref ComputeBuffer buf) { }

	public bool ResolutionMismatched(Camera camera) { }

}

