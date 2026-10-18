namespace Sirenix.Serialization;

internal class ISerializableFormatterLocator : IFormatterLocator
{

	public ISerializableFormatterLocator() { }

	public override bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

}

