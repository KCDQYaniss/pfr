namespace GPUInstancer;

public class ShaderInstance
{
	public string name; //Field offset: 0x10
	public Shader instancedShader; //Field offset: 0x18
	public string modifiedDate; //Field offset: 0x20
	public bool isOriginalInstanced; //Field offset: 0x28
	public string extensionCode; //Field offset: 0x30

	public ShaderInstance(string name, Shader instancedShader, bool isOriginalInstanced, string extensionCode = null) { }

	public override void Regenerate() { }

}

