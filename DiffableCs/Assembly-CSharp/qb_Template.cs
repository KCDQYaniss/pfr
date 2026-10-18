//Type is in global namespace

public class qb_Template
{
	public bool live; //Field offset: 0x10
	public string brushName; //Field offset: 0x18
	public float brushRadius; //Field offset: 0x20
	public float brushRadiusMin; //Field offset: 0x24
	public float brushRadiusMax; //Field offset: 0x28
	public float brushSpacing; //Field offset: 0x2C
	public float brushSpacingMin; //Field offset: 0x30
	public float brushSpacingMax; //Field offset: 0x34
	public float scatterRadius; //Field offset: 0x38
	public bool alignToNormal; //Field offset: 0x3C
	public bool flipNormalAlign; //Field offset: 0x3D
	public bool alignToStroke; //Field offset: 0x3E
	public bool flipStrokeAlign; //Field offset: 0x3F
	public Vector3 rotationRangeMin; //Field offset: 0x40
	public Vector3 rotationRangeMax; //Field offset: 0x4C
	public Vector3 positionOffset; //Field offset: 0x58
	public float scaleMin; //Field offset: 0x64
	public float scaleMax; //Field offset: 0x68
	public Vector3 scaleRandMin; //Field offset: 0x6C
	public Vector3 scaleRandMax; //Field offset: 0x78
	public float scaleRandMinUniform; //Field offset: 0x84
	public float scaleRandMaxUniform; //Field offset: 0x88
	public bool scaleUniform; //Field offset: 0x8C
	public bool paintToSelection; //Field offset: 0x8D
	public bool paintToLayer; //Field offset: 0x8E
	public int layerIndex; //Field offset: 0x90
	public bool groupObjects; //Field offset: 0x94
	public int groupIndex; //Field offset: 0x98
	public bool eraseByGroup; //Field offset: 0x9C
	public bool eraseBySelected; //Field offset: 0x9D
	public qb_PrefabObject[] prefabGroup; //Field offset: 0xA0
	public bool dirty; //Field offset: 0xA8

	public qb_Template() { }

}

