namespace Coffee.UISoftMask;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Graphic))]
public class AlphaHitTestTarget : MonoBehaviour, ICanvasRaycastFilter
{
	private Graphic _graphic; //Field offset: 0x20

	public Graphic graphic
	{
		 get { } //Length: 259
	}

	public AlphaHitTestTarget() { }

	public Graphic get_graphic() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private override bool UnityEngine.ICanvasRaycastFilter.IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

