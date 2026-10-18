namespace EFT.Ballistics;

public static class BallisticsCalculatorConstants
{
	public const float PENETRATION_RICOCHET_PENALTY = 0.5; //Field offset: 0x0
	public const float SPEED_PENETRATION_PENALTY = 0.8; //Field offset: 0x0
	public const float CHANCE_DEVIATION_PENALTY = 0.08; //Field offset: 0x0
	public const float CHANCE_PENETRATION_PENALTY = 0.2; //Field offset: 0x0
	public const float SPEED_FRAGMENTATION_PENALTY = 0.7; //Field offset: 0x0
	public const float CHANCE_FRAGMENTATION_PENALTY = 0.2; //Field offset: 0x0
	private static readonly string[] STATIC_HITTABLE_LAYERS; //Field offset: 0x0
	public const float PENETRATION_FRAGMENTATION_PENALTY = 0.5; //Field offset: 0x0
	public const float SPEED_RICOCHET_PENALTY = 0.7; //Field offset: 0x0
	public const float CHANCE_RICOCHET_PENALTY = 0.2; //Field offset: 0x0
	public const float DAMAGE_RICOCHET_PENALTY = 0.5; //Field offset: 0x0
	public const float DAMAGE_FRAGMENTATION_PENALTY = 0.5; //Field offset: 0x0
	private static readonly string[] DYNAMIC_HITTABLE_LAYERS; //Field offset: 0x8
	private static readonly string[] BODY_PARTS_HITTABLE_LAYERS; //Field offset: 0x10
	private static readonly string[] SPIRIT_HITTABLE_LAYERS; //Field offset: 0x18
	public static LayerMask StaticObjectsHitMask; //Field offset: 0x20
	public static LayerMask HitMask; //Field offset: 0x24
	public static LayerMask SpiritHitMask; //Field offset: 0x28
	public static LayerMask SpiritHitMaskSecondPass; //Field offset: 0x2C
	public static LayerMask PlayerLayer; //Field offset: 0x30
	public static LayerMask PlayerSpiritAuraLayer; //Field offset: 0x34
	public static LayerMask PlayerSpiritAuraLayerMask; //Field offset: 0x38
	public static LayerMask PlayerMask; //Field offset: 0x3C

	private static BallisticsCalculatorConstants() { }

	private static LayerMask GetHitMask(string[] layers) { }

	public static void Warmup() { }

}

