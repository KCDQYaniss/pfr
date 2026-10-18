namespace EFT;

public sealed class AutoMoveRestrictions : IAutoMoveRestrictions, IVaultingRestrictions
{
	public bool IsActive; //Field offset: 0x10
	public float MinDistantToInteract; //Field offset: 0x14
	public float MinHeight; //Field offset: 0x18
	public float MaxHeight; //Field offset: 0x1C
	public float MinLength; //Field offset: 0x20
	public float MaxLength; //Field offset: 0x24

	private override bool EFT.Vaulting.IVaultingRestrictions.IsActive
	{
		private get { } //Length: 5
	}

	private override float EFT.Vaulting.IVaultingRestrictions.MaxHeight
	{
		private get { } //Length: 6
	}

	private override float EFT.Vaulting.IVaultingRestrictions.MaxLength
	{
		private get { } //Length: 6
	}

	private override float EFT.Vaulting.IVaultingRestrictions.MinDistantToInteract
	{
		private get { } //Length: 6
	}

	private override float EFT.Vaulting.IVaultingRestrictions.MinHeight
	{
		private get { } //Length: 6
	}

	private override float EFT.Vaulting.IVaultingRestrictions.MinLength
	{
		private get { } //Length: 6
	}

	public AutoMoveRestrictions() { }

	private override bool EFT.Vaulting.IVaultingRestrictions.get_IsActive() { }

	private override float EFT.Vaulting.IVaultingRestrictions.get_MaxHeight() { }

	private override float EFT.Vaulting.IVaultingRestrictions.get_MaxLength() { }

	private override float EFT.Vaulting.IVaultingRestrictions.get_MinDistantToInteract() { }

	private override float EFT.Vaulting.IVaultingRestrictions.get_MinHeight() { }

	private override float EFT.Vaulting.IVaultingRestrictions.get_MinLength() { }

}

