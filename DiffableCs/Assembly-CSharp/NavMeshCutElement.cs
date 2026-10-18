//Type is in global namespace

public class NavMeshCutElement : MonoBehaviour
{
	public NavMeshCutGroup Group; //Field offset: 0x20
	public NavMeshObstacle Obstacle; //Field offset: 0x28
	public BoxCollider Collider; //Field offset: 0x30
	private float _unCutTime; //Field offset: 0x38
	public float CutPeriodSec; //Field offset: 0x3C

	public bool IsCut
	{
		 get { } //Length: 90
	}

	public Vector3 Position
	{
		 get { } //Length: 204
	}

	public NavMeshCutElement() { }

	public bool get_IsCut() { }

	public Vector3 get_Position() { }

	public bool HaveFreeToCut() { }

	public bool IsInside(Vector3 pos) { }

	private void OnDrawGizmosSelected() { }

	public void SetUncutTime() { }

	public bool TryCut() { }

	private void Update() { }

}

