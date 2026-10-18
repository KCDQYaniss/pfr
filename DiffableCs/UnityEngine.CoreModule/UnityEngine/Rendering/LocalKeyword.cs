namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public struct LocalKeyword : IEquatable
{
	internal readonly LocalKeywordSpace m_SpaceInfo; //Field offset: 0x0
	internal readonly string m_Name; //Field offset: 0x8
	internal readonly uint m_Index; //Field offset: 0x10

	public LocalKeyword(ComputeShader shader, string name) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(LocalKeyword rhs) { }

	[FreeFunction("ShaderScripting::GetKeywordCount")]
	private static uint GetComputeShaderKeywordCount(ComputeShader shader) { }

	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	private static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

