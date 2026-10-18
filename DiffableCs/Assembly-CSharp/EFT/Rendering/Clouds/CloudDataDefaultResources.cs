namespace EFT.Rendering.Clouds;

public class CloudDataDefaultResources : ScriptableObject
{
	private static CloudDataDefaultResources _instance; //Field offset: 0x0
	[SerializeField]
	private Texture2D _defaultCloudMap; //Field offset: 0x18
	[SerializeField]
	private ComputeShader _bakeCloudTextureCs; //Field offset: 0x20
	[SerializeField]
	private ComputeShader _bakeCloudShadowsCs; //Field offset: 0x28
	[SerializeField]
	private Shader _cloudLayerPS; //Field offset: 0x30

	public ComputeShader BakeCloudShadowsCs
	{
		 get { } //Length: 5
	}

	public ComputeShader BakeCloudTextureCs
	{
		 get { } //Length: 5
	}

	public Shader CloudLayerPS
	{
		 get { } //Length: 76
	}

	public Texture2D DefaultCloudMap
	{
		 get { } //Length: 5
	}

	public static CloudDataDefaultResources Instance
	{
		 get { } //Length: 622
	}

	public CloudDataDefaultResources() { }

	public ComputeShader get_BakeCloudShadowsCs() { }

	public ComputeShader get_BakeCloudTextureCs() { }

	public Shader get_CloudLayerPS() { }

	public Texture2D get_DefaultCloudMap() { }

	public static CloudDataDefaultResources get_Instance() { }

}

