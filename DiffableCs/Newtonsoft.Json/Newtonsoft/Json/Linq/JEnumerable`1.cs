namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
public struct JEnumerable`1 : IJEnumerable, IEnumerable, IEnumerable, IEquatable
{
	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	public static readonly JEnumerable Empty; //Field offset: 0x0
	private readonly IEnumerable _enumerable; //Field offset: 0x0

	public override IJEnumerable Item
	{
		 get { } //Length: 410
	}

	private static JEnumerable`1() { }

	public JEnumerable`1(IEnumerable enumerable) { }

	public override bool Equals(JEnumerable other) { }

	public virtual bool Equals(object obj) { }

	public override IJEnumerable get_Item(object key) { }

	public override IEnumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

