namespace GPUInstancer;

public static class GPUInstancerConstants
{
	internal static class BufferToTextureKernelPoperties
	{
		public static readonly int TRANSFORMATION_MATRIX_TEXTURE; //Field offset: 0x0

		private static BufferToTextureKernelPoperties() { }

	}

	internal static class CopyTextureKernelProperties
	{
		public static readonly int SOURCE_TEXTURE; //Field offset: 0x0
		public static readonly int DESTINATION_TEXTURE; //Field offset: 0x4
		public static readonly int OFFSET_X; //Field offset: 0x8
		public static readonly int SOURCE_SIZE_X; //Field offset: 0xC
		public static readonly int SOURCE_SIZE_Y; //Field offset: 0x10
		public static readonly int DESTINATION_SIZE_X; //Field offset: 0x14
		public static readonly int DESTINATION_SIZE_Y; //Field offset: 0x18
		public static readonly int REVERSE_Z; //Field offset: 0x1C

		private static CopyTextureKernelProperties() { }

	}

	internal static class GrassKernelProperties
	{
		public static readonly int DETAIL_MAP_DATA_BUFFER; //Field offset: 0x0
		public static readonly int HEIGHT_MAP_DATA_BUFFER; //Field offset: 0x4
		public static readonly int COUNTER_BUFFER; //Field offset: 0x8
		public static readonly int COUNT_FACTOR; //Field offset: 0xC
		public static readonly int TERRAIN_DETAIL_RESOLUTION_DATA; //Field offset: 0x10
		public static readonly int TERRAIN_HEIGHT_RESOLUTION_DATA; //Field offset: 0x14
		public static readonly int GRASS_START_POSITION_DATA; //Field offset: 0x18
		public static readonly int TERRAIN_SIZE_DATA; //Field offset: 0x1C
		public static readonly int DETAIL_SCALE_DATA; //Field offset: 0x20
		public static readonly int DETAIL_AND_HEIGHT_MAP_SIZE_DATA; //Field offset: 0x24
		public static readonly int HEALTHY_DRY_NOISE_TEXTURE; //Field offset: 0x28
		public static readonly int NOISE_SPREAD; //Field offset: 0x2C
		public static readonly int DETAIL_UNIQUE_VALUE; //Field offset: 0x30
		public static readonly int DETAIL_DENSITY; //Field offset: 0x34
		public static readonly int DETAIL_TERRAIN_NORMAL; //Field offset: 0x38

		private static GrassKernelProperties() { }

	}

	internal static class RuntimeModificationKernelProperties
	{
		public static readonly int BUFFER_PARAMETER_POSITION_OFFSET; //Field offset: 0x0
		public static readonly int BUFFER_PARAMETER_MODIFIER_TRANSFORM; //Field offset: 0x4
		public static readonly int BUFFER_PARAMETER_MODIFIER_RADIUS; //Field offset: 0x8
		public static readonly int BUFFER_PARAMETER_MODIFIER_HEIGHT; //Field offset: 0xC
		public static readonly int BUFFER_PARAMETER_MODIFIER_AXIS; //Field offset: 0x10

		private static RuntimeModificationKernelProperties() { }

	}

	internal static class SetDataKernelProperties
	{
		public static readonly int BUFFER_PARAMETER_MANAGED_BUFFER_DATA; //Field offset: 0x0
		public static readonly int BUFFER_PARAMETER_COMPUTE_BUFFER_START_INDEX; //Field offset: 0x4
		public static readonly int BUFFER_PARAMETER_COUNT; //Field offset: 0x8
		public static readonly int BUFFER_PARAMETER_DATA_TO_SET; //Field offset: 0xC

		private static SetDataKernelProperties() { }

	}

	internal static class TreeKernelProperties
	{
		public static readonly int TREE_DATA; //Field offset: 0x0
		public static readonly int TREE_SCALES; //Field offset: 0x4
		public static readonly int TERRAIN_POSITION; //Field offset: 0x8
		public static readonly int IS_APPLY_ROTATION; //Field offset: 0xC
		public static readonly int IS_APPLY_TERRAIN_HEIGHT; //Field offset: 0x10
		public static readonly int PROTOTYPE_INDEX; //Field offset: 0x14

		private static TreeKernelProperties() { }

	}

