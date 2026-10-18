namespace UnityEngine;

[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[StaticAccessor("GetITerrainManager()", StaticAccessorType::Arrow (1))]
[UsedByNativeCode]
public sealed class Terrain : Behaviour
{

	public static Terrain activeTerrain
	{
		 get { } //Length: 69
	}

	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains
	{
		 get { } //Length: 69
	}

	public bool allowAutoConnect
	{
		 get { } //Length: 78
	}

	public float detailObjectDensity
	{
		 get { } //Length: 78
	}

	public float detailObjectDistance
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool drawHeightmap
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool drawInstanced
	{
		 get { } //Length: 78
	}

	public bool drawTreesAndFoliage
	{
		 set { } //Length: 93
	}

	[NativeProperty("FreeUnusedRenderingResourcesObsolete")]
	[Obsolete("Terrain.freeUnusedRenderingResources is obsolete; use keepUnusedRenderingResources instead.")]
	public bool freeUnusedRenderingResources
	{
		 set { } //Length: 93
	}

	public int groupingID
	{
		 get { } //Length: 78
	}

	public Material materialTemplate
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public RenderTexture normalmapTexture
	{
		[NativeMethod("TryGetNormalMapTexture")]
		 get { } //Length: 78
	}

	public TerrainData terrainData
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float treeDistance
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public Terrain() { }

	public void Flush() { }

	public static Terrain get_activeTerrain() { }

	public static Terrain[] get_activeTerrains() { }

	public bool get_allowAutoConnect() { }

	public float get_detailObjectDensity() { }

	public float get_detailObjectDistance() { }

	public bool get_drawHeightmap() { }

	public bool get_drawInstanced() { }

	public int get_groupingID() { }

	public Material get_materialTemplate() { }

	[NativeMethod("TryGetNormalMapTexture")]
	public RenderTexture get_normalmapTexture() { }

	public TerrainData get_terrainData() { }

	public float get_treeDistance() { }

	public Vector3 GetPosition() { }

	private void GetPosition_Injected(out Vector3 ret) { }

	public float SampleHeight(Vector3 worldPosition) { }

	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	public void set_detailObjectDistance(float value) { }

	public void set_drawHeightmap(bool value) { }

	public void set_drawTreesAndFoliage(bool value) { }

	public void set_freeUnusedRenderingResources(bool value) { }

	public void set_materialTemplate(Material value) { }

	public void set_terrainData(TerrainData value) { }

	public void set_treeDistance(float value) { }

	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

}

