namespace EFT;

public class ObjectFollower : MonoBehaviour
{
	internal struct Line
	{
		public Vector3 Point1; //Field offset: 0x0
		public Vector3 Point2; //Field offset: 0xC

		public Vector3 GetNearestPointOnLine(Vector3 position) { }

	}

	[SerializeField]
	private Transform _object; //Field offset: 0x20
	[SerializeField]
	private List _lines; //Field offset: 0x28

	public ObjectFollower() { }

	public void Follow(Vector3 position) { }

	private Vector3 GetNearestPoint(Vector3 worldPosition) { }

}

