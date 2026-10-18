namespace EFT.Interactive;

public class LootGun : MonoBehaviour
{
	[SerializeField]
	private float _castDistance; //Field offset: 0x20
	[SerializeField]
	private Vector3 _localStartPoint; //Field offset: 0x24
	[SerializeField]
	private float _boundsMult; //Field offset: 0x30
	[SerializeField]
	private float _force; //Field offset: 0x34
	[SerializeField]
	private Vector2 _forceRange; //Field offset: 0x38
	[SerializeField]
	private float _forceStep; //Field offset: 0x40
	private Item _item; //Field offset: 0x48
	private GameObject _loadedLoot; //Field offset: 0x50
	private List _thrownItems; //Field offset: 0x58

	public LootGun() { }

	private void Clear() { }

	private void FindLoot() { }

	private void Load(Item item) { }

	private void Throw() { }

	private void Update() { }

}

