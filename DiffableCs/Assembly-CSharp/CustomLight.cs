//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Renderer))]
public class CustomLight : MonoBehaviour, IRenderer
{
	private Renderer _renderer; //Field offset: 0x20

	public CustomLight() { }

	private void Awake() { }

	public override void Draw(CommandBuffer buffer, Plane[] frustrumPlanes, Camera cam) { }

	private Renderer GetRenderer() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnDrawGizmos() { }

	private void OnEnable() { }

}

