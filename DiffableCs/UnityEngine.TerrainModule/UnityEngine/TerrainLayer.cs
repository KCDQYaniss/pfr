namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/TerrainLayerScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[UsedByNativeCode]
public sealed class TerrainLayer : Object
{

	public Texture2D diffuseTexture
	{
		 set { } //Length: 93
	}

	public Texture2D normalMapTexture
	{
		 set { } //Length: 93
	}

	public TerrainLayer() { }

	[FreeFunction("TerrainLayerScriptingInterface::Create")]
	private static void Internal_Create(TerrainLayer layer) { }

	public void set_diffuseTexture(Texture2D value) { }

	public void set_normalMapTexture(Texture2D value) { }

}

