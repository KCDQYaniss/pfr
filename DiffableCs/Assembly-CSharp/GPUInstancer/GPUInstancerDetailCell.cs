namespace GPUInstancer;

public class GPUInstancerDetailCell : GPUInstancerCell
{
	public Dictionary detailInstanceList; //Field offset: 0x50
	public Dictionary detailInstanceBuffers; //Field offset: 0x58
	public float[] heightMapData; //Field offset: 0x60
	public List detailMapData; //Field offset: 0x68
	public List totalDetailCounts; //Field offset: 0x70
	public Vector3 instanceStartPosition; //Field offset: 0x78

	public GPUInstancerDetailCell(int coordX, int coordZ) { }

}

