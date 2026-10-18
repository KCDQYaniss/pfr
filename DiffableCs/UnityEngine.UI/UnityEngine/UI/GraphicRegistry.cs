namespace UnityEngine.UI;

public class GraphicRegistry
{
	private static GraphicRegistry s_Instance; //Field offset: 0x0
	private static readonly List s_EmptyList; //Field offset: 0x8
	private readonly Dictionary m_Graphics; //Field offset: 0x10
	private readonly Dictionary m_RaycastableGraphics; //Field offset: 0x18

	public static GraphicRegistry instance
	{
		 get { } //Length: 283
	}

	private static GraphicRegistry() { }

	protected GraphicRegistry() { }

	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static GraphicRegistry get_instance() { }

	public static IList GetGraphicsForCanvas(Canvas canvas) { }

	public static IList GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

}

