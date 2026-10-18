namespace PlayerIcons;

public class MeshMaterialSetting
{
	public MeshType meshType; //Field offset: 0x10
	public bool isChanged; //Field offset: 0x14
	[Range(0.01, 10)]
	public float specularityMesh; //Field offset: 0x18
	[Range(0.01, 10)]
	public float glossnessMesh; //Field offset: 0x1C

	public MeshMaterialSetting() { }

}

