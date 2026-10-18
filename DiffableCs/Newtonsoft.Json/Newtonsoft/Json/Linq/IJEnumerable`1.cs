namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[NullableContext(1)]
public interface IJEnumerable`1 : IEnumerable, IEnumerable
{

	public IJEnumerable Item
	{
		 get { } //Length: 0
	}

	public IJEnumerable get_Item(object key) { }

}

