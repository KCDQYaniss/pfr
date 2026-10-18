namespace UnityEngine.ProBuilder.Poly2Tri;

internal class PointSet : Triangulatable
{
	[CompilerGenerated]
	private IList <Points>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IList <Triangles>k__BackingField; //Field offset: 0x18

	public private override IList Points
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override IList Triangles
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override TriangulationMode TriangulationMode
	{
		 get { } //Length: 3
	}

	public PointSet(List points) { }

	public override void AddTriangle(DelaunayTriangle t) { }

	public override void AddTriangles(IEnumerable list) { }

	public override void ClearTriangles() { }

	[CompilerGenerated]
	public override IList get_Points() { }

	[CompilerGenerated]
	public override IList get_Triangles() { }

	public override TriangulationMode get_TriangulationMode() { }

	public override void Prepare(TriangulationContext tcx) { }

	[CompilerGenerated]
	private void set_Points(IList value) { }

	[CompilerGenerated]
	private void set_Triangles(IList value) { }

}

