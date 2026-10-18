//Type is in global namespace

public class AutoPopper : MonoBehaviour
{
	public Transform MovingPart; //Field offset: 0x20
	public BallisticCollider Target; //Field offset: 0x28
	public Vector3 DefaultRotation; //Field offset: 0x30
	public Vector3 HitRotation; //Field offset: 0x3C
	public float HitTime; //Field offset: 0x48
	private float _hitTime; //Field offset: 0x4C

	public AutoPopper() { }

	private void Start() { }

	private void TargetOnOnHitAction(DamageInfo obj) { }

	private void Update() { }

}

