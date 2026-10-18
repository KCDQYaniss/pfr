namespace JsonType;

[JsonConverter(typeof(EFT.EnumConverter`1<JsonType.ELinkedPlatform>))]
public enum ELinkedPlatform
{
	Unknown = 0,
	Steam = 1,
}

