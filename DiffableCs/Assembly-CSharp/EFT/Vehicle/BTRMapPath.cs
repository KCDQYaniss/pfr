namespace EFT.Vehicle;

public struct BTRMapPath
{
	public string mapID; //Field offset: 0x0
	[JsonProperty("pathsConfigurations")]
	public PathConfig[] pathsConfigurations; //Field offset: 0x8
	public float DiameterWheel; //Field offset: 0x10
	public float HeightWheel; //Field offset: 0x14
	public float HeightWheelMaxPosLimit; //Field offset: 0x18
	public float HeightWheelMinPosLimit; //Field offset: 0x1C
	public float SnapToSurfaceWheelsSpeed; //Field offset: 0x20
	public float CheckSurfaceForWheelsTimer; //Field offset: 0x24
	public float HeightWheelOffset; //Field offset: 0x28
	public string BtrSkin; //Field offset: 0x30
	public float SuspensionRestLength; //Field offset: 0x38
	public float SuspensionTravel; //Field offset: 0x3C
	public float SuspensionSpringStiffness; //Field offset: 0x40
	public float SuspensionDamperStiffness; //Field offset: 0x44
	public float SuspensionWheelRadius; //Field offset: 0x48

}

