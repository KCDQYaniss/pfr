namespace EFT.AssetsManager;

public class PoolContainerObject : MonoBehaviour
{
	[SerializeField]
	private GameObject _originGameObject; //Field offset: 0x20
	public List PoolObjects; //Field offset: 0x28

	public GameObject OriginGameObject
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public PoolContainerObject() { }

	public void AddToContainer(AssetPoolObject poolObject) { }

	public GameObject get_OriginGameObject() { }

	public void RemoveFromContainer(AssetPoolObject poolObject) { }

	public void set_OriginGameObject(GameObject value) { }

}

