namespace Sirenix.Serialization;

internal class TypeFormatterLocator : IFormatterLocator
{

	public TypeFormatterLocator() { }

	public override bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

}

