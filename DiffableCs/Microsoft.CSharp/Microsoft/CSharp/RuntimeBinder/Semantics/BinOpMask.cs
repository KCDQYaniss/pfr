namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[Flags]
internal enum BinOpMask
{
	None = 0,
	Add = 1,
	Sub = 2,
	Mul = 4,
	Shift = 8,
	Equal = 16,
	Compare = 32,
	Bitwise = 64,
	BitXor = 128,
	Logical = 256,
	Integer = 247,
	Real = 55,
	BoolNorm = 144,
	Delegate = 19,
	Enum = 242,
	EnumUnder = 3,
	UnderEnum = 1,
}

