//Type is in global namespace

public class DebugCoverResultDrawler : MonoBehaviour
{
	public NavGraphFindDebug Debug; //Field offset: 0x20
	public NavGraphContainer Container; //Field offset: 0x28
	public bool DrawWay; //Field offset: 0x30
	public int stepWayConstrain; //Field offset: 0x34
	public bool DrawCover; //Field offset: 0x38
	public int stepConstrain; //Field offset: 0x3C
	public float radiusConstrain; //Field offset: 0x40

	public DebugCoverResultDrawler() { }

	public void DrawGizmos(int stepConstrain, float radiusConstrain, NavGraphContainer container, int coverSelectId) { }

	private void OnDrawGizmos() { }

}

