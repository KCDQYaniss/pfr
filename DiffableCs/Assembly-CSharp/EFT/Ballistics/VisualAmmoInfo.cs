namespace EFT.Ballistics;

public struct VisualAmmoInfo
{
	private readonly Shot _shot; //Field offset: 0x0
	private readonly Transform _visualAmmoTransform; //Field offset: 0x8
	private readonly GameObject _visualAmmoGameObject; //Field offset: 0x10
	private readonly bool _needReturnToPool; //Field offset: 0x18

	public bool NeedReturnToPool
	{
		 get { } //Length: 5
	}

	public GameObject VisualAmmoGameObject
	{
		 get { } //Length: 5
	}

	public VisualAmmoInfo(Shot shot, Transform visualAmmoTransform, GameObject visualAmmoGameObject, bool needReturnToPool = true) { }

	public bool get_NeedReturnToPool() { }

	public GameObject get_VisualAmmoGameObject() { }

	public bool ShotIsFinished() { }

	public void UpdatePosition() { }

}

