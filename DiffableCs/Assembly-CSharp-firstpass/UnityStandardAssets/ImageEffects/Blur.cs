namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Blur/Blur")]
[ExecuteInEditMode]
public class Blur : MonoBehaviour
{
	private static Material m_Material; //Field offset: 0x0
	public int iterations; //Field offset: 0x20
	public float blurSpread; //Field offset: 0x24
	public Shader blurShader; //Field offset: 0x28

	protected Material material
	{
		 get { } //Length: 493
	}

	public Blur() { }

	private void DownSample4x(RenderTexture source, RenderTexture dest) { }

	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) { }

	protected Material get_material() { }

	protected void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected void Start() { }

}

