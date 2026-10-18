namespace UnityEngine.Rendering.PostProcessing;

public sealed class TextureParameter : ParameterOverride
{
	public TextureParameterDefault defaultState; //Field offset: 0x20

	public TextureParameter() { }

	public virtual void Interp(Texture from, Texture to, float t) { }

}

