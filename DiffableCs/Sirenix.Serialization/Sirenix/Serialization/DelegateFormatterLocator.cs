namespace Sirenix.Serialization;

internal class DelegateFormatterLocator : IFormatterLocator
{

	public DelegateFormatterLocator() { }

	public override bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

}

