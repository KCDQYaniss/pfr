namespace GPUInstancer;

public class GPUInstancerShaderBindings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string extensionCode; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <HasExtension>b__0(GPUInstancerShaderBindingsExtension ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public GPUInstancerShaderBindingsExtension extension; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <AddExtension>b__0(GPUInstancerShaderBindingsExtension ex) { }

	}

	private static readonly List _standardUnityShaders; //Field offset: 0x0
	private static readonly List _standardUnityShadersGPUI; //Field offset: 0x8
	private static readonly List _extraGPUIShaders; //Field offset: 0x10
	public List shaderInstances; //Field offset: 0x18
	public List shaderBindingsExtensions; //Field offset: 0x20

	private static GPUInstancerShaderBindings() { }

	public GPUInstancerShaderBindings() { }

	public override void AddExtension(GPUInstancerShaderBindingsExtension extension) { }

	public override void AddShaderInstance(string name, Shader instancedShader, bool isOriginalInstanced = false, string extensionCode = null) { }

	public override void ClearEmptyShaderInstances() { }

	public override GPUInstancerShaderBindingsExtension GetExtension(string extensionCode) { }

	public override Material GetInstancedMaterial(Material originalMaterial, string extensionCode = null) { }

	public override Shader GetInstancedShader(string shaderName, string extensionCode = null) { }

	public override bool HasExtension(string extensionCode) { }

	public override bool IsShadersInstancedVersionExists(string shaderName, string extensionCode = null) { }

	public override void ResetShaderInstances() { }

}

