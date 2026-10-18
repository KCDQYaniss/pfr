namespace Unity.Properties;

public abstract class ContainerPropertyBag`1 : PropertyBag
{
	private readonly List m_PropertiesList; //Field offset: 0x0
	private readonly Dictionary m_PropertiesHash; //Field offset: 0x0

	private static ContainerPropertyBag`1() { }

	protected ContainerPropertyBag`1() { }

	protected void AddProperty(Property property) { }

	public override bool TryGetProperty(ref TContainer container, string name, out IProperty property) { }

}

