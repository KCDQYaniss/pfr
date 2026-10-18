//Type is in global namespace

public class PlayerSpiritAura : MonoBehaviour
{
	[SerializeField]
	private BoxCollider _collider; //Field offset: 0x20
	[SerializeField]
	private float _boundsExpand; //Field offset: 0x28

	public PlayerSpiritAura() { }

	public Collider GetCollider() { }

	public void UpdateBounds(Bounds localBounds) { }

}