	internal static class VisibilityKernelPoperties
	{
		public static readonly int TRANSFORMATION_MATRIX_BUFFER; //Field offset: 0x0
		public static readonly int INSTANCE_LOD_BUFFER; //Field offset: 0x4
		public static readonly int[] TRANSFORMATION_MATRIX_APPEND_BUFFERS; //Field offset: 0x8
		public static readonly int INSTANCE_DATA_BUFFER; //Field offset: 0x10
		public static readonly int RENDERER_TRANSFORM_OFFSET; //Field offset: 0x14
		public static readonly int BUFFER_PARAMETER_MVP_MATRIX; //Field offset: 0x18
		public static readonly int BUFFER_PARAMETER_MVP_MATRIX2; //Field offset: 0x1C
		public static readonly int BUFFER_PARAMETER_BOUNDS_CENTER; //Field offset: 0x20
		public static readonly int BUFFER_PARAMETER_BOUNDS_EXTENTS; //Field offset: 0x24
		public static readonly int BUFFER_PARAMETER_FRUSTUM_CULL_SWITCH; //Field offset: 0x28
		public static readonly int BUFFER_PARAMETER_HIERARCHICAL_Z_TEXTURE_SIZE; //Field offset: 0x2C
		public static readonly int BUFFER_PARAMETER_FRUSTUM_OFFSET; //Field offset: 0x30
		public static readonly int BUFFER_PARAMETER_MIN_VIEW_DISTANCE; //Field offset: 0x34
		public static readonly int BUFFER_PARAMETER_MAX_VIEW_DISTANCE; //Field offset: 0x38
		public static readonly int BUFFER_PARAMETER_CAMERA_POSITION; //Field offset: 0x3C
		public static readonly int BUFFER_PARAMETER_BUFFER_SIZE; //Field offset: 0x40
		public static readonly int BUFFER_PARAMETER_OCCLUSION_OFFSET; //Field offset: 0x44
		public static readonly int BUFFER_PARAMETER_OCCLUSION_ACCURACY; //Field offset: 0x48
		public static readonly int BUFFER_PARAMETER_SHADOW_DISTANCE; //Field offset: 0x4C
		public static readonly int BUFFER_PARAMETER_LOD_SIZES; //Field offset: 0x50
		public static readonly int BUFFER_PARAMETER_LOD_SHIFT; //Field offset: 0x54
		public static readonly int BUFFER_PARAMETER_LOD_APPEND_INDEX; //Field offset: 0x58
		public static readonly int BUFFER_PARAMETER_LOD_COUNT; //Field offset: 0x5C
		public static readonly int BUFFER_PARAMETER_LOD_LEVEL; //Field offset: 0x60
		public static readonly int BUFFER_PARAMETER_HALF_ANGLE; //Field offset: 0x64
		public static readonly int BUFFER_PARAMETER_ANIMATE_CROSS_FADE; //Field offset: 0x68
		public static readonly int BUFFER_PARAMETER_DELTA_TIME; //Field offset: 0x6C
		public static readonly int BUFFER_PARAMETER_FADE_LEVEL_MULTIPLIER; //Field offset: 0x70
		public static readonly int BUFFER_PARAMETER_OCCLUSION_CULL_SWITCH; //Field offset: 0x74
		public static readonly int BUFFER_PARAMETER_HIERARCHICAL_Z_TEXTURE_MAP; //Field offset: 0x78
		public static readonly int BUFFER_PARAMETER_MIN_CULLING_DISTANCE; //Field offset: 0x7C
		public static readonly int BUFFER_PARAMETER_SHADOW_LOD_MAP; //Field offset: 0x80
		public static readonly int BUFFER_PARAMETER_CULL_SHADOW; //Field offset: 0x84

		private static VisibilityKernelPoperties() { }

	}

