//Type is in global namespace

public class AIManualPointInfo : MonoBehaviour
{
	public const int MANUAL_ZONE_START_ID = 100000; //Field offset: 0x0
	public bool _alwaysDraw; //Field offset: 0x20
	public bool DrawWithEdges; //Field offset: 0x21
	public bool DrawWithCore; //Field offset: 0x22
	public float MinDefenceLevelToDraw; //Field offset: 0x24
	public BoxCollider[] ExcludableColliders; //Field offset: 0x28
	public List Points; //Field offset: 0x30

	public AIManualPointInfo() { }

	public void Add(GroupPoint c) { }

	private void CheckAllPoints() { }

	private void DrawPoitns() { }

	public void Init() { }

	private void MergedLists(List coreList, List mergedList) { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	private void Optimize() { }

	public void RemoveByExcutableColiders(List coreList, BoxCollider[] colliders) { }

	public void SetAlwaysDraw(bool alwaysDraw) { }

	public void SetCllidersToTrigers() { }

}

