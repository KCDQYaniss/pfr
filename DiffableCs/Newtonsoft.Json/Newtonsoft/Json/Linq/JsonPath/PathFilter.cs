namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(2)]
internal abstract class PathFilter
{

	protected PathFilter() { }

	[NullableContext(1)]
	public abstract IEnumerable ExecuteFilter(JToken root, IEnumerable current, JsonSelectSettings settings) { }

	protected static JToken GetNextScanValue(JToken originalParent, JToken container, JToken value) { }

	protected static JToken GetTokenIndex(JToken t, JsonSelectSettings settings, int index) { }

}

