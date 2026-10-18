namespace EFT.AssetsManager;

[DisallowMultipleComponent]
public class AmmoPoolObject : AssetPoolObject
{
	public Shell Shell; //Field offset: 0x90
	private List _fullGameObjects; //Field offset: 0x98
	private List _shellGameObjects; //Field offset: 0xA0
	[SerializeField]
	private ECaliber _caliber; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <ShouldBeDestroyed>k__BackingField; //Field offset: 0xAC
	private float c; //Field offset: 0xB0

	public private bool ShouldBeDestroyed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public AmmoPoolObject() { }

	private void DisableComponents() { }

	public void EnablePhysics(Vector3 force, Vector3 torque, Vector3 parentForce, Vector3 weaponForward) { }

	[CompilerGenerated]
	public bool get_ShouldBeDestroyed() { }

	public virtual void OnCreatePoolObject(AbstractAssetsPool assetsPoolParent) { }

	protected virtual void ReturnToPool() { }

	[CompilerGenerated]
	private void set_ShouldBeDestroyed(bool value) { }

	private void SetLayer() { }

	public void SetUsed(bool isUsed) { }

	public void StartAutoDestroyCountDown(float countdownTime = 1) { }

	private void Update() { }

}

