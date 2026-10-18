namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
[StaticAccessor("GetGraphicsSettings()", StaticAccessorType::Dot (0))]
public sealed class GraphicsSettings : Object
{

	public static RenderPipelineAsset defaultRenderPipeline
	{
		 get { } //Length: 172
		 set { } //Length: 78
	}

	[NativeName("DefaultRenderPipeline")]
	private static ScriptableObject INTERNAL_defaultRenderPipeline
	{
		private get { } //Length: 69
		private set { } //Length: 78
	}

	public static bool lightsUseLinearIntensity
	{
		 get { } //Length: 69
	}

	public static bool logWhenShaderIsCompiled
	{
		 set { } //Length: 78
	}

	public static RenderPipelineAsset renderPipelineAsset
	{
		 get { } //Length: 9
		 set { } //Length: 78
	}

	public static bool useScriptableRenderPipelineBatching
	{
		 get { } //Length: 69
	}

	public static RenderPipelineAsset get_defaultRenderPipeline() { }

	private static ScriptableObject get_INTERNAL_defaultRenderPipeline() { }

	public static bool get_lightsUseLinearIntensity() { }

	public static RenderPipelineAsset get_renderPipelineAsset() { }

	public static bool get_useScriptableRenderPipelineBatching() { }

	[NativeName("GetShaderModeScript")]
	public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type) { }

	public static void set_defaultRenderPipeline(RenderPipelineAsset value) { }

	private static void set_INTERNAL_defaultRenderPipeline(ScriptableObject value) { }

	public static void set_logWhenShaderIsCompiled(bool value) { }

	public static void set_renderPipelineAsset(RenderPipelineAsset value) { }

}

