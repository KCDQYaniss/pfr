namespace Bsg.GameSettings.Json;

public sealed class GameSettingsJsonConverter : JsonConverter
{

	public GameSettingsJsonConverter() { }

	public virtual IGameSetting ReadJson(JsonReader reader, Type objectType, IGameSetting existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, IGameSetting value, JsonSerializer serializer) { }

}

