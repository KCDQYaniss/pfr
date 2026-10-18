namespace EFT.Interactive;

public class GroupLootPoint : MonoBehaviour
{
	[SerializeField]
	private float _weight; //Field offset: 0x20

	public float Weight
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public GroupLootPoint() { }

	public void ApplyParameters(WeightedLootPointSpawnPosition parameters) { }

	public WeightedLootPointSpawnPosition AsWeightedLootPointSpawnPosition() { }

	public float get_Weight() { }

	public void set_Weight(float value) { }

	private void SetDirty() { }

}

