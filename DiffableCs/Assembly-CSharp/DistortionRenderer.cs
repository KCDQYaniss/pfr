//Type is in global namespace

[ExecuteAlways]
public class DistortionRenderer : MonoBehaviourSingleton
{
	private readonly List _objectList; //Field offset: 0x20
	private Camera _camera; //Field offset: 0x28
	private bool _isInitialized; //Field offset: 0x30

	public DistortionRenderer() { }

	public void Add(DistortionObject obj) { }

	public virtual void Awake() { }

	public virtual void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPreRenderCamera(Camera currentCamera) { }

	public void Remove(DistortionObject obj) { }

	private void Render(CommandBuffer buffer) { }

}

