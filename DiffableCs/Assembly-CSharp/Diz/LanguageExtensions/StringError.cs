namespace Diz.LanguageExtensions;

public sealed class StringError : Error
{
	public readonly string Error; //Field offset: 0x10

	public StringError(string error) { }

	public virtual string ToString() { }

}

