namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class DepthOfField : PostEffectsBase
{
	internal enum BlurSampleCount
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	internal enum BlurType
	{
		DiscBlur = 0,
		DX11 = 1,
	}

	private static readonly int _fgOverlap; //Field offset: 0x0
	private static readonly int _offsets; //Field offset: 0x4
	private static readonly int _curveParams; //Field offset: 0x8
	private static readonly int _blurredColor; //Field offset: 0xC
	private static readonly int _spawnHeuristic; //Field offset: 0x10
	private static readonly int _bokehParams; //Field offset: 0x14
	private static readonly int _fgCocMask; //Field offset: 0x18
	private static readonly int _pointBuffer; //Field offset: 0x1C
	private static readonly int _mainTex; //Field offset: 0x20
	private static readonly int _screen; //Field offset: 0x24
	private static readonly int _lowRez; //Field offset: 0x28
	private float _focalDistance01; //Field offset: 0x30
	private ComputeBuffer _cbDrawArgs; //Field offset: 0x38
	private ComputeBuffer _cbPoints; //Field offset: 0x40
	private float _internalBlurWidth; //Field offset: 0x48
	private Camera _camera; //Field offset: 0x50
	public bool visualizeFocus; //Field offset: 0x58
	public float focalLength; //Field offset: 0x5C
	public float focalSize; //Field offset: 0x60
	public float aperture; //Field offset: 0x64
	public Transform focalTransform; //Field offset: 0x68
	public float maxBlurSize; //Field offset: 0x70
	public bool highResolution; //Field offset: 0x74
	public BlurType blurType; //Field offset: 0x78
	public BlurSampleCount blurSampleCount; //Field offset: 0x7C
	public bool nearBlur; //Field offset: 0x80
	public float foregroundOverlap; //Field offset: 0x84
	public Shader dofHdrShader; //Field offset: 0x88
	private Material dofHdrMaterial; //Field offset: 0x90
	public Shader dx11BokehShader; //Field offset: 0x98
	private Material dx11bokehMaterial; //Field offset: 0xA0
	public float dx11BokehThreshold; //Field offset: 0xA8
	public float dx11SpawnHeuristic; //Field offset: 0xAC
	public Texture2D dx11BokehTexture; //Field offset: 0xB0
	public float dx11BokehScale; //Field offset: 0xB8
	public float dx11BokehIntensity; //Field offset: 0xBC

	private static DepthOfField() { }

	public DepthOfField() { }

	private void Awake() { }

	public virtual bool CheckResources() { }

	public void CopyParametersFrom(DepthOfField other) { }

	private void CreateComputeResources() { }

	private float GetFocalDistance01(float worldDist) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void ReleaseComputeResources() { }

	private void WriteCoc(RenderTexture fromTo, bool fgDilate) { }

}

