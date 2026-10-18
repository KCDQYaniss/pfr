namespace EFT;

public class BeltMagazineInHandsVisual : MagazineInHandsVisual
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ReturnVisualPartsToPool>b__16_0(AmmoPoolObject ammo) { }

	}

	private const string EMPTY_CELL_IN_USED_SIDE_NAME = "empty_link_"; //Field offset: 0x0
	private AmmoActivenessData[] _cartridgesTransformsOnRightSide; //Field offset: 0x28
	private AmmoActivenessData[] _emptyBeltCellsOnUsedSide; //Field offset: 0x30
	private List _ammoPoolObjects; //Field offset: 0x38
	private int _prevSpringAmmoCount; //Field offset: 0x40
	private int _ammoCountInStart; //Field offset: 0x44
	private int _prevDiffInAmmoCount; //Field offset: 0x48
	private int _maxBeltEmptyCells; //Field offset: 0x4C
	private BeltDetachablePartSpawner _beltDetachablePartSpawner; //Field offset: 0x50
	private bool _beltSpawnerExists; //Field offset: 0x58

	protected override int MagazineCount
	{
		 get { } //Length: 42
	}

	public BeltMagazineInHandsVisual() { }

	protected virtual void CacheDataTransforms() { }

	private void CheckForDiff() { }

	private void CheckUsedPartOfBeltForDetach() { }

	private void FillAmmoObjectsOnStart() { }

	protected override int get_MagazineCount() { }

	protected override int GetBulletPositionForSpawnInBelt() { }

	protected virtual void InitializeVisualOnStart() { }

	private void MoveAmmoInBeltByOne() { }

	protected virtual void RefreshVisualParts() { }

	protected virtual void Reset() { }

	protected virtual void ReturnVisualPartsToPool() { }

	private void SpawnUsedPartOfBelt() { }

	public virtual void Update() { }

	private void UpdateBeltAfterDiff(int updatesCount) { }

	private void UpdateUsedSideCellOfBelt(int index) { }

}

