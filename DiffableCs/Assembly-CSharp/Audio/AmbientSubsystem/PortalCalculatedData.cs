namespace Audio.AmbientSubsystem;

public struct PortalCalculatedData
{
	public float score; //Field offset: 0x0
	public float distanceToListener; //Field offset: 0x4
	public readonly PortalData portalData; //Field offset: 0x8

	public PortalCalculatedData(float score, float distanceToListener, PortalData portalData) { }

	public static PortalCalculatedData Default() { }

}

