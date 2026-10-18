namespace EFT;

public class SpringMagazineVisual : MagazineInHandsVisual
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ReturnVisualPartsToPool>b__10_0(AmmoPoolObject ammo) { }

	}

	private const float MAX_SQR_DISTANCE_TO_CAMERA_FOR_UPDATE = 100; //Field offset: 0x0
	private static int _evenOrNotEvenUpdateLastValue; //Field offset: 0x0
	private AmmoActivenessData[] _cartridgesTransforms; //Field offset: 0x28
	private List _ammoPoolObjects; //Field offset: 0x30
	private Animation _springAnimation; //Field offset: 0x38
	private int _prevSpringAmmoCount; //Field offset: 0x40
	private int _evenOrNotEvenUpdate; //Field offset: 0x44

	public SpringMagazineVisual() { }

	protected virtual void CacheDataTransforms() { }

	private void CheckDiff() { }

	private void CheckSpringForRefresh() { }

	private void FillAmmoObjectsOnStart() { }

	protected virtual void InitializeVisualOnStart() { }

	protected virtual void RefreshVisualParts() { }

	protected virtual void Reset() { }

	protected virtual void ReturnVisualPartsToPool() { }

	public virtual void Update() { }

	private void UpdateCartridgesActiveState() { }

}

