namespace UnityEngine;

[UsedByNativeCode]
public sealed class SplatPrototype
{
	internal Texture2D m_Texture; //Field offset: 0x10
	internal Texture2D m_NormalMap; //Field offset: 0x18
	internal Vector2 m_TileSize; //Field offset: 0x20
	internal Vector2 m_TileOffset; //Field offset: 0x28
	internal Vector4 m_SpecularMetallic; //Field offset: 0x30
	internal float m_Smoothness; //Field offset: 0x40

	public Texture2D normalMap
	{
		 get { } //Length: 7
	}

	public Texture2D texture
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	public SplatPrototype() { }

	public Texture2D get_normalMap() { }

	public Texture2D get_texture() { }

	public void set_texture(Texture2D value) { }

}

