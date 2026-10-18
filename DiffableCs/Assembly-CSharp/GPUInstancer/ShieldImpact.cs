namespace GPUInstancer;

public class ShieldImpact : MonoBehaviour
{
	private static readonly int _impactTime; //Field offset: 0x0
	private static readonly int _impactPosition; //Field offset: 0x4
	private float impactTime; //Field offset: 0x20
	private Material impactMat; //Field offset: 0x28

	private static ShieldImpact() { }

	public ShieldImpact() { }

	private void Awake() { }

	private void OnCollisionEnter(Collision collision) { }

	private void Update() { }

}

