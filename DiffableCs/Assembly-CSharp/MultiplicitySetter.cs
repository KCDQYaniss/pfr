//Type is in global namespace

public class MultiplicitySetter : MonoBehaviour
{
	public Camera Camera; //Field offset: 0x20
	public float BaseFov; //Field offset: 0x28
	public float Multiplicity; //Field offset: 0x2C
	private float _baseTangent; //Field offset: 0x30

	public MultiplicitySetter() { }

	private float FovToMultiplicity(float fov) { }

	private float MultiplicityToFov(float multiplicity) { }

	private void OnValidate() { }

	public void SetMultiplicity(float multiplicity) { }

	private void Start() { }

}

