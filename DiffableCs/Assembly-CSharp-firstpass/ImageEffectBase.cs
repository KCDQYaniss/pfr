//Type is in global namespace

[AddComponentMenu(null)]
[RequireComponent(typeof(Camera))]
public class ImageEffectBase : MonoBehaviour
{
	public Shader shader; //Field offset: 0x20
	private Material m_Material; //Field offset: 0x28
	protected SSAAPropagator _ssaaPropagator; //Field offset: 0x30

	protected Material material
	{
		 get { } //Length: 435
	}

	public ImageEffectBase() { }

	protected override void Awake() { }

	protected Material get_material() { }

	protected override void OnDisable() { }

	protected override void Start() { }

}

