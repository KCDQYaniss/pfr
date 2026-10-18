namespace Koenigz.PerfectCulling;

public class PerfectCullingResourcesLocator : ScriptableObject
{
	private static PerfectCullingResourcesLocator _instance; //Field offset: 0x0
	public Material UnlitTagMaterial; //Field offset: 0x18
	public PerfectCullingSettings Settings; //Field offset: 0x20
	public PerfectCullingColorTable ColorTable; //Field offset: 0x28
	public PerfectCullingVolumeBakeData tempVolumeBakeData; //Field offset: 0x30
	public Shader[] ExcludeTransparentShaders; //Field offset: 0x38
	public Shader[] ValidTransparentShaders; //Field offset: 0x40
	public Material ProxyLightMaterial; //Field offset: 0x48
	public Material RainbowProxyMaterial; //Field offset: 0x50
	public GameObject QuadPrefab; //Field offset: 0x58
	public Mesh[] LightSpheres; //Field offset: 0x60
	public Material AutotestRendererMaterialOpaque; //Field offset: 0x68
	public Material AutotestRendererMaterialTransparent; //Field offset: 0x70
	public Material AutotestProxyMaterialOpaque; //Field offset: 0x78
	public Material AutotestProxyMaterialTransparent; //Field offset: 0x80
	public PerfectCullingAutoTestCamera AutoTestCameraPrefab; //Field offset: 0x88
	public ComputeShader PointExtractorComputeShader; //Field offset: 0x90
	public GameObject AutotestProxyPrefab; //Field offset: 0x98
	public Material AutotestTerrainMaterial; //Field offset: 0xA0

	public static PerfectCullingResourcesLocator Instance
	{
		 get { } //Length: 475
	}

	public PerfectCullingResourcesLocator() { }

	public static PerfectCullingResourcesLocator get_Instance() { }

}

