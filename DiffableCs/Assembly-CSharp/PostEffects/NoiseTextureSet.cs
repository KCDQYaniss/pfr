namespace PostEffects;

public sealed class NoiseTextureSet : ScriptableObject
{
	[SerializeField]
	private Texture2D[] _textures; //Field offset: 0x18

	public NoiseTextureSet() { }

	public Texture2D GetTexture(int frameCount) { }

	public Texture2D GetTexture() { }

}

