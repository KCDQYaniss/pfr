//Type is in global namespace

public class AbstractMaterialBumpedSpecularSMap : ScriptableObject
{
	private static readonly int _mainTex; //Field offset: 0x0
	private static readonly int _bumpMap; //Field offset: 0x4
	private static readonly int _color; //Field offset: 0x8
	private static readonly int _baseTintColor; //Field offset: 0xC
	public Material Material; //Field offset: 0x18
	public Texture MainTex; //Field offset: 0x20
	public Texture BumpMap; //Field offset: 0x28
	public Color Color; //Field offset: 0x30
	public Color BaseTintColor; //Field offset: 0x40

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static AbstractMaterialBumpedSpecularSMap() { }

	public AbstractMaterialBumpedSpecularSMap() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

}

