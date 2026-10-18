namespace Sirenix.OdinInspector.Internal;

public interface ISubGroupProviderAttribute
{

	public IList GetSubGroupAttributes() { }

	public string RepathMemberAttribute(PropertyGroupAttribute attr) { }

}

