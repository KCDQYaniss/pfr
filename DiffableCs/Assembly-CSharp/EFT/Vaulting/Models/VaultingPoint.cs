namespace EFT.Vaulting.Models;

public struct VaultingPoint
{
	public int Index; //Field offset: 0x0
	public Vector3 LocalPoint; //Field offset: 0x4
	public Vector3 WorldPoint; //Field offset: 0x10
	public float Weight; //Field offset: 0x1C
	public Collider Collider; //Field offset: 0x20

}

