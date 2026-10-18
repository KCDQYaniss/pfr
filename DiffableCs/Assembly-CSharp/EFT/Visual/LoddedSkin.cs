namespace EFT.Visual;

public class LoddedSkin : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Renderer <GetRenderers>b__6_0(AbstractSkin x) { }

	}

	[FormerlySerializedAs("Skins")]
	[SerializeField]
	private AbstractSkin[] _lods; //Field offset: 0x20
	private List _hotObjects; //Field offset: 0x28

	public LoddedSkin() { }

	public void EnableRenderers(bool on) { }

	public IEnumerable GetRenderers() { }

	public AbstractSkin[] GetSkins() { }

	public void Init(Skeleton skeleton, PlayerBody playerBody) { }

	private void InitHotObject() { }

	public bool IsVisible() { }

	public void SetLayer(int layer) { }

	public void SetShadowCastingMode(ShadowCastingMode shadowCastingMode) { }

	public void SetTemperature(float tempCelsio) { }

	public void Skin() { }

	public void Unskin() { }

}

