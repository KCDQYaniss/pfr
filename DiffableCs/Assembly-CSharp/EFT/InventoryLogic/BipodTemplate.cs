namespace EFT.InventoryLogic;

public class BipodTemplate : FunctionalModTemplate
{
	public float BipodRecoilMultiplier; //Field offset: 0x1A0
	public float BipodReturnHandSpeedMultiplier; //Field offset: 0x1A4
	public float BipodCameraSnapMultiplier; //Field offset: 0x1A8
	public float BipodOutOfStaminaBreathMultiplier; //Field offset: 0x1AC
	public Vector2 PitchLimitProneBipod; //Field offset: 0x1B0
	public Vector2 YawLimitProneBipod; //Field offset: 0x1B8

	public BipodTemplate() { }

}

