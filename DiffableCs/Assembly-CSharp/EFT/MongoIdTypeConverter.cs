namespace EFT;

public sealed class MongoIdTypeConverter : TypeConverter
{

	public MongoIdTypeConverter() { }

	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

}

