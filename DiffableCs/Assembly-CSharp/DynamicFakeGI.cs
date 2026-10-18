//Type is in global namespace

[ExecuteInEditMode]
public class DynamicFakeGI : MonoBehaviour
{
	[SerializeField]
	private float intensityMultiplier; //Field offset: 0x20
	[SerializeField]
	private float lightSubtract; //Field offset: 0x24
	[SerializeField]
	private Color hue; //Field offset: 0x28
	[Range(0, 1)]
	public float minMaxWeatherInfluenceAmount; //Field offset: 0x38
	private Light light; //Field offset: 0x40
	private AreaLight areaLight; //Field offset: 0x48
	private Color finalColor; //Field offset: 0x50
	private float h; //Field offset: 0x60
	private float s; //Field offset: 0x64
	private float v; //Field offset: 0x68
	private float ambientColorResult; //Field offset: 0x6C

	public DynamicFakeGI() { }

	private void Start() { }

	private void Update() { }

}

