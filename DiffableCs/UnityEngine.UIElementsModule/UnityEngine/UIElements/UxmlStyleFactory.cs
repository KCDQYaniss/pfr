namespace UnityEngine.UIElements;

public class UxmlStyleFactory : UxmlFactory
{

	public virtual string uxmlName
	{
		 get { } //Length: 49
	}

	public virtual string uxmlQualifiedName
	{
		 get { } //Length: 125
	}

	public UxmlStyleFactory() { }

	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	public virtual string get_uxmlName() { }

	public virtual string get_uxmlQualifiedName() { }

}

