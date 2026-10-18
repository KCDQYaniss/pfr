//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class StuckFPS : MonoBehaviour
{
	[SerializeField]
	private int _minFramerate; //Field offset: 0x20
	[SerializeField]
	private int _maxFramerate; //Field offset: 0x24
	private RenderTexture _lastFrame; //Field offset: 0x28
	private float _lastTimeOfCapturedFrame; //Field offset: 0x30

	public StuckFPS() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

