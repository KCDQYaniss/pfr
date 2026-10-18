namespace System.Collections.Specialized;

[DefaultMember("Item")]
public class NameValueCollection : NameObjectCollectionBase
{
	private string[] _all; //Field offset: 0x58
	private string[] _allKeys; //Field offset: 0x60

	public override string[] AllKeys
	{
		 get { } //Length: 423
	}

	public string Item
	{
		 get { } //Length: 20
	}

	public string Item
	{
		 get { } //Length: 20
		 set { } //Length: 20
	}

	public NameValueCollection() { }

	protected NameValueCollection(SerializationInfo info, StreamingContext context) { }

	public NameValueCollection(int capacity, IEqualityComparer equalityComparer) { }

	internal NameValueCollection(DBNull dummy) { }

	public NameValueCollection(NameValueCollection col) { }

	public NameValueCollection(int capacity) { }

	public override void Add(string name, string value) { }

	public void Add(NameValueCollection c) { }

	public override void Clear() { }

	public override string Get(int index) { }

	public override string Get(string name) { }

	public override string[] get_AllKeys() { }

	public string get_Item(string name) { }

	public string get_Item(int index) { }

	private static string GetAsOneString(ArrayList list) { }

	private static string[] GetAsStringArray(ArrayList list) { }

	public override string GetKey(int index) { }

	public override string[] GetValues(string name) { }

	public override string[] GetValues(int index) { }

	protected void InvalidateCachedArrays() { }

	public override void Remove(string name) { }

	public override void Set(string name, string value) { }

	public void set_Item(string name, string value) { }

}

