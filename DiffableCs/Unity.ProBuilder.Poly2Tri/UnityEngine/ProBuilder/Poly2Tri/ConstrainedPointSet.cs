namespace UnityEngine.ProBuilder.Poly2Tri;

internal class ConstrainedPointSet : PointSet
{
	[CompilerGenerated]
	private int[] <EdgeIndex>k__BackingField; //Field offset: 0x20

	public private int[] EdgeIndex
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual TriangulationMode TriangulationMode
	{
		 get { } //Length: 6
	}

	public ConstrainedPointSet(List points, int[] index) { }

	[CompilerGenerated]
	public int[] get_EdgeIndex() { }

	public virtual TriangulationMode get_TriangulationMode() { }

	public virtual void Prepare(TriangulationContext tcx) { }

	[CompilerGenerated]
	private void set_EdgeIndex(int[] value) { }

}

