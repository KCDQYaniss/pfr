namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
public sealed class InternalsVisibleToAttribute : Attribute
{
	private string _assemblyName; //Field offset: 0x10
	private bool _allInternalsVisible; //Field offset: 0x18

	public bool AllInternalsVisible
	{
		 set { } //Length: 4
	}

	public string AssemblyName
	{
		 get { } //Length: 5
	}

	public InternalsVisibleToAttribute(string assemblyName) { }

	public string get_AssemblyName() { }

	public void set_AllInternalsVisible(bool value) { }

}

