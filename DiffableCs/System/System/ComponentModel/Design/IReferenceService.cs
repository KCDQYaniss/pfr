namespace System.ComponentModel.Design;

public interface IReferenceService
{

	public string GetName(object reference) { }

	public object GetReference(string name) { }

	public object[] GetReferences(Type baseType) { }

}

