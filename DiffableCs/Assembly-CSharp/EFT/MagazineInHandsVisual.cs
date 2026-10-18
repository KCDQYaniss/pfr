namespace EFT;

public abstract class MagazineInHandsVisual
{
	protected const string PATRON_BONE_NAME = "patron_"; //Field offset: 0x0
	protected Magazine _magazine; //Field offset: 0x10
	protected GameObject _gameObject; //Field offset: 0x18
	protected bool _isAnimated; //Field offset: 0x20

	protected MagazineInHandsVisual() { }

	protected abstract void CacheDataTransforms() { }

	public void Init(GameObject gameObject, Magazine magazine, bool isAnimated) { }

	protected abstract void InitializeVisualOnStart() { }

	public void OnReturnToPool() { }

	protected abstract void RefreshVisualParts() { }

	protected override void Reset() { }

	protected abstract void ReturnVisualPartsToPool() { }

	public abstract void Update() { }

}

