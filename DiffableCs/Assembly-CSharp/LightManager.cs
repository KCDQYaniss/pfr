//Type is in global namespace

[ExecuteInEditMode]
public class LightManager : OnRenderObjectConnector
{
	private static readonly HashSet Renderers; //Field offset: 0x0
	private readonly CommandBufferManager _cbManager; //Field offset: 0x20

	private static LightManager() { }

	public LightManager() { }

	public static void Add(IRenderer renderer) { }

	public virtual void ManualOnRenderObject(Camera currentCamera) { }

	public static void Remove(IRenderer renderer) { }

}

