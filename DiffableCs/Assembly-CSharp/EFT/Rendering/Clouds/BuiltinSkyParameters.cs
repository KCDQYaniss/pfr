namespace EFT.Rendering.Clouds;

public sealed class BuiltinSkyParameters
{
	public float Time; //Field offset: 0x10
	public bool IsAnimate; //Field offset: 0x14
	public Matrix4x4 PixelCoordToViewDirMatrix; //Field offset: 0x18
	public Vector3 WorldSpaceCameraPos; //Field offset: 0x58
	public Matrix4x4 ViewMatrix; //Field offset: 0x64
	public Vector4 ScreenSize; //Field offset: 0xA4
	public CommandBuffer CommandBuffer; //Field offset: 0xB8
	public Light SunLight; //Field offset: 0xC0
	public RenderTargetIdentifier ColorBuffer; //Field offset: 0xC8
	public RenderTargetIdentifier DepthBuffer; //Field offset: 0xF0
	public RenderTargetIdentifier CloudOpacity; //Field offset: 0x118
	public ComputeBuffer CloudAmbientProbe; //Field offset: 0x140
	public int FrameIndex; //Field offset: 0x148
	public CloudSettings CloudSettings; //Field offset: 0x150
	public CubemapFace CubemapFace; //Field offset: 0x158
	public float ExposureMultiplier; //Field offset: 0x15C

	public BuiltinSkyParameters() { }

	public void CopyTo(BuiltinSkyParameters other) { }

}

