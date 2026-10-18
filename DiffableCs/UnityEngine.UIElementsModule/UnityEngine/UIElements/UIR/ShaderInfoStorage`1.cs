namespace UnityEngine.UIElements.UIR;

internal class ShaderInfoStorage`1 : BaseShaderInfoStorage
{
	private readonly int m_InitialSize; //Field offset: 0x0
	private readonly int m_MaxSize; //Field offset: 0x0
	private readonly TextureFormat m_Format; //Field offset: 0x0
	private readonly Func m_Convert; //Field offset: 0x0
	private UIRAtlasAllocator m_Allocator; //Field offset: 0x0
	private Texture2D m_Texture; //Field offset: 0x0
	private NativeArray m_Texels; //Field offset: 0x0

	public virtual Texture2D texture
	{
		 get { } //Length: 5
	}

	public ShaderInfoStorage`1(TextureFormat format, Func convert, int initialSize = 64, int maxSize = 4096) { }

	public virtual bool AllocateRect(int width, int height, out RectInt uvs) { }

	private static void CpuBlit(NativeArray src, int srcWidth, int srcHeight, NativeArray dst, int dstWidth, int dstHeight) { }

	private void CreateOrExpandTexture() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual Texture2D get_texture() { }

	public virtual void SetTexel(int x, int y, Color color) { }

	public virtual void UpdateTexture() { }

}

