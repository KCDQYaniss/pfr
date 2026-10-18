namespace UnityEngine.ProBuilder.Poly2Tri;

internal class DTSweepDebugContext : TriangulationDebugContext
{
	private DelaunayTriangle _primaryTriangle; //Field offset: 0x18
	private DelaunayTriangle _secondaryTriangle; //Field offset: 0x20
	private TriangulationPoint _activePoint; //Field offset: 0x28
	private AdvancingFrontNode _activeNode; //Field offset: 0x30
	private DTSweepConstraint _activeConstraint; //Field offset: 0x38

	public DTSweepConstraint ActiveConstraint
	{
		 get { } //Length: 5
		 set { } //Length: 152
	}

	public AdvancingFrontNode ActiveNode
	{
		 get { } //Length: 76
		 set { } //Length: 152
	}

	public TriangulationPoint ActivePoint
	{
		 get { } //Length: 5
		 set { } //Length: 152
	}

	public bool IsDebugContext
	{
		 get { } //Length: 3
	}

	public DelaunayTriangle PrimaryTriangle
	{
		 get { } //Length: 5
		 set { } //Length: 152
	}

	public DelaunayTriangle SecondaryTriangle
	{
		 get { } //Length: 5
		 set { } //Length: 152
	}

	public DTSweepDebugContext(DTSweepContext tcx) { }

	public virtual void Clear() { }

	public DTSweepConstraint get_ActiveConstraint() { }

	public AdvancingFrontNode get_ActiveNode() { }

	public TriangulationPoint get_ActivePoint() { }

	public bool get_IsDebugContext() { }

	public DelaunayTriangle get_PrimaryTriangle() { }

	public DelaunayTriangle get_SecondaryTriangle() { }

	public void set_ActiveConstraint(DTSweepConstraint value) { }

	public void set_ActiveNode(AdvancingFrontNode value) { }

	public void set_ActivePoint(TriangulationPoint value) { }

	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	public void set_SecondaryTriangle(DelaunayTriangle value) { }

}

