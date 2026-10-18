//Type is in global namespace

public class AmmoActivenessData
{
	private readonly GameObject _gameObject; //Field offset: 0x10
	public readonly Transform Transform; //Field offset: 0x18
	public readonly int Id; //Field offset: 0x20
	public bool IsActive; //Field offset: 0x24

	public AmmoActivenessData(Transform transform, int id) { }

	public void SetActive(bool isActive) { }

}

