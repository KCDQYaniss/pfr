namespace System.Runtime.Serialization;

public sealed class SerializationInfoEnumerator : IEnumerator
{
	private readonly string[] _members; //Field offset: 0x10
	private readonly object[] _data; //Field offset: 0x18
	private readonly Type[] _types; //Field offset: 0x20
	private readonly int _numItems; //Field offset: 0x28
	private int _currItem; //Field offset: 0x2C
	private bool _current; //Field offset: 0x30

	public SerializationEntry Current
	{
		 get { } //Length: 231
	}

	public string Name
	{
		 get { } //Length: 131
	}

	public Type ObjectType
	{
		 get { } //Length: 131
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 100
	}

	public object Value
	{
		 get { } //Length: 131
	}

	internal SerializationInfoEnumerator(string[] members, object[] info, Type[] types, int numItems) { }

	public SerializationEntry get_Current() { }

	public string get_Name() { }

	public Type get_ObjectType() { }

	public object get_Value() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

