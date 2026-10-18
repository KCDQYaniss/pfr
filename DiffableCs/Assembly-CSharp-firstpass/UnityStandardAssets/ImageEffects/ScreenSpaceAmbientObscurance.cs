namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
internal class ScreenSpaceAmbientObscurance : PostEffectsBase
{
	private static readonly int _axis; //Field offset: 0x0
	private static readonly int _aoTex; //Field offset: 0x4
	private static readonly int _projInfo; //Field offset: 0x8
	private static readonly int _projectionInv; //Field offset: 0xC
	private static readonly int _rand; //Field offset: 0x10
	private static readonly int _radius; //Field offset: 0x14
	private static readonly int _radius2; //Field offset: 0x18
	private static readonly int _intensity; //Field offset: 0x1C
	private static readonly int _blurFilterDistance; //Field offset: 0x20
	[Range(0, 3)]
	public float intensity; //Field offset: 0x30
	[Range(0.1, 3)]
	public float radius; //Field offset: 0x34
	[Range(0, 3)]
	public int blurIterations; //Field offset: 0x38
	[Range(0, 5)]
	public float blurFilterDistance; //Field offset: 0x3C
	[Range(0, 1)]
	public int downsample; //Field offset: 0x40
	public Texture2D rand; //Field offset: 0x48
	public Shader aoShader; //Field offset: 0x50
	private Material aoMaterial; //Field offset: 0x58

	private static ScreenSpaceAmbientObscurance() { }

	public ScreenSpaceAmbientObscurance() { }

	public virtual bool CheckResources() { }

	private void OnDisable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

