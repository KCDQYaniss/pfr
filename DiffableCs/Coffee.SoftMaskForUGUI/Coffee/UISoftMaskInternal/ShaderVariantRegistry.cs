namespace Coffee.UISoftMaskInternal;

public class ShaderVariantRegistry
{
	public class StringPair : IEquatable
	{
		public string key; //Field offset: 0x10
		public string value; //Field offset: 0x18

		public StringPair() { }

		public override bool Equals(StringPair other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private Dictionary _cachedOptionalShaders; //Field offset: 0x10
	[SerializeField]
	private List m_OptionalShaders; //Field offset: 0x18
	[SerializeField]
	internal ShaderVariantCollection m_Asset; //Field offset: 0x20
	public Func onShaderRequested; //Field offset: 0x28

	public ShaderVariantCollection shaderVariantCollection
	{
		 get { } //Length: 5
	}

	public ShaderVariantRegistry() { }

	public Shader FindOptionalShader(Shader shader, string requiredName, string format, string defaultOptionalShaderName) { }

	public ShaderVariantCollection get_shaderVariantCollection() { }

}

