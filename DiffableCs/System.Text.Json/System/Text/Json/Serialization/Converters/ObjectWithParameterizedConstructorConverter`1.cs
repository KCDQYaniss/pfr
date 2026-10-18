namespace System.Text.Json.Serialization.Converters;

internal abstract class ObjectWithParameterizedConstructorConverter`1 : ObjectDefaultConverter
{

	internal virtual bool ConstructorIsParameterized
	{
		internal get { } //Length: 3
	}

	protected ObjectWithParameterizedConstructorConverter`1() { }

	internal virtual bool get_ConstructorIsParameterized() { }

}

