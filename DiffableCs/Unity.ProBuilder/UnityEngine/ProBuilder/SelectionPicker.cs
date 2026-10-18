namespace UnityEngine.ProBuilder;

public static class SelectionPicker
{

	public static Dictionary PickEdgesInRect(Camera cam, Rect rect, IList selectable, PickerOptions options, float pixelsPerPoint = 1) { }

	public static Face PickFace(Camera camera, Vector3 mousePosition, ProBuilderMesh pickable) { }

	public static Dictionary PickFacesInRect(Camera cam, Rect rect, IList selectable, PickerOptions options, float pixelsPerPoint = 1) { }

	public static Dictionary PickVerticesInRect(Camera cam, Rect rect, IList selectable, PickerOptions options, float pixelsPerPoint = 1) { }

}

