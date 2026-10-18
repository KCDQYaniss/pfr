//Type is in global namespace

public class NavTriangle
{
	public List NavEgdes; //Field offset: 0x10
	public List Points; //Field offset: 0x18
	public Vector3 Position; //Field offset: 0x20
	public List PosIndexes; //Field offset: 0x30
	public int Id; //Field offset: 0x38
	public List EdgesIds; //Field offset: 0x40
	public float Size; //Field offset: 0x48

	public NavTriangle(Func getId, NavPoint p1, NavPoint p2, NavPoint p3) { }

	public void AddEdge(NavEdge edge) { }

	public void AddPoint(NavPoint navPoint) { }

	private void CalcCenter() { }

	private void CalcSize() { }

	public void DebugDraw(float up, Color color, float duration = 10) { }

	public void Restore(Dictionary dc, Dictionary dcEdge) { }

}

