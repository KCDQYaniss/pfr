//Type is in global namespace

public class GizmoDrawer : MonoBehaviour
{
	private static Action _drawGizmoDelegate; //Field offset: 0x0
	private static List _boxes; //Field offset: 0x8

	public GizmoDrawer() { }

	public static void AddGizmo(Action drawGizmo) { }

	public static void DrawBoxes(List boxes) { }

	private static void DrawLine(float arg1, float arg2, float forward) { }

	public static void DrawWireCapsule(Vector3 pos, Vector3 pos2, float radius, Color color = null) { }

	private void OnDrawGizmos() { }

	public static void RemoveGizmos() { }

}

