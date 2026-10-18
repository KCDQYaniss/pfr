namespace System.Text.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public abstract class ReferenceHandler
{
	[CompilerGenerated]
	private static readonly ReferenceHandler <Preserve>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly ReferenceHandler <IgnoreCycles>k__BackingField; //Field offset: 0x8
	internal ReferenceHandlingStrategy HandlingStrategy; //Field offset: 0x10

	private static ReferenceHandler() { }

	protected ReferenceHandler() { }

	public abstract ReferenceResolver CreateResolver() { }

	internal override ReferenceResolver CreateResolver(bool writing) { }

}

