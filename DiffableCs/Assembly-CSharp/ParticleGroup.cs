//Type is in global namespace

public class ParticleGroup : MonoBehaviour
{
	private Vector3[] _positions; //Field offset: 0x20
	private Vector3[] _scales; //Field offset: 0x28
	private float[] _angles; //Field offset: 0x30
	private MeshRenderer _meshRenderer; //Field offset: 0x38
	private MeshFilter _meshFilter; //Field offset: 0x40

	public ParticleGroup() { }

	private void Awake() { }

	private void Check() { }

	private Mesh GetMesh() { }

	private void OnDrawGizmos() { }

}

