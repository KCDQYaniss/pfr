//Type is in global namespace

internal class BokehRenderer
{
	private static readonly int _mainTex; //Field offset: 0x0
	private static readonly int _flareProj; //Field offset: 0x4
	private static readonly int _brightTexture; //Field offset: 0x8
	private static readonly int _intensity; //Field offset: 0xC
	private Texture2D m_CurrentTexture; //Field offset: 0x10
	private Material m_FlareMaterial; //Field offset: 0x18
	private int m_CurrentWidth; //Field offset: 0x20
	private int m_CurrentHeight; //Field offset: 0x24
	private float m_CurrentRelativeScaleX; //Field offset: 0x28
	private float m_CurrentRelativeScaleY; //Field offset: 0x2C

	private static BokehRenderer() { }

	public BokehRenderer() { }

	public void BuildMeshes(int width, int height, float spriteRelativeScaleX, float spriteRelativeScaleY, ref Mesh[] meshes) { }

	public void Clear(ref Mesh[] meshes) { }

	public void RebuildMeshIfNeeded(int width, int height, float spriteRelativeScaleX, float spriteRelativeScaleY, ref Mesh[] meshes) { }

	public void RenderFlare(CommandBuffer _cmdBuf, RenderTexture brightPixels, RenderTexture destination, float intensity, ref Mesh[] meshes) { }

	public void SetMaterial(Material flareMaterial) { }

	public void SetTexture(Texture2D texture) { }

	public void SetupSprite(int idx, int x, int y, Vector3[] vertices, int[] triangles, Vector2[] uv0, Vector2[] uv1, Vector3[] normals, Color[] colors, Vector2 targetPixelUV, float halfWidth, float halfHeight) { }

}

