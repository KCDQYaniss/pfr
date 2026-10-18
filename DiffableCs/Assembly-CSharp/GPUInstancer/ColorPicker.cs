namespace GPUInstancer;

public class ColorPicker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Texture2D satvalTex; //Field offset: 0x10
		public Color[] satvalColors; //Field offset: 0x18
		public float Hue; //Field offset: 0x20
		public Color[] hueColors; //Field offset: 0x28
		public Action resetSatValTexture; //Field offset: 0x30
		public float Saturation; //Field offset: 0x38
		public float Value; //Field offset: 0x3C
		public GameObject result; //Field offset: 0x40
		public ColorPicker <>4__this; //Field offset: 0x48
		public GameObject hueGO; //Field offset: 0x50
		public Action dragH; //Field offset: 0x58
		public GameObject satvalGO; //Field offset: 0x60
		public Action dragSV; //Field offset: 0x68
		public Vector2 hueSz; //Field offset: 0x70
		public Action applyHue; //Field offset: 0x78
		public Action applySaturationValue; //Field offset: 0x80
		public GameObject hueKnob; //Field offset: 0x88
		public Action idle; //Field offset: 0x90
		public Vector2 satvalSz; //Field offset: 0x98
		public GameObject satvalKnob; //Field offset: 0xA0

		public <>c__DisplayClass13_0() { }

		internal void <Setup>b__0() { }

		internal void <Setup>b__1() { }

		internal void <Setup>b__2() { }

		internal void <Setup>b__3() { }

		internal void <Setup>b__4() { }

		internal void <Setup>b__5() { }

	}

	private Color _color; //Field offset: 0x20
	private Action _onValueChange; //Field offset: 0x30
	private Action _onValueChangeVoid; //Field offset: 0x38
	private Action _update; //Field offset: 0x40

	public Color Color
	{
		 get { } //Length: 11
		 set { } //Length: 30
	}

	public ColorPicker() { }

	private void Awake() { }

	public Color get_Color() { }

	private static bool GetLocalMouse(GameObject go, out Vector2 result) { }

	private static Vector2 GetWidgetSize(GameObject go) { }

	private GameObject GO(string name) { }

	private static void RGBToHSV(Color color, out float h, out float s, out float v) { }

	public void set_Color(Color value) { }

	public void SetOnValueChangeCallback(Action onValueChange) { }

	public void SetOnValueChangeCallback(Action onValueChange) { }

	public void SetRandomColor() { }

	private void Setup(Color inputColor) { }

	private void Update() { }

}

