namespace FastAnimatorSystem;

public class StateBehaviorConverterAttribute : Attribute
{
	private readonly Type _convertedType; //Field offset: 0x10

	public StateBehaviorConverterAttribute(Type convertedType) { }

	public IFastStateConverter GetConverter() { }

}

