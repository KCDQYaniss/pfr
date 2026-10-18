namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[Flags]
internal enum MemLookFlags
{
	None = 0,
	Ctor = 2,
	NewObj = 16,
	Operator = 8,
	Indexer = 4,
	UserCallable = 256,
	BaseCall = 64,
	MustBeInvocable = 536870912,
	All = 536871262,
}

