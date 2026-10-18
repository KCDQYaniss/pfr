namespace System.Text.Json;

internal enum ConverterStrategy
{
	None = 0,
	Object = 1,
	Value = 2,
	Enumerable = 8,
	Dictionary = 16,
}

