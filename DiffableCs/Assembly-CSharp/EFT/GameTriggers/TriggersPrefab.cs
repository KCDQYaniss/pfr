namespace EFT.GameTriggers;

public class TriggersPrefab : MonoBehaviour
{
	[SerializeField]
	private bool _processed; //Field offset: 0x20
	[SerializeField]
	private string _postfix; //Field offset: 0x28

	public TriggersPrefab() { }

}

