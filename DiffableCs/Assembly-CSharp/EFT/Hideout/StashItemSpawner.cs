namespace EFT.Hideout;

public sealed class StashItemSpawner : MonoBehaviour
{
	public GameObject ObjectToSpawn; //Field offset: 0x20
	public float RateOfSpawn; //Field offset: 0x28
	private float nextSpawn; //Field offset: 0x2C

	public StashItemSpawner() { }

	private void Update() { }

}

