//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SSRReplacement : MonoBehaviour
{
	public Shader ssrReplacementShader; //Field offset: 0x20
	public RenderTexture tex; //Field offset: 0x28
	private GameObject _shaderCamera; //Field offset: 0x30
	private Camera replacementCamera; //Field offset: 0x38

	public SSRReplacement() { }

	private void CreateCamera() { }

	private void OnDestroy() { }

	private void OnPostRender() { }

}

