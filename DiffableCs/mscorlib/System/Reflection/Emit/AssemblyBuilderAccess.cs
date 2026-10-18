namespace System.Reflection.Emit;

[ComVisible(True)]
[Flags]
public enum AssemblyBuilderAccess
{
	Run = 1,
	Save = 2,
	RunAndSave = 3,
	ReflectionOnly = 6,
	RunAndCollect = 9,
}

