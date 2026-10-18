namespace EFT.Water;

public class WaterIds
{
	public static readonly int CameraColorBufferId; //Field offset: 0x0
	public const string WATER_MASK_SHADER_NAME = "Hidden/Water/Mask"; //Field offset: 0x0
	public const string UNDERWATER_SHADER_NAME = "Hidden/Water/Underwater"; //Field offset: 0x0
	public const string BLUR_SHADER_NAME = "Hidden/Blur/KawaseDualFilter"; //Field offset: 0x0
	public const string WATER_FRONT_INIT_SAMPLE = "WATER FRONTSIDE INIT"; //Field offset: 0x0
	public const string WATER_FRONT_SAMPLE = "WATER FRONTSIDE"; //Field offset: 0x0
	public const string WATER_FRONT_RESTORE_SAMPLE = "WATER FRONTSIDE RESTORE"; //Field offset: 0x0
	public const string WATER_FRONT_SHADER_NAME = "Hidden/Water/SurfaceFront"; //Field offset: 0x0
	public const string WATER_MASK_SAMPLE = "WATER MASK"; //Field offset: 0x0
	public const string UNDERWATER_SAMPLE = "UNDERWATER"; //Field offset: 0x0
	public const string WATER_CONFIGURE_TARGET_SAMPLE = "WATER CONFIGURE TARGET"; //Field offset: 0x0
	public const string WATER_BLUR_TARGET_SAMPLE = "WATER BLUR TARGET"; //Field offset: 0x0
	public const string WATER_DOWNSAMPLE_BLUR_TARGET_SAMPLE = "WATER DOWNSAMPLE BLUR TARGET"; //Field offset: 0x0
	public const string WATER_UPSAMPLE_BLUR_TARGET_SAMPLE = "WATER UPSAMPLE BLUR TARGET"; //Field offset: 0x0
	public const string UNDERWATER_DOWNSAMPLE_TEMP = "_Underwater_Downsample"; //Field offset: 0x0
	public const string WATER_DYNAMIC_FOAM_SAMPLE = "WATER DYNAMIC FOAM"; //Field offset: 0x0
	public const string UNDERWATER_UPSAMPLE_TEMP = "_Underwater_Upsample"; //Field offset: 0x0
	public const string WATER_DYNAMIC_EFFECTS_NAME = "WATER_DYNAMIC_EFFECTS"; //Field offset: 0x0
	public static readonly int CameraColorBlurBufferId; //Field offset: 0x4
	public static readonly int UnderwaterMaskId; //Field offset: 0x8
	public static readonly int WDEBufferId; //Field offset: 0xC
	public static readonly int FrustumCornersWSId; //Field offset: 0x10
	public static readonly int CameraWSId; //Field offset: 0x14
	public static readonly int UnityMatrixInvViewProjId; //Field offset: 0x18
	public static readonly int WaterLevelId; //Field offset: 0x1C
	public static readonly int WaterIORId; //Field offset: 0x20
	public static readonly int WaterForSsrSavedG0Id; //Field offset: 0x24
	public static readonly int WaterForSsrSavedG2Id; //Field offset: 0x28
	public static readonly int NormalXZDepthDampingId; //Field offset: 0x2C
	public static readonly int NormalYDampingId; //Field offset: 0x30
	public static readonly int FogColorId; //Field offset: 0x34
	public static readonly int SpecularId; //Field offset: 0x38
	public static readonly int SmoothnessId; //Field offset: 0x3C
	public static readonly int FresnelPowerId; //Field offset: 0x40
	public static readonly int ReflectionPowerId; //Field offset: 0x44
	public static readonly int AdditionalLightDampingId; //Field offset: 0x48
	public static readonly int UnderwaterSurfaceTranslucencyId; //Field offset: 0x4C
	public static readonly int DepthAttenId; //Field offset: 0x50
	public static readonly int DensityId; //Field offset: 0x54
	public static readonly int FogDistanceId; //Field offset: 0x58
	public static readonly int InvFadeId; //Field offset: 0x5C
	public static readonly int MaxFogLightDepthId; //Field offset: 0x60
	public static readonly int MaxDirLightDepthId; //Field offset: 0x64
	public static readonly int AbsorptionMaxHeightId; //Field offset: 0x68
	public static readonly int AbsorptionHeightId; //Field offset: 0x6C
	public static readonly int AbsorptionStrengthId; //Field offset: 0x70
	public static readonly int AbsorptionDepthId; //Field offset: 0x74
	public static readonly int AbsorptionCancellationId; //Field offset: 0x78
	public static readonly int AbsorptionColorStrengthId; //Field offset: 0x7C
	public static readonly int ScatteringColorId; //Field offset: 0x80
	public static readonly int ScatteringPowerId; //Field offset: 0x84
	public static readonly int ScatteringNormalInfluenceId; //Field offset: 0x88
	public static readonly int ScatteringOcclusionId; //Field offset: 0x8C
	public static readonly int ScatteringIntensityId; //Field offset: 0x90
	public static readonly int FoamTexDynamicId; //Field offset: 0x94
	public static readonly int FoamDirectionId; //Field offset: 0x98
	public static readonly int FoamTilingId; //Field offset: 0x9C
	public static readonly int FoamSpeedId; //Field offset: 0xA0
	public static readonly int FoamIntensityId; //Field offset: 0xA4
	public static readonly int RefractionIntensityId; //Field offset: 0xA8
	public static readonly int RefractionScaleId; //Field offset: 0xAC
	public static readonly int RefractionSpeedId; //Field offset: 0xB0

	private static WaterIds() { }

	public WaterIds() { }

}

