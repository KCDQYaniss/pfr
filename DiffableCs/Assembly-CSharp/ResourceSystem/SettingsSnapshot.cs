namespace ResourceSystem;

public struct SettingsSnapshot
{
	private static readonly int _mainTexId; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"mainTex", "bias"})]
	private static readonly List _biasMap; //Field offset: 0x8
	private Color _ambientEquatorColor; //Field offset: 0x0
	private Color _ambientGroundColor; //Field offset: 0x10
	private float _ambientIntensity; //Field offset: 0x20
	private Color _ambientLight; //Field offset: 0x24
	private AmbientMode _ambientMode; //Field offset: 0x34
	private Color _ambientSkyColor; //Field offset: 0x38
	private bool _fog; //Field offset: 0x48

	private static SettingsSnapshot() { }

	private static void Reset() { }

	public void Restore() { }

	public static SettingsSnapshot Store(GameObject model) { }

}

