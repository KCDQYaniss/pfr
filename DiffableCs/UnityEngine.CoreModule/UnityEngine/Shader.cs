namespace UnityEngine;

[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
public sealed class Shader : Object
{

	public bool isSupported
	{
		[NativeMethod("IsSupported")]
		 get { } //Length: 78
	}

	[NativeProperty("MaximumShaderLOD")]
	public int maximumLOD
	{
		 set { } //Length: 91
	}

	private Shader() { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	public static void DisableKeyword(string keyword) { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	public static void EnableKeyword(string keyword) { }

	public static Shader Find(string name) { }

	[NativeMethod("IsSupported")]
	public bool get_isSupported() { }

	public static Texture GetGlobalTexture(string name) { }

	[FreeFunction("ShaderScripting::GetGlobalTexture")]
	private static Texture GetGlobalTextureImpl(int name) { }

	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	public static int PropertyToID(string name) { }

	public void set_maximumLOD(int value) { }

	public static void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	private static void SetGlobalBufferImpl(int name, ComputeBuffer value) { }

	public static void SetGlobalColor(string name, Color value) { }

	public static void SetGlobalColor(int nameID, Color value) { }

	public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	private static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	public static void SetGlobalFloat(string name, float value) { }

	public static void SetGlobalFloat(int nameID, float value) { }

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	private static void SetGlobalFloatImpl(int name, float value) { }

	public static void SetGlobalInteger(int nameID, int value) { }

	[FreeFunction("ShaderScripting::SetGlobalInt")]
	private static void SetGlobalIntImpl(int name, int value) { }

	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrix")]
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	public static void SetGlobalTexture(string name, Texture value) { }

	public static void SetGlobalTexture(int nameID, Texture value) { }

	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	public static void SetGlobalVector(string name, Vector4 value) { }

	public static void SetGlobalVector(int nameID, Vector4 value) { }

	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalVectorArray")]
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalVector")]
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	[FreeFunction("ShaderScripting::TagToID")]
	internal static int TagToID(string name) { }

}

