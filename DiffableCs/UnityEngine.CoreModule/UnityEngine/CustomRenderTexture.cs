namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CustomRenderTexture.h")]
[UsedByNativeCode]
public sealed class CustomRenderTexture : RenderTexture
{

	public CustomRenderTextureUpdateMode initializationMode
	{
		 set { } //Length: 91
	}

	public CustomRenderTextureInitializationSource initializationSource
	{
		 set { } //Length: 91
	}

	public Texture initializationTexture
	{
		 set { } //Length: 93
	}

	public Material material
	{
		 set { } //Length: 93
	}

	public CustomRenderTextureUpdateMode updateMode
	{
		 set { } //Length: 91
	}

	public CustomRenderTexture(int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	public CustomRenderTexture(int width, int height, GraphicsFormat format) { }

	public void Initialize() { }

	[FreeFunction(Name = "CustomRenderTextureScripting::Create")]
	private static void Internal_CreateCustomRenderTexture(CustomRenderTexture rt) { }

	public void set_initializationMode(CustomRenderTextureUpdateMode value) { }

	public void set_initializationSource(CustomRenderTextureInitializationSource value) { }

	public void set_initializationTexture(Texture value) { }

	public void set_material(Material value) { }

	public void set_updateMode(CustomRenderTextureUpdateMode value) { }

	[NativeName("TriggerInitialization")]
	private void TriggerInitialization() { }

	[NativeName("TriggerUpdate")]
	private void TriggerUpdate(int count) { }

	public void Update(int count) { }

	public void Update() { }

}

