namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/LineRenderer.h")]
public sealed class LineRenderer : Renderer
{

	public Color endColor
	{
		 get { } //Length: 102
		 set { } //Length: 93
	}

	public float endWidth
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	[NativeProperty("PositionsCount")]
	public int positionCount
	{
		 set { } //Length: 91
	}

	public Color startColor
	{
		 get { } //Length: 102
		 set { } //Length: 93
	}

	public float startWidth
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool useWorldSpace
	{
		 set { } //Length: 93
	}

	public float widthMultiplier
	{
		 get { } //Length: 78
	}

	public Color get_endColor() { }

	private void get_endColor_Injected(out Color ret) { }

	public float get_endWidth() { }

	public Color get_startColor() { }

	private void get_startColor_Injected(out Color ret) { }

	public float get_startWidth() { }

	public float get_widthMultiplier() { }

	public void set_endColor(Color value) { }

	private void set_endColor_Injected(ref Color value) { }

	public void set_endWidth(float value) { }

	public void set_positionCount(int value) { }

	public void set_startColor(Color value) { }

	private void set_startColor_Injected(ref Color value) { }

	public void set_startWidth(float value) { }

	public void set_useWorldSpace(bool value) { }

	[Obsolete("Use startColor, endColor or colorGradient instead.", False)]
	public void SetColors(Color start, Color end) { }

	public void SetPosition(int index, Vector3 position) { }

	private void SetPosition_Injected(int index, ref Vector3 position) { }

}

