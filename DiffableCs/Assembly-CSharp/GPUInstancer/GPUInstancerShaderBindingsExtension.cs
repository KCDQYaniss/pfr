namespace GPUInstancer;

public interface GPUInstancerShaderBindingsExtension
{

	public bool ClearEmptyShaderInstances(List shaderInstances) { }

	public string GetExtensionCode() { }

	public Material GetInstancedMaterial(List shaderInstances, Material originalMaterial) { }

	public Shader GetInstancedShader(List shaderInstances, string shaderName) { }

	public bool IsShadersInstancedVersionExists(List shaderInstances, string shaderName) { }

}

