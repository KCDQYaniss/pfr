namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
public sealed class Texture3D : Texture
{

	public int depth
	{
		[NativeName("GetTextureLayerCount")]
		 get { } //Length: 78
	}

	public virtual bool isReadable
	{
		 get { } //Length: 78
	}

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public void Apply(bool updateMipmaps) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	public void Apply() { }

	[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = True)]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("GetTextureLayerCount")]
	public int get_depth() { }

	public virtual bool get_isReadable() { }

	public Color[] GetPixels() { }

	[FreeFunction(Name = "Texture3DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	public Color[] GetPixels(int miplevel) { }

	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction("Texture3DScripting::Create")]
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	public void SetPixels(Color[] colors) { }

	[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	public void SetPixels(Color[] colors, int miplevel) { }

	[FreeFunction(Name = "Texture3DScripting::SetPixels32", HasExplicitThis = True, ThrowsException = True)]
	public void SetPixels32(Color32[] colors, int miplevel) { }

	public void SetPixels32(Color32[] colors) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

