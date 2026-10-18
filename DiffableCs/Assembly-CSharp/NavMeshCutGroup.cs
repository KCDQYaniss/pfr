//Type is in global namespace

public class NavMeshCutGroup : MonoBehaviour
{
	public List _elements; //Field offset: 0x20
	private List _cutted; //Field offset: 0x28

	public NavMeshCutGroup() { }

	public void Cut(NavMeshCutElement element) { }

	public void DrawGizmo() { }

	public bool HaveFreeToCut(NavMeshCutElement element) { }

	private void OnDrawGizmosSelected() { }

	public void UnCut(NavMeshCutElement element) { }

	public bool UnCutOldest() { }

}

