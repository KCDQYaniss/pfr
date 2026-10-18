namespace EFT;

public struct StationaryWeaponPacket
{
	internal enum EStationaryCommand
	{
		Occupy = 0,
		Leave = 1,
		Denied = 2,
	}

	public bool HasInteraction; //Field offset: 0x0
	public string Id; //Field offset: 0x8
	public EStationaryCommand StationaryCommand; //Field offset: 0x10
	public bool FinalizeObserverCrutch; //Field offset: 0x11
	public bool IsStationaryFinal; //Field offset: 0x12

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(StationaryWeaponPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StationaryWeaponPacket left, StationaryWeaponPacket right) { }

	public static bool op_Inequality(StationaryWeaponPacket left, StationaryWeaponPacket right) { }

	public void Serialize(IBitWriterStream writer) { }

}

