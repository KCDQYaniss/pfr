//Type is in global namespace

[ExecuteInEditMode]
public class EasySuspension : MonoBehaviour
{
	[Range(0.1, 20)]
	[Tooltip("Natural frequency of the suspension springs. Describes bounciness of the suspension.")]
	public float naturalFrequency; //Field offset: 0x20
	[Range(0, 3)]
	[Tooltip("Damping ratio of the suspension springs. Describes how fast the spring returns back after a bounce. ")]
	public float dampingRatio; //Field offset: 0x24
	[Range(-1, 1)]
	[Tooltip("The distance along the Y axis the suspension forces application point is offset below the center of mass")]
	public float forceShift; //Field offset: 0x28
	[Tooltip("Adjust the length of the suspension springs according to the natural frequency and damping ratio. When off, can cause unrealistic suspension bounce.")]
	public bool setSuspensionDistance; //Field offset: 0x2C
	private Rigidbody m_Rigidbody; //Field offset: 0x30

	public EasySuspension() { }

	public void SetRigidbody(Rigidbody rigidbody) { }

	private void Update() { }

}

