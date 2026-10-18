//Type is in global namespace

public class PainScreen : MonoBehaviour
{
	private static readonly int _value1; //Field offset: 0x0
	[Range(0, 1)]
	[SerializeField]
	private float _value; //Field offset: 0x20
	[SerializeField]
	private Material _mat; //Field offset: 0x28

	private static PainScreen() { }

	public PainScreen() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

}

