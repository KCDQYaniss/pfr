//Type is in global namespace

[DisallowMultipleComponent]
public class MagVisualController : WeaponModPoolObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ReturnAmmo>b__10_0(AmmoPoolObject ammo) { }

	}

	private const string PATRON_TRANSFORM_NAME = "patron_"; //Field offset: 0x0
	private AmmoActivenessData[] _cartridgesTransforms; //Field offset: 0x98
	private Magazine _mag; //Field offset: 0xA0
	private List _ammoPoolObjects; //Field offset: 0xA8
	private Animation _springAnimation; //Field offset: 0xB0
	private int _prevSpringAmmoCount; //Field offset: 0xB8
	private bool _isAnimated; //Field offset: 0xBC

	public MagVisualController() { }

	private void CacheData() { }

	public void InitMagazine(Magazine mag, IPlayer player, bool isAnimated = true) { }

	private void ObservedRefreshSpring(int magCount) { }

	public void ObservedUpdate(int magCount) { }

	public virtual void OnCreatePoolObject(AbstractAssetsPool assetsPoolParent) { }

	private void RefreshSpring() { }

	public void ReturnAmmo() { }

	protected virtual void ReturnToPool() { }

	public override void Update() { }

}

