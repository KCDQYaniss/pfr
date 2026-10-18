namespace Coffee.UISoftMask;

[AddComponentMenu(null)]
[ExecuteAlways]
[RequireComponent(typeof(Canvas))]
public class CanvasViewChangeTrigger : MonoBehaviour
{
	private Canvas _canvas; //Field offset: 0x20
	private Action _checkViewProjectionMatrix; //Field offset: 0x28
	private int _lastCameraVpHash; //Field offset: 0x30
	private int _lastResHash; //Field offset: 0x34
	[CompilerGenerated]
	private Action onCanvasViewChanged; //Field offset: 0x38

	public event Action onCanvasViewChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public CanvasViewChangeTrigger() { }

	[CompilerGenerated]
	public void add_onCanvasViewChanged(Action value) { }

	private void CheckViewProjectionMatrix() { }

	public static CanvasViewChangeTrigger Find(Transform transform) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_onCanvasViewChanged(Action value) { }

}