	public static GPUInstancerSettings gpuiSettings; //Field offset: 0x0
	public const float FADE_DIST = 5; //Field offset: 0x0
	public static readonly Matrix4x4 zeroMatrix; //Field offset: 0x8
	public static readonly int STRIDE_SIZE_MATRIX4X4; //Field offset: 0x48
	public static readonly int STRIDE_SIZE_BOOL; //Field offset: 0x4C
	public static readonly int STRIDE_SIZE_INT; //Field offset: 0x50
	public static readonly int STRIDE_SIZE_FLOAT; //Field offset: 0x54
	public static readonly int STRIDE_SIZE_FLOAT4; //Field offset: 0x58
	public static float COMPUTE_SHADER_THREAD_COUNT; //Field offset: 0x5C
	public static float COMPUTE_SHADER_THREAD_COUNT_2D; //Field offset: 0x60
	public static int COMPUTE_MAX_LOD_BUFFER; //Field offset: 0x64
	public static int TEXTURE_MAX_SIZE; //Field offset: 0x68
	public static bool DETAIL_STORE_INSTANCE_DATA; //Field offset: 0x6C
	public static readonly string GUID_COMPUTE_PLATFORM_DEFINES; //Field offset: 0x70
	public static readonly string GUID_CGINC_PLATFORM_DEPENDENT; //Field offset: 0x78
	public static readonly string[] CAMERA_COMPUTE_KERNELS; //Field offset: 0x80
	public static readonly string[] VISIBILITY_COMPUTE_KERNELS; //Field offset: 0x88
	public static readonly string CAMERA_COMPUTE_RESOURCE_PATH; //Field offset: 0x90
	public static readonly string CAMERA_VR_COMPUTE_RESOURCE_PATH; //Field offset: 0x98
	public static readonly string VISIBILITY_COMPUTE_RESOURCE_PATH; //Field offset: 0xA0
	public static readonly string VISIBILITY_COMPUTE_RESOURCE_PATH_VULKAN; //Field offset: 0xA8
	public static readonly string BUFFER_TO_TEXTURE_COMPUTE_RESOURCE_PATH; //Field offset: 0xB0
	public static readonly string BUFFER_TO_TEXTURE_KERNEL; //Field offset: 0xB8
	public static readonly int BUFFER_COROUTINE_STEP_NUMBER; //Field offset: 0xC0
	public static int DETAIL_BUFFER_MERGE_FRAME_LIMIT; //Field offset: 0xC4
	public static readonly string COMPUTE_SET_DATA_PARTIAL_RESOURCE_PATH; //Field offset: 0xC8
	public static readonly string COMPUTE_SET_DATA_PARTIAL_KERNEL; //Field offset: 0xD0
	public static readonly string COMPUTE_SET_DATA_SINGLE_KERNEL; //Field offset: 0xD8
	public static ComputeShader computeBufferSetDataPartial; //Field offset: 0xE0
	public static int computeBufferSetDataPartialKernelId; //Field offset: 0xE8
	public static int computeBufferSetDataSingleKernelId; //Field offset: 0xEC
	public static readonly string COMPUTE_BILLBOARD_RESOURCE_PATH; //Field offset: 0xF0
	public static readonly string COMPUTE_BILLBOARD_DILATION_KERNEL; //Field offset: 0xF8
	public static readonly string COMPUTE_TEXTURE_UTILS_PATH; //Field offset: 0x100
	public static readonly string COMPUTE_COPY_TEXTURE_KERNEL; //Field offset: 0x108
	public static ComputeShader computeTextureUtils; //Field offset: 0x110
	public static int computeTextureUtilsCopyTextureId; //Field offset: 0x118
	public static readonly string GRASS_INSTANTIATION_KERNEL; //Field offset: 0x120
	public static readonly string GRASS_INSTANTIATION_RESOURCE_PATH; //Field offset: 0x128
	public static readonly string TREE_INSTANTIATION_KERNEL; //Field offset: 0x130
	public static readonly string TREE_INSTANTIATION_RESOURCE_PATH; //Field offset: 0x138
	public static readonly string COMPUTE_RUNTIME_MODIFICATION_RESOURCE_PATH; //Field offset: 0x140
	public static readonly string COMPUTE_TRANSFORM_OFFSET_KERNEL; //Field offset: 0x148
	public static readonly string COMPUTE_REMOVE_INSIDE_BOUNDS_KERNEL; //Field offset: 0x150
	public static readonly string COMPUTE_REMOVE_INSIDE_BOX_KERNEL; //Field offset: 0x158
	public static readonly string COMPUTE_REMOVE_INSIDE_SPHERE_KERNEL; //Field offset: 0x160
	public static readonly string COMPUTE_REMOVE_INSIDE_CAPSULE_KERNEL; //Field offset: 0x168
	public static ComputeShader computeRuntimeModification; //Field offset: 0x170
	public static int computeBufferTransformOffsetId; //Field offset: 0x178
	public static int computeRemoveInsideBoundsId; //Field offset: 0x17C
	public static int computeRemoveInsideBoxId; //Field offset: 0x180
	public static int computeRemoveInsideSphereId; //Field offset: 0x184
	public static int computeRemoveInsideCapsuleId; //Field offset: 0x188
	public static readonly string SHADER_UNITY_STANDARD; //Field offset: 0x190
	public static readonly string SHADER_UNITY_STANDARD_SPECULAR; //Field offset: 0x198
	public static readonly string SHADER_UNITY_STANDARD_ROUGHNESS; //Field offset: 0x1A0
	public static readonly string SHADER_UNITY_VERTEXLIT; //Field offset: 0x1A8
	public static readonly string SHADER_UNITY_SPEED_TREE; //Field offset: 0x1B0
	public static readonly string SHADER_UNITY_SPEED_TREE_8; //Field offset: 0x1B8
	public static readonly string SHADER_UNITY_TREE_CREATOR_BARK; //Field offset: 0x1C0
	public static readonly string SHADER_UNITY_TREE_CREATOR_BARK_OPTIMIZED; //Field offset: 0x1C8
	public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES; //Field offset: 0x1D0
	public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_OPTIMIZED; //Field offset: 0x1D8
	public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_FAST; //Field offset: 0x1E0
	public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_FAST_OPTIMIZED; //Field offset: 0x1E8
	public static readonly string SHADER_UNITY_TREE_SOFT_OCCLUSION_BARK; //Field offset: 0x1F0
	public static readonly string SHADER_UNITY_TREE_SOFT_OCCLUSION_LEAVES; //Field offset: 0x1F8
	public static readonly string SHADER_UNITY_INTERNAL_ERROR; //Field offset: 0x200
	public static readonly string SHADER_GPUI_STANDARD; //Field offset: 0x208
	public static readonly string SHADER_GPUI_STANDARD_SPECULAR; //Field offset: 0x210
	public static readonly string SHADER_GPUI_STANDARD_ROUGHNESS; //Field offset: 0x218
	public static readonly string SHADER_GPUI_VERTEXLIT; //Field offset: 0x220
	public static readonly string SHADER_GPUI_FOLIAGE; //Field offset: 0x228
	public static readonly string SHADER_GPUI_FOLIAGE_LWRP; //Field offset: 0x230
	public static readonly string SHADER_GPUI_SHADOWS_ONLY; //Field offset: 0x238
	public static readonly string SHADER_GPUI_HIZ_OCCLUSION_GENERATOR; //Field offset: 0x240
	public static readonly string SHADER_GPUI_HIZ_OCCLUSION_DEBUGGER; //Field offset: 0x248
	public static readonly string SHADER_GPUI_SPEED_TREE; //Field offset: 0x250
	public static readonly string SHADER_GPUI_SPEED_TREE_8; //Field offset: 0x258
	public static readonly string SHADER_GPUI_TREE_PROXY; //Field offset: 0x260
	public static readonly string SHADER_GPUI_TREE_CREATOR_BARK; //Field offset: 0x268
	public static readonly string SHADER_GPUI_TREE_CREATOR_BARK_OPTIMIZED; //Field offset: 0x270
	public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES; //Field offset: 0x278
	public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_OPTIMIZED; //Field offset: 0x280
	public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_FAST; //Field offset: 0x288
	public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_FAST_OPTIMIZED; //Field offset: 0x290
	public static readonly string SHADER_GPUI_TREE_SOFT_OCCLUSION_BARK; //Field offset: 0x298
	public static readonly string SHADER_GPUI_TREE_SOFT_OCCLUSION_LEAVES; //Field offset: 0x2A0
	public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_TREE; //Field offset: 0x2A8
	public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_TREECREATOR; //Field offset: 0x2B0
	public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_SOFTOCCLUSION; //Field offset: 0x2B8
	public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_STANDARD; //Field offset: 0x2C0
	public static readonly string SHADER_GPUI_BILLBOARD_ALBEDO_BAKER; //Field offset: 0x2C8
	public static readonly string SHADER_GPUI_BILLBOARD_NORMAL_BAKER; //Field offset: 0x2D0
	public static readonly string DEFAULT_PATH_GUID; //Field offset: 0x2D8
	public static readonly string RESOURCES_PATH; //Field offset: 0x2E0
	public static readonly string SETTINGS_PATH; //Field offset: 0x2E8
	public static readonly string SHADERS_PATH; //Field offset: 0x2F0
	public static readonly string EDITOR_TEXTURES_PATH; //Field offset: 0x2F8
	public static readonly string NOISE_TEXTURES_PATH; //Field offset: 0x300
	public static readonly string GPUI_SETTINGS_DEFAULT_NAME; //Field offset: 0x308
	public static readonly string SHADER_BINDINGS_DEFAULT_NAME; //Field offset: 0x310
	public static readonly string BILLBOARD_ATLAS_BINDINGS_DEFAULT_NAME; //Field offset: 0x318
	public static readonly string SHADER_VARIANT_COLLECTION_DEFAULT_NAME; //Field offset: 0x320
	public static readonly string PROTOTYPES_TERRAIN_PATH; //Field offset: 0x328
	public static readonly string PROTOTYPES_PREFAB_PATH; //Field offset: 0x330
	public static readonly string PROTOTYPES_BILLBOARD_TEXTURES_PATH; //Field offset: 0x338
	public static readonly string PROTOTYPES_SHADERS_PATH; //Field offset: 0x340
	public static readonly string PROTOTYPES_SERIALIZED_PATH; //Field offset: 0x348
	private static string _defaultPath; //Field offset: 0x350
	public static readonly string DEFAULT_HEALTHY_DRY_NOISE; //Field offset: 0x358
	public static readonly string DEFAULT_WIND_WAVE_NOISE; //Field offset: 0x360
	public static readonly string ERRORTEXT_cameraNotFound; //Field offset: 0x368
	public static readonly int DEBUG_INFO_SIZE; //Field offset: 0x370

	private static GPUInstancerConstants() { }

	public static string GetDefaultPath() { }

	public static void SetupComputeRuntimeModification() { }

	public static void SetupComputeSetDataPartial() { }

	public static void SetupComputeTextureUtils() { }

}

