namespace Bsg.GameSettings.Json;

public sealed class SimpleJsonSerializer : IJsonSerializer
{
	private readonly JsonSerializer _jsonSerializer; //Field offset: 0x10

	public SimpleJsonSerializer(JsonSerializerSettings serializerSettings) { }

	public override T Populate(JObject json, T item, out bool needReSave) { }

	public override JObject PrepareToSave(T item) { }

}

