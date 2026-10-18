//Type is in global namespace

public class Rotator : MonoBehaviour
{
	[SerializeField]
	private Vector3 _axis; //Field offset: 0x20
	[SerializeField]
	private float _speed; //Field offset: 0x2C

	public Rotator() { }

	private void LateUpdate() { }

}

