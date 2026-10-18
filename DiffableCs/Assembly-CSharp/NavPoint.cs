//Type is in global namespace

public class NavPoint
{
	public int Id; //Field offset: 0x10
	public int AreaId; //Field offset: 0x14
	public bool IsValid; //Field offset: 0x18
	public Vector3 Pos; //Field offset: 0x1C
	public HashSet Edges; //Field offset: 0x28

	public NavPoint(int id, Vector3 pos) { }

	public void AddEdge(NavEdge navEdge) { }

}

