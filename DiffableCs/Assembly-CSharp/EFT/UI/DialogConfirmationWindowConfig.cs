namespace EFT.UI;

public sealed class DialogConfirmationWindowConfig : SerializedScriptableObject
{
	private sealed class EntriesDictionary : UnitySerializedDictionary
	{

		public EntriesDictionary() { }

	}

	internal sealed class Entry
	{
		public Sprite LeftImage; //Field offset: 0x10
		public Sprite RightImage; //Field offset: 0x18
		public string TextKey; //Field offset: 0x20

		public Entry() { }

	}

	public const string PATH = "DialogConfirmationWindowConfig"; //Field offset: 0x0
	[SerializeField]
	private EntriesDictionary _entries; //Field offset: 0x58

	public DialogConfirmationWindowConfig() { }

	public bool TryGetEntry(string key, out Entry entry) { }

}

