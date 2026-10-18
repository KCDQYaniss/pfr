//Type is in global namespace

internal class GUIMaskTex
{
	private Material _material; //Field offset: 0x10
	private Texture _texture; //Field offset: 0x18
	private Rect _screenPos; //Field offset: 0x20
	private Rect _maskUvPos; //Field offset: 0x30
	public bool HorAlign; //Field offset: 0x40

	public Texture Texture
	{
		 get { } //Length: 5
		 set { } //Length: 368
	}

	public GUIMaskTex(Texture texture, bool horAlign = false) { }

	private void Culc() { }

	public void Draw() { }

	public Texture get_Texture() { }

	public void set_Texture(Texture value) { }

	private void UpdateSize() { }

}

