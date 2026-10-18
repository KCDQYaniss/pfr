//Type is in global namespace

[RequireComponent(typeof(Camera))]
public class InventoryBlur : MonoBehaviour
{
	internal enum Dimensions
	{
		_128 = 128,
		_256 = 256,
		_512 = 512,
		_1024 = 1024,
		_2048 = 2048,
	}

	private static readonly int _blurTex; //Field offset: 0x0
	private static readonly int _value1; //Field offset: 0x4
	[Header("Blur Setup")]
	[Range(0, 1)]
	[SerializeField]
	private float _value; //Field offset: 0x20
	[SerializeField]
	private Material _material; //Field offset: 0x28
	[SerializeField]
	private Dimensions _upsampleTexDimension; //Field offset: 0x30
	[SerializeField]
	private Dimensions _downsampleTexDimension; //Field offset: 0x34
	[Range(1, 8)]
	[SerializeField]
	private int _blurCount; //Field offset: 0x38
	private float _time; //Field offset: 0x3C
	private bool _enabling; //Field offset: 0x40
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x48

	private static InventoryBlur() { }

	public InventoryBlur() { }

	private void Awake() { }

	public void Disable() { }

	public void Enable(float time = 0.5) { }

	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void Update() { }

}

