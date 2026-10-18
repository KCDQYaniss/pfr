namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class NoiseAndGrain : PostEffectsBase
{
	private static float TILE_AMOUNT; //Field offset: 0x0
	private static readonly int _dx11NoiseTime; //Field offset: 0x4
	private static readonly int _noiseTex; //Field offset: 0x8
	private static readonly int _noisePerChannel; //Field offset: 0xC
	private static readonly int _midGrey; //Field offset: 0x10
	private static readonly int _noiseAmount; //Field offset: 0x14
	private static readonly int _noiseTilingPerChannel; //Field offset: 0x18
	private static readonly int _mainTex; //Field offset: 0x1C
	public float intensityMultiplier; //Field offset: 0x30
	public float generalIntensity; //Field offset: 0x34
	public float blackIntensity; //Field offset: 0x38
	public float whiteIntensity; //Field offset: 0x3C
	public float midGrey; //Field offset: 0x40
	public bool dx11Grain; //Field offset: 0x44
	public float softness; //Field offset: 0x48
	public bool monochrome; //Field offset: 0x4C
	public Vector3 intensities; //Field offset: 0x50
	public Vector3 tiling; //Field offset: 0x5C
	public float monochromeTiling; //Field offset: 0x68
	public FilterMode filterMode; //Field offset: 0x6C
	public Texture2D noiseTexture; //Field offset: 0x70
	public Shader noiseShader; //Field offset: 0x78
	private Material noiseMaterial; //Field offset: 0x80
	public Shader dx11NoiseShader; //Field offset: 0x88
	private Material dx11NoiseMaterial; //Field offset: 0x90

	private static NoiseAndGrain() { }

	public NoiseAndGrain() { }

	public virtual bool CheckResources() { }

	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

