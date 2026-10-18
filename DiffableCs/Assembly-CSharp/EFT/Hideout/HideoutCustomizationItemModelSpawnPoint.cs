namespace EFT.Hideout;

public sealed class HideoutCustomizationItemModelSpawnPoint : StashItemModelSpawnPoint
{
	[SerializeField]
	private CinemachineVirtualCamera _camera; //Field offset: 0x28

	public HideoutCustomizationItemModelSpawnPoint() { }

	private void Awake() { }

	public virtual void Clear() { }

	public void FocusCamera(bool focus) { }

}

