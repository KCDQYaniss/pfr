namespace EFT.SynchronizableObjects;

public class AirplaneSynchronizableObject : SynchronizableObject
{
	[SerializeField]
	private Dictionary _views; //Field offset: 0x88
	public AirplaneView view; //Field offset: 0x90

	public AirplaneSynchronizableObject() { }

	public void SetActive(bool flag) { }

}

