namespace EFT.Passcodes;

public class HintGroup : SerializedMonoBehaviour
{
	[SerializeField]
	private string _passlockId; //Field offset: 0x60
	[OdinSerialize]
	[SerializeField]
	private IHintObject[] _hintObjects; //Field offset: 0x68
	[SerializeField]
	private int _hintObjectsAmount; //Field offset: 0x70

	public IHintObject[] HintObjects
	{
		 get { } //Length: 5
	}

	public int HintObjectsAmount
	{
		 get { } //Length: 4
	}

	public string PasslockId
	{
		 get { } //Length: 5
	}

	public HintGroup() { }

	public IHintObject[] get_HintObjects() { }

	public int get_HintObjectsAmount() { }

	public string get_PasslockId() { }

	protected virtual void OnAfterDeserialize() { }

	private void OnValidate() { }

}

