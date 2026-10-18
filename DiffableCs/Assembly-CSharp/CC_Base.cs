//Type is in global namespace

[AddComponentMenu(null)]
[RequireComponent(typeof(Camera))]
public class CC_Base : MonoBehaviour
{
	public Shader shader; //Field offset: 0x20
	protected Material _material; //Field offset: 0x28
	protected SSAAPropagator _ssaaPropagator; //Field offset: 0x30

	protected Material material
	{
		 get { } //Length: 435
	}

	public CC_Base() { }

	protected override void Awake() { }

	protected Material get_material() { }

	public static bool IsLinear() { }

	protected override void OnDisable() { }

	protected override void Start() { }

}

