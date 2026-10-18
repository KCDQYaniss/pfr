//Type is in global namespace

public class ShaderReplacer : IShaderReplacer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Replace>b__2_0(Renderer renderer) { }

	}

	private struct MaterialPath
	{
		public Renderer Renderer; //Field offset: 0x0
		public int MaterialIndex; //Field offset: 0x8
		public Shader OriginalShader; //Field offset: 0x10

	}

	private readonly List _replacedShaders; //Field offset: 0x10

	public ShaderReplacer() { }

	public override void Replace(GameObject model) { }

	public override void Restore() { }

}

