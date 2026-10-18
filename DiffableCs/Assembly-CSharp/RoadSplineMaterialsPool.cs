//Type is in global namespace

[ExecuteInEditMode]
public static class RoadSplineMaterialsPool
{
	public static Dictionary RoadsMaterials; //Field offset: 0x0
	public static List LodRoads; //Field offset: 0x8

	private static RoadSplineMaterialsPool() { }

	public static void Add(Renderer renderer) { }

	public static Material Get(string materialName, Renderer renderer) { }

	public static void Remove(string materialName, Renderer renderer) { }

}

