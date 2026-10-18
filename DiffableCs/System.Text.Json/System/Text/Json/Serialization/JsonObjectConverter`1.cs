namespace System.Text.Json.Serialization;

internal abstract class JsonObjectConverter`1 : JsonResumableConverter
{

	internal virtual bool CanPopulate
	{
		internal get { } //Length: 3
	}

	internal virtual Type ElementType
	{
		internal get { } //Length: 3
	}

	protected JsonObjectConverter`1() { }

	internal virtual bool get_CanPopulate() { }

	internal virtual Type get_ElementType() { }

	virtual ConverterStrategy GetDefaultConverterStrategy() { }

}

