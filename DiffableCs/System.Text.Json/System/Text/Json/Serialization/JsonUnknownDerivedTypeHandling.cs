namespace System.Text.Json.Serialization;

public enum JsonUnknownDerivedTypeHandling
{
	FailSerialization = 0,
	FallBackToBaseType = 1,
	FallBackToNearestAncestor = 2,
}

