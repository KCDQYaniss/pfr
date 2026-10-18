namespace UnityEngine;

[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class SpriteRenderer : Renderer
{
	private UnityEvent m_SpriteChangeEvent; //Field offset: 0x18

	public Color color
	{
		 get { } //Length: 102
		 set { } //Length: 93
	}

	public Color get_color() { }

	private void get_color_Injected(out Color ret) { }

	[RequiredByNativeCode]
	private void InvokeSpriteChanged() { }

	public void set_color(Color value) { }

	private void set_color_Injected(ref Color value) { }

}

