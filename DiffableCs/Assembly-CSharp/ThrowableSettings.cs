//Type is in global namespace

public class ThrowableSettings : MonoBehaviour
{
	[SerializeField]
	public Vector3 Offset; //Field offset: 0x20
	[Header("Threshold sqrMagnitude")]
	[SerializeField]
	public float VelocityTreshold; //Field offset: 0x2C

	public ThrowableSettings() { }

}

