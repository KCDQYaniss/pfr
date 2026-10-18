namespace EFT.Interactive;

[DisallowMultipleComponent]
public class LootableContainersGroup : MonoBehaviour
{
	public string Id; //Field offset: 0x20
	public int Min; //Field offset: 0x28
	public int Max; //Field offset: 0x2C

	public LootableContainersGroup() { }

	private void OnValidate() { }

}

