//Type is in global namespace

[ExecuteInEditMode]
public class CheatShotLogVisualizer : MonoBehaviour
{
	private Vector3 _aggressorPosition; //Field offset: 0x20
	private Vector3 _shotStart; //Field offset: 0x2C
	private Vector3 _shotEnd; //Field offset: 0x38
	private Vector3 _victimPosition; //Field offset: 0x44
	private Vector3 _victimPartPosition; //Field offset: 0x50
	private string _bodyPart; //Field offset: 0x60
	private Vector3[] _collisions; //Field offset: 0x68
	private Vector3[] _invalidCollisions; //Field offset: 0x70
	private float _distance; //Field offset: 0x78
	[SerializeField]
	private float _radius1; //Field offset: 0x7C
	[SerializeField]
	private float _radius2; //Field offset: 0x80
	[SerializeField]
	private float _radius3; //Field offset: 0x84

	public CheatShotLogVisualizer() { }

	public static CheatShotLogVisualizer Create(string name, Vector3 aggressorPosition, Vector3 shotDirection, Vector3 shotStart, Vector3 shotEnd, Vector3 victimPosition, Vector3 victimPartPosition, string bodyPart, Vector3[] collisions, Vector3[] invalidCollisions) { }

	public void Init(Vector3 aggressorPosition, Vector3 shotDirection, Vector3 shotStart, Vector3 shotEnd, Vector3 victimPosition, Vector3 victimPartPosition, string bodyPart, Vector3[] collisions, Vector3[] invalidCollisions) { }

}

