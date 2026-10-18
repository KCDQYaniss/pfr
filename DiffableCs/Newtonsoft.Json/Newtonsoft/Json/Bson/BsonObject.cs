namespace Newtonsoft.Json.Bson;

internal class BsonObject : BsonToken, IEnumerable, IEnumerable
{
	private readonly List _children; //Field offset: 0x20

	public virtual BsonType Type
	{
		 get { } //Length: 3
	}

	public BsonObject() { }

	public void Add(string name, BsonToken token) { }

	public virtual BsonType get_Type() { }

	public override IEnumerator GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

