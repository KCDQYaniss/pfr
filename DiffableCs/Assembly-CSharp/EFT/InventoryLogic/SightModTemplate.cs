namespace EFT.InventoryLogic;

public class SightModTemplate : FunctionalModTemplate, ISightComponentTemplate, IAdjustableOpticData
{
	public int ScopesCount; //Field offset: 0x1A0
	public float[][] AimSensitivity; //Field offset: 0x1A8
	public int[] ModesCount; //Field offset: 0x1B0
	public float[][] Zooms; //Field offset: 0x1B8
	public int[][] CalibrationDistances; //Field offset: 0x1C0
	public string CustomAimPlane; //Field offset: 0x1C8
	public bool IsAdjustableOptic; //Field offset: 0x1D0
	public Vector3 MinMaxFov; //Field offset: 0x1D4
	public float ZoomSensitivity; //Field offset: 0x1E0
	public float AdjustableOpticSensitivity; //Field offset: 0x1E4
	public float AdjustableOpticSensitivityMax; //Field offset: 0x1E8

	private override float EFT.InventoryLogic.IAdjustableOpticData.AdjustableOpticSensitivity
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IAdjustableOpticData.AdjustableOpticSensitivityMax
	{
		private get { } //Length: 9
	}

	private override bool EFT.InventoryLogic.IAdjustableOpticData.IsAdjustableOptic
	{
		private get { } //Length: 8
	}

	private override Vector3 EFT.InventoryLogic.IAdjustableOpticData.MinMaxFov
	{
		private get { } //Length: 25
	}

	private override float EFT.InventoryLogic.IAdjustableOpticData.ZoomSensitivity
	{
		private get { } //Length: 9
	}

	private override float[][] EFT.InventoryLogic.ISightComponentTemplate.AimSensitivity
	{
		private get { } //Length: 8
	}

	private override int[][] EFT.InventoryLogic.ISightComponentTemplate.CalibrationDistances
	{
		private get { } //Length: 8
	}

	private override string EFT.InventoryLogic.ISightComponentTemplate.CustomAimPlane
	{
		private get { } //Length: 8
	}

	private override int[] EFT.InventoryLogic.ISightComponentTemplate.ModesCount
	{
		private get { } //Length: 8
	}

	private override int EFT.InventoryLogic.ISightComponentTemplate.ScopesCount
	{
		private get { } //Length: 7
	}

	private override float[][] EFT.InventoryLogic.ISightComponentTemplate.Zooms
	{
		private get { } //Length: 8
	}

	public SightModTemplate() { }

	private override float EFT.InventoryLogic.IAdjustableOpticData.get_AdjustableOpticSensitivity() { }

	private override float EFT.InventoryLogic.IAdjustableOpticData.get_AdjustableOpticSensitivityMax() { }

	private override bool EFT.InventoryLogic.IAdjustableOpticData.get_IsAdjustableOptic() { }

	private override Vector3 EFT.InventoryLogic.IAdjustableOpticData.get_MinMaxFov() { }

	private override float EFT.InventoryLogic.IAdjustableOpticData.get_ZoomSensitivity() { }

	private override float[][] EFT.InventoryLogic.ISightComponentTemplate.get_AimSensitivity() { }

	private override int[][] EFT.InventoryLogic.ISightComponentTemplate.get_CalibrationDistances() { }

	private override string EFT.InventoryLogic.ISightComponentTemplate.get_CustomAimPlane() { }

	private override int[] EFT.InventoryLogic.ISightComponentTemplate.get_ModesCount() { }

	private override int EFT.InventoryLogic.ISightComponentTemplate.get_ScopesCount() { }

	private override float[][] EFT.InventoryLogic.ISightComponentTemplate.get_Zooms() { }

}

