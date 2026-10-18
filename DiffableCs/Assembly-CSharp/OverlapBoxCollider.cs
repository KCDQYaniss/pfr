//Type is in global namespace

public class OverlapBoxCollider
{
	private const int MAX_COLLIDERS_OVERLAP = 20; //Field offset: 0x0
	private readonly Collider[] _colliders; //Field offset: 0x10
	private readonly BoxCollider _boxCollider; //Field offset: 0x18
	private readonly LayerMask _mask; //Field offset: 0x20

	public OverlapBoxCollider(BoxCollider collider, LayerMask mask, int maxCollidersCount = 20) { }

	private ValueTuple BoxColliderParams() { }

	private int OverlapBoxNonAlloc(Collider[] results) { }

	public void OverlapNonAlloc(Action colliderCallback) { }

	private Vector3 Vector3Abc(Vector3 vector) { }

}

