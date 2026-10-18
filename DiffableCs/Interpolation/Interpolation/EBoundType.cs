namespace Interpolation;

[Flags]
public enum EBoundType
{
	Unknown = 0,
	Less = 1,
	LessOrEqual = 3,
	Equals = 6,
	GreaterOrEqual = 13,
	Greater = 27,
}

