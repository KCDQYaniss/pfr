//Type is in global namespace

internal class GUIProgressBar
{
	private Texture _backGround; //Field offset: 0x10
	private Texture _foreGround; //Field offset: 0x18
	private float _value; //Field offset: 0x20
	private Rect _screenPos; //Field offset: 0x24
	private Rect _backGroundRect; //Field offset: 0x34
	private Rect _foreGroundRect; //Field offset: 0x44
	private Rect _foreGroundUv; //Field offset: 0x54
	private Vector2 _scale; //Field offset: 0x64

	public Texture BackGround
	{
		 get { } //Length: 5
		 set { } //Length: 368
	}

	public Texture ForeGround
	{
		 get { } //Length: 5
		 set { } //Length: 368
	}

	public float Value
	{
		 get { } //Length: 6
		 set { } //Length: 34
	}

	public GUIProgressBar(Texture backGround, Texture foreGround, Vector2 scale) { }

	private void Culc() { }

	public void Draw() { }

	public Texture get_BackGround() { }

	public Texture get_ForeGround() { }

	public float get_Value() { }

	public void set_BackGround(Texture value) { }

	public void set_ForeGround(Texture value) { }

	public void set_Value(float value) { }

	private void UpdateSize() { }

}

