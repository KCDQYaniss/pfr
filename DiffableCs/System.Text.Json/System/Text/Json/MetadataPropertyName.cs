namespace System.Text.Json;

[Flags]
internal enum MetadataPropertyName
{
	None = 0,
	Values = 1,
	Id = 2,
	Ref = 4,
	Type = 8,
}

