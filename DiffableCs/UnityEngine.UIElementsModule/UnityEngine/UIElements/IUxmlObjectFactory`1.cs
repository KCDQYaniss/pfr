namespace UnityEngine.UIElements;

internal interface IUxmlObjectFactory`1 : IBaseUxmlObjectFactory, IBaseUxmlFactory
{

	public T CreateObject(IUxmlAttributes bag, CreationContext cc) { }

}

