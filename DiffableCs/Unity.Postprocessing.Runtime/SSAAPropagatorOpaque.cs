//Type is in global namespace

[ExecuteInEditMode]
public class SSAAPropagatorOpaque : MonoBehaviour
{
	private SSAA m_ssaa; //Field offset: 0x20

	public SSAAPropagatorOpaque() { }

	private void Awake() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

