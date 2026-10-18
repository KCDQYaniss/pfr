//Type is in global namespace

internal class GUITiledTex
{
	private Texture _texture; //Field offset: 0x10
	private Rect _screenPos; //Field offset: 0x18
	private Rect UvPos; //Field offset: 0x28
	private float _scale; //Field offset: 0x38
	public bool HorTile; //Field offset: 0x3C
	public bool VerTile; //Field offset: 0x3D

	public Texture Texture
	{
		 get { } //Length: 5
		 set { } //Length: 368
	}

	public GUITiledTex(Texture texture, float scale, bool horTile = false, bool verTile = false) { }

	private void Culc() { }

	public void Draw() { }

	public Texture get_Texture() { }

	public void set_Texture(Texture value) { }

	private void UpdateSize() { }

}

