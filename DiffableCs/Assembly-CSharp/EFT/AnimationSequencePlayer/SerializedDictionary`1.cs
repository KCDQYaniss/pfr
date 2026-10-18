namespace EFT.AnimationSequencePlayer;

[DefaultMember("Item")]
public abstract class SerializedDictionary`1 : MonoBehaviour
{
	[SerializeField]
	protected List entries; //Field offset: 0x0
	protected Dictionary _dictionary; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 61
	}

	public TValue Item
	{
		 get { } //Length: 105
		 set { } //Length: 23
	}

	protected SerializedDictionary`1() { }

	public void Add(string key, TValue value) { }

	protected override void Awake() { }

	public void Clear() { }

	public bool ContainsKey(string key) { }

	public int get_Count() { }

	public TValue get_Item(string key) { }

	public List GetAllKeys() { }

	public List GetAllValues() { }

	protected override void InitializeDictionary() { }

	protected override void OnDestroy() { }

	public bool Remove(string key) { }

	public void Set(string key, TValue value) { }

	public void set_Item(string key, TValue value) { }

	public bool TryGetValue(string key, out TValue value) { }

}

