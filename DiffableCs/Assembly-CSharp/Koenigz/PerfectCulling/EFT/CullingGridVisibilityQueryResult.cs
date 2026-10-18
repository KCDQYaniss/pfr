namespace Koenigz.PerfectCulling.EFT;

[IsReadOnly]
public struct CullingGridVisibilityQueryResult
{
	public readonly Vector3 ObservationPoint; //Field offset: 0x0
	public readonly Bounds[] VisibilityCells; //Field offset: 0x10
	private readonly FastArray _visibilityIndices; //Field offset: 0x18

	public bool IsEmpty
	{
		 get { } //Length: 28
	}

	public int NumIndices
	{
		 get { } //Length: 31
	}

	public ushort[] VisibilityIndices
	{
		 get { } //Length: 27
	}

	public CullingGridVisibilityQueryResult(Vector3 observationPoint, Bounds[] visibilityCells, FastArray visibilityIndices) { }

	public bool get_IsEmpty() { }

	public int get_NumIndices() { }

	public ushort[] get_VisibilityIndices() { }

	public bool TestAABB(Bounds bounds) { }

}

