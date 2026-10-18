namespace GPUInstancer;

public class GPUInstancerSpatialPartitioningData`1
{
	public int cellRowAndCollumnCountPerTerrain; //Field offset: 0x0
	public List activeCellList; //Field offset: 0x0
	private Dictionary _cellHashList; //Field offset: 0x0
	private List _cellList; //Field offset: 0x0

	public GPUInstancerSpatialPartitioningData`1() { }

	public void AddCell(T cell) { }

	public bool CalculateActiveCells(Vector3 position) { }

	public bool GetCell(int hash, out T cell) { }

	public void GetCell(T cell) { }

	public List GetCellList() { }

	public bool IsActiveCellUpdateRequired(Vector3 position) { }

}

