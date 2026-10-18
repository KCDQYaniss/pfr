namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
[ExecuteInEditMode]
public class ColorCorrectionLookup : PostEffectsBase
{
	private static readonly int _scale; //Field offset: 0x0
	private static readonly int _offset; //Field offset: 0x4
	private static readonly int _clutTex; //Field offset: 0x8
	public Shader shader; //Field offset: 0x30
	private Material material; //Field offset: 0x38
	public Texture3D converted3DLut; //Field offset: 0x40
	public string basedOnTempTex; //Field offset: 0x48

	private static ColorCorrectionLookup() { }

	public ColorCorrectionLookup() { }

	public virtual bool CheckResources() { }

	public void Convert(Texture2D temp2DTex, string path) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void SetIdentityLut() { }

	public bool ValidDimensions(Texture2D tex2d) { }

}

