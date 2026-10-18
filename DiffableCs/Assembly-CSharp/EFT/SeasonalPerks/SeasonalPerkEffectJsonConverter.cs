namespace EFT.SeasonalPerks;

public sealed class SeasonalPerkEffectJsonConverter : JsonConverter
{
	private const string EFFECT_ID_KEY = "effectId"; //Field offset: 0x0

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public SeasonalPerkEffectJsonConverter() { }

	public virtual bool get_CanWrite() { }

	public virtual ISeasonalPerkEffectData ReadJson(JsonReader reader, Type objectType, ISeasonalPerkEffectData existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, ISeasonalPerkEffectData value, JsonSerializer serializer) { }

}

