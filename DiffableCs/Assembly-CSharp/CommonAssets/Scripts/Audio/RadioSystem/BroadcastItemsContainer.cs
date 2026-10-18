namespace CommonAssets.Scripts.Audio.RadioSystem;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/BroadcastGridContainer", fileName = "BroadcastGridContainer")]
public class BroadcastItemsContainer : ScriptableObject
{
	internal class BroadcastItemsData : SerializableEnumDictionary
	{

		public BroadcastItemsData() { }

	}

	[DefaultMember("Item")]
	internal class BroadcastItemsDataContainer : IEnumerable, IEnumerable
	{
		[SerializeField]
		private List _data; //Field offset: 0x10
		private readonly ExclusiveObjectsRandomizer _exclusiveRandomizer; //Field offset: 0x18

		public int Count
		{
			 get { } //Length: 65
		}

		public BroadcastItemData Item
		{
			 get { } //Length: 112
		}

		public BroadcastItemsDataContainer() { }

		public void Add(BroadcastItemData data) { }

		public int get_Count() { }

		public BroadcastItemData get_Item(int i) { }

		public override IEnumerator GetEnumerator() { }

		public bool Remove(BroadcastItemData data) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		public bool TryGetRandomData(out BroadcastItemData data) { }

	}

	[SerializeField]
	private BroadcastItemsData _broadcastItemsData; //Field offset: 0x18

	public BroadcastItemsContainer() { }

	public void OnDisable() { }

	public void OnEnable() { }

	public void OnValidate() { }

	public bool TryGetContent(EBroadcastItemType broadcastItemType, int index, out AudioClip clip) { }

	public bool TryGetRandomBroadcastData(EBroadcastItemType broadcastItemType, out BroadcastItemData data) { }

	private void UpdateData() { }

	private void Validate() { }

}

