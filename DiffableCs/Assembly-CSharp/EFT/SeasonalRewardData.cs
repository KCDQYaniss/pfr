namespace EFT;

[GenerateBinarySerialization]
[JsonConverter(typeof(SeasonalRewardDataConverter))]
public sealed class SeasonalRewardData
{
	private sealed class SeasonalRewardDataConverter : JsonConverter
	{

		public SeasonalRewardDataConverter() { }

		public virtual SeasonalRewardData ReadJson(JsonReader reader, Type objectType, SeasonalRewardData existingValue, bool hasExistingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, SeasonalRewardData value, JsonSerializer serializer) { }

	}

	public HashSet Data; //Field offset: 0x10

	public SeasonalRewardData() { }

	public SeasonalRewardData(IEnumerable data) { }

}

