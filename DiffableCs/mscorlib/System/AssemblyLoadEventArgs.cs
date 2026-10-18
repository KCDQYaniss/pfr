namespace System;

public class AssemblyLoadEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly Assembly <LoadedAssembly>k__BackingField; //Field offset: 0x10

	public Assembly LoadedAssembly
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AssemblyLoadEventArgs(Assembly loadedAssembly) { }

	[CompilerGenerated]
	public Assembly get_LoadedAssembly() { }

}

