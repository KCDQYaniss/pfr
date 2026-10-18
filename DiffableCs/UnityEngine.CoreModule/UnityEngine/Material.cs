namespace UnityEngine;

[NativeHeader("Runtime/Shaders/Material.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public class Material : Object
{

	public Color color
	{
		 get { } //Length: 272
		 set { } //Length: 266
	}

	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Texture mainTexture
	{
		 get { } //Length: 226
		 set { } //Length: 170
	}

	public Vector2 mainTextureOffset
	{
		 get { } //Length: 171
		 set { } //Length: 267
	}

	public Vector2 mainTextureScale
	{
		 get { } //Length: 171
		 set { } //Length: 267
	}

	public int passCount
	{
		[NativeName("GetShader()->GetPassCount")]
		 get { } //Length: 78
	}

	public int renderQueue
	{
		[NativeName("GetActualRenderQueue")]
		 get { } //Length: 78
		[NativeName("SetCustomRenderQueue")]
		 set { } //Length: 91
	}

	public Shader shader
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public string[] shaderKeywords
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Material(Shader shader) { }

	[RequiredByNativeCode]
	public Material(Material source) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	public Material(string contents) { }

	public int ComputeCRC() { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString(Material self) { }

	public void DisableKeyword(string keyword) { }

	public void EnableKeyword(string keyword) { }

	public int FindPass(string passName) { }

	public Color get_color() { }

	public bool get_enableInstancing() { }

	public Texture get_mainTexture() { }

	public Vector2 get_mainTextureOffset() { }

	public Vector2 get_mainTextureScale() { }

	[NativeName("GetShader()->GetPassCount")]
	public int get_passCount() { }

	[NativeName("GetActualRenderQueue")]
	public int get_renderQueue() { }

	public Shader get_shader() { }

	public string[] get_shaderKeywords() { }

	public Color GetColor(int nameID) { }

	public Color GetColor(string name) { }

	[NativeName("GetColorFromScript")]
	private Color GetColorImpl(int name) { }

	private void GetColorImpl_Injected(int name, out Color ret) { }

	internal static Material GetDefaultMaterial() { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	public float GetFloat(int nameID) { }

	public float GetFloat(string name) { }

	[NativeName("GetFloatFromScript")]
	private float GetFloatImpl(int name) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	private string[] GetShaderKeywords() { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[NativeName("GetTag")]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public Texture GetTexture(string name) { }

	public Texture GetTexture(int nameID) { }

	[NativeName("GetTextureFromScript")]
	private Texture GetTextureImpl(int name) { }

	public Vector2 GetTextureOffset(int nameID) { }

	public Vector2 GetTextureOffset(string name) { }

	public void GetTexturePropertyNames(List outNames) { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNamesInternal", HasExplicitThis = True)]
	private void GetTexturePropertyNamesInternal(object outNames) { }

	public Vector2 GetTextureScale(int nameID) { }

	public Vector2 GetTextureScale(string name) { }

	[NativeName("GetTextureScaleAndOffsetFromScript")]
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }

	public Vector4 GetVector(string name) { }

	public Vector4 GetVector(int nameID) { }

	public bool HasProperty(string name) { }

	[NativeName("HasPropertyFromScript")]
	public bool HasProperty(int nameID) { }

	public bool HasTexture(int nameID) { }

	[NativeName("HasTextureFromScript")]
	private bool HasTextureImpl(int name) { }

	public bool IsKeywordEnabled(string keyword) { }

	public void set_color(Color value) { }

	public void set_enableInstancing(bool value) { }

	public void set_mainTexture(Texture value) { }

	public void set_mainTextureOffset(Vector2 value) { }

	public void set_mainTextureScale(Vector2 value) { }

	[NativeName("SetCustomRenderQueue")]
	public void set_renderQueue(int value) { }

	public void set_shader(Shader value) { }

	public void set_shaderKeywords(string[] value) { }

	public void SetBuffer(int nameID, GraphicsBuffer value) { }

	public void SetBuffer(int nameID, ComputeBuffer value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	[NativeName("SetBufferFromScript")]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	public void SetColor(string name, Color value) { }

	public void SetColor(int nameID, Color value) { }

	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	[NativeName("SetConstantBufferFromScript")]
	private void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	public void SetFloat(int nameID, float value) { }

	public void SetFloat(string name, float value) { }

	private void SetFloatArray(int name, float[] values, int count) { }

	public void SetFloatArray(int nameID, float[] values) { }

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetBufferFromScript")]
	private void SetGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	public void SetInt(int nameID, int value) { }

	public void SetInt(string name, int value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetMatrix(string name, Matrix4x4 value) { }

	[NativeName("SetMatrixFromScript")]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	public bool SetPass(int pass) { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	private void SetShaderKeywords(string[] names) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value) { }

	public void SetTextureOffset(string name, Vector2 value) { }

	public void SetTextureOffset(int nameID, Vector2 value) { }

	[NativeName("SetTextureOffsetFromScript")]
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	public void SetTextureScale(string name, Vector2 value) { }

	public void SetTextureScale(int nameID, Vector2 value) { }

	[NativeName("SetTextureScaleFromScript")]
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVectorArray(string name, Vector4[] values) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = True)]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

}

