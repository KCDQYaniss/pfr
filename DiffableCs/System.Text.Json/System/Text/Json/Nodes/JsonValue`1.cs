namespace System.Text.Json.Nodes;

[DebuggerDisplay("{ToJsonString(),nq}")]
[DebuggerTypeProxy(typeof(DebugView))]
internal abstract class JsonValue`1 : JsonValue
{
	[DebuggerDisplay("{Json,nq}")]
	[ExcludeFromCodeCoverage]
	private sealed class DebugView
	{

	}

	internal readonly TValue Value; //Field offset: 0x0

	protected JsonValue`1(TValue value, Nullable options = null) { }

}

