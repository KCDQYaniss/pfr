namespace EFT;

public class BeltDetachablePartSpawner : MonoBehaviour
{
	[SerializeField]
	private BeltDetachablePart _beltDetachablePart; //Field offset: 0x20
	[SerializeField]
	private Transform _positionForSpawn; //Field offset: 0x28

	public BeltDetachablePartSpawner() { }

	public void SpawnBeltDetachablePart() { }

}

