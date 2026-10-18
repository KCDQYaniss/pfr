namespace GPUInstancer;

public class GPUInstancerTerrainSettings : ScriptableObject
{
	public bool isOptic; //Field offset: 0x18
	public string terrainDataGUID; //Field offset: 0x20
	public float maxDetailDistance; //Field offset: 0x28
	public float maxDetailDistanceLegacy; //Field offset: 0x2C
	[Range(0, 2500)]
	public float maxTreeDistance; //Field offset: 0x30
	public Texture2D healthyDryNoiseTexture; //Field offset: 0x38
	public Texture2D windWaveNormalTexture; //Field offset: 0x40
	public bool autoSPCellSize; //Field offset: 0x48
	[Range(25, 500)]
	public int preferedSPCellSize; //Field offset: 0x4C
	[Range(0, 1)]
	public float detailDensity; //Field offset: 0x50
	[Range(1, 10)]
	public int resizeDensityCount; //Field offset: 0x54
	public string warningText; //Field offset: 0x58
	public Color wavingGrassTint; //Field offset: 0x60
	public float frustumOffset; //Field offset: 0x70
	public Texture2DArray densityMapArray; //Field offset: 0x78

	public GPUInstancerTerrainSettings() { }

	public Texture2D GetHealthyDryNoiseTexture(GPUInstancerDetailPrototype detailPrototype) { }

}

