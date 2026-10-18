//Type is in global namespace

public class AIPatrolsData : MonoBehaviour
{
	public List ContainerLootPoints; //Field offset: 0x20
	public List SimpleLootPoints; //Field offset: 0x28
	public List LootPointClusters; //Field offset: 0x30
	public float LootClusterRadius; //Field offset: 0x38
	public int MinLootPointsInCluster; //Field offset: 0x3C
	public int MinClusterLootScore; //Field offset: 0x40
	public List ExfiltrationPoints; //Field offset: 0x48
	public bool DrawAlways; //Field offset: 0x50
	public bool UseDrawIndex; //Field offset: 0x51

	public AIPatrolsData() { }

	private void DrawGizmos() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public void Restore(AICorePointHolder coresHolder) { }

	public void RestoreLoot(LootData lootData, IEnumerable containers) { }

}

