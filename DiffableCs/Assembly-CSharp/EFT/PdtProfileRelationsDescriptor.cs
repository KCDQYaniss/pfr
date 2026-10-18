namespace EFT;

[JsonConverter(typeof(PdtProfileRelationsConverter))]
public sealed class PdtProfileRelationsDescriptor
{
	private sealed class PdtProfileRelationsConverter : JsonConverter
	{

		public PdtProfileRelationsConverter() { }

		private static JToken GetProp(JObject props, string camelName, string pascalName) { }

		private static string ReadAccountId(JToken token) { }

		private static string[] ReadAccountIds(JToken token) { }

		public virtual PdtProfileRelationsDescriptor ReadJson(JsonReader reader, Type objectType, PdtProfileRelationsDescriptor existingValue, bool hasExistingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, PdtProfileRelationsDescriptor value, JsonSerializer serializer) { }

	}

	[JsonProperty("operatorAccountId")]
	public string OperatorAccountId; //Field offset: 0x10
	[JsonProperty("candidateAccountIds")]
	public string[] CandidateAccountIds; //Field offset: 0x18

	public PdtProfileRelationsDescriptor() { }

}

