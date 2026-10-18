//Type is in global namespace

[CreateAssetMenu(fileName = "TextureArray", menuName = "Scriptable objects/TextureArray")]
[PreferBinarySerialization]
public class TexArraySO : ScriptableObject
{
	[Delayed]
	[SerializeField]
	private int _width; //Field offset: 0x18
	[Delayed]
	[SerializeField]
	private int _height; //Field offset: 0x1C
	[SerializeField]
	private TextureFormat _format; //Field offset: 0x20
	[SerializeField]
	private bool _mips; //Field offset: 0x24
	[SerializeField]
	private Texture2D[] _textures; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private Texture2DArray _textureArray; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private bool _hadMips; //Field offset: 0x38

	public TexArraySO() { }

	private static void FillWith(Texture2DArray textureArray, Texture2D[] textures) { }

	private static Color32[] GetColorsFromUnreadableTexture(Texture2D texture, int width, int height) { }

	private bool ValidateTextures(Texture2D[] textures, ref string errorMessage, ref Nullable messageType) { }

	private bool ValidateTexturesWarnings(Texture2D[] textures, ref string errorMessage, ref Nullable messageType) { }

}

