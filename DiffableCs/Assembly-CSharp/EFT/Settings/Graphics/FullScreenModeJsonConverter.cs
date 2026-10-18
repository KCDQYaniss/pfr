namespace EFT.Settings.Graphics;

public sealed class FullScreenModeJsonConverter : JsonConverter
{

	public FullScreenModeJsonConverter() { }

	public virtual FullScreenMode ReadJson(JsonReader reader, Type objectType, FullScreenMode existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, FullScreenMode value, JsonSerializer serializer) { }

}

