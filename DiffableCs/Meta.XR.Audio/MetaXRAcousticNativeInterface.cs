//Type is in global namespace

public class MetaXRAcousticNativeInterface
{
	internal class DummyInterface : INativeInterface
	{

		public DummyInterface() { }

		public override int AudioGeometryGetSimplifiedMesh(IntPtr geometry, out float[] vertices, out uint[] indices, out uint[] materialIndices) { }

		public override int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4) { }

		public override int AudioGeometryReadMeshFile(IntPtr geometry, string filePath) { }

		public override int AudioGeometryReadMeshMemory(IntPtr geometry, IntPtr data, ulong dataLength) { }

		public override int AudioGeometrySetObjectFlag(IntPtr geometry, ObjectFlags flag, bool enabled) { }

		public int AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		public override int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount) { }

		public override int AudioGeometryUploadSimplifiedMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount, ref MeshSimplification simplification) { }

		public override int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath) { }

		public override int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath) { }

		public override int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value) { }

		public override int AudioMaterialReset(IntPtr material, MaterialProperty property) { }

		public override int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value) { }

		public override int AudioSceneIRCompute(IntPtr sceneIR, ref MapParameters parameters) { }

		public override int AudioSceneIRComputeCustomPoints(IntPtr sceneIR, float[] points, UIntPtr pointCount, ref MapParameters parameters) { }

		public override int AudioSceneIRGetEnabled(IntPtr sceneIR, out bool enabled) { }

		public override int AudioSceneIRGetPointCount(IntPtr sceneIR, out UIntPtr pointCount) { }

		public override int AudioSceneIRGetPoints(IntPtr sceneIR, float[] points, UIntPtr maxPointCount) { }

		public override int AudioSceneIRGetStatus(IntPtr sceneIR, out AcousticMapStatus status) { }

		public override int AudioSceneIRGetTransform(IntPtr sceneIR, out float[] matrix4x4) { }

		public override int AudioSceneIRReadFile(IntPtr sceneIR, string filePath) { }

		public override int AudioSceneIRReadMemory(IntPtr sceneIR, IntPtr data, ulong dataLength) { }

		public override int AudioSceneIRSetEnabled(IntPtr sceneIR, bool enabled) { }

		public int AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		public override int AudioSceneIRWriteFile(IntPtr sceneIR, string filePath) { }

		public override int ControlZoneGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		public override int ControlZoneGetEnabled(IntPtr control, out bool enabled) { }

		public override int ControlZoneGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		public override int ControlZoneGetTransform(IntPtr control, out float[] matrix4x4) { }

		public override int ControlZoneReset(IntPtr control, ControlZoneProperty property) { }

		public override int ControlZoneSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		public override int ControlZoneSetEnabled(IntPtr control, bool enabled) { }

		public override int ControlZoneSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		public override int ControlZoneSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		public int ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		public override int CreateAudioGeometry(out IntPtr geometry) { }

		public override int CreateAudioMaterial(out IntPtr material) { }

		public override int CreateAudioSceneIR(out IntPtr sceneIR) { }

		public override int CreateControlZone(out IntPtr control) { }

		public override int DestroyAudioGeometry(IntPtr geometry) { }

		public override int DestroyAudioMaterial(IntPtr material) { }

		public override int DestroyAudioSceneIR(IntPtr sceneIR) { }

		public override int DestroyControlZone(IntPtr control) { }

		public override int InitializeAudioSceneIRParameters(out MapParameters parameters) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		public override int ResetReverb() { }

		public override int SetAcousticModel(AcousticModel model) { }

		public override int SetEnabled(int feature, bool enabled) { }

		public override int SetEnabled(EnableFlagInternal feature, bool enabled) { }

	}

	internal class FMODPluginInterface : INativeInterface
	{
		public const string binaryName = "MetaXRAudioFMOD"; //Field offset: 0x0
		private IntPtr context_; //Field offset: 0x10
		private int version; //Field offset: 0x18

		private IntPtr context
		{
			private get { } //Length: 208
		}

		public FMODPluginInterface() { }

		public override int AudioGeometryGetSimplifiedMesh(IntPtr geometry, out float[] vertices, out uint[] indices, out uint[] materialIndices) { }

		public override int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4) { }

		public override int AudioGeometryReadMeshFile(IntPtr geometry, string filePath) { }

		public override int AudioGeometryReadMeshMemory(IntPtr geometry, IntPtr data, ulong dataLength) { }

		public override int AudioGeometrySetObjectFlag(IntPtr geometry, ObjectFlags flag, bool enabled) { }

		public int AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		public override int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount) { }

		public override int AudioGeometryUploadSimplifiedMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount, ref MeshSimplification simplification) { }

		public override int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath) { }

		public override int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath) { }

		public override int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value) { }

		public override int AudioMaterialReset(IntPtr material, MaterialProperty property) { }

		public override int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value) { }

		public override int AudioSceneIRCompute(IntPtr sceneIR, ref MapParameters parameters) { }

		public override int AudioSceneIRComputeCustomPoints(IntPtr sceneIR, float[] points, UIntPtr pointCount, ref MapParameters parameters) { }

		public override int AudioSceneIRGetEnabled(IntPtr sceneIR, out bool enabled) { }

		public override int AudioSceneIRGetPointCount(IntPtr sceneIR, out UIntPtr pointCount) { }

		public override int AudioSceneIRGetPoints(IntPtr sceneIR, float[] points, UIntPtr maxPointCount) { }

		public override int AudioSceneIRGetStatus(IntPtr sceneIR, out AcousticMapStatus status) { }

		public override int AudioSceneIRGetTransform(IntPtr sceneIR, out float[] matrix4x4) { }

		public override int AudioSceneIRReadFile(IntPtr sceneIR, string filePath) { }

		public override int AudioSceneIRReadMemory(IntPtr sceneIR, IntPtr data, ulong dataLength) { }

		public override int AudioSceneIRSetEnabled(IntPtr sceneIR, bool enabled) { }

		public int AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		public override int AudioSceneIRWriteFile(IntPtr sceneIR, string filePath) { }

		public override int ControlZoneGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		public override int ControlZoneGetEnabled(IntPtr control, out bool enabled) { }

		public override int ControlZoneGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		public override int ControlZoneGetTransform(IntPtr control, out float[] matrix4x4) { }

		public override int ControlZoneReset(IntPtr control, ControlZoneProperty property) { }

		public override int ControlZoneSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		public override int ControlZoneSetEnabled(IntPtr control, bool enabled) { }

		public override int ControlZoneSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		public override int ControlZoneSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		public int ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		public override int CreateAudioGeometry(out IntPtr geometry) { }

		public override int CreateAudioMaterial(out IntPtr material) { }

		public override int CreateAudioSceneIR(out IntPtr sceneIR) { }

		public override int CreateControlZone(out IntPtr control) { }

		public override int DestroyAudioGeometry(IntPtr geometry) { }

		public override int DestroyAudioMaterial(IntPtr material) { }

		public override int DestroyAudioSceneIR(IntPtr sceneIR) { }

		public override int DestroyControlZone(IntPtr control) { }

		private IntPtr get_context() { }

		public override int InitializeAudioSceneIRParameters(out MapParameters parameters) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		private static int ovrAudio_AudioGeometryGetSimplifiedMeshWithMaterials(IntPtr geometry, IntPtr unused1, out uint numVertices, IntPtr unused2, IntPtr unused3, out uint numTriangles) { }

		private static int ovrAudio_AudioGeometryGetSimplifiedMeshWithMaterials(IntPtr geometry, float[] vertices, ref uint numVertices, uint[] indices, uint[] materialIndices, ref uint numTriangles) { }

		private static int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4) { }

		private static int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioGeometryReadMeshMemory(IntPtr geometry, IntPtr data, ulong dataLength) { }

		private static int ovrAudio_AudioGeometrySetObjectFlag(IntPtr geometry, ObjectFlags flag, int enabled) { }

		private static int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float* matrix4x4) { }

		private static int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount) { }

		private static int ovrAudio_AudioGeometryUploadSimplifiedMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount, ref MeshSimplification simplification) { }

		private static int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value) { }

		private static int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property) { }

		private static int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value) { }

		private static int ovrAudio_AudioSceneIRCompute(IntPtr sceneIR, ref MapParameters parameters) { }

		private static int ovrAudio_AudioSceneIRComputeCustomPoints(IntPtr sceneIR, float[] points, UIntPtr pointCount, ref MapParameters parameters) { }

		private static int ovrAudio_AudioSceneIRGetEnabled(IntPtr sceneIR, out int enabled) { }

		private static int ovrAudio_AudioSceneIRGetPointCount(IntPtr sceneIR, out UIntPtr pointCount) { }

		private static int ovrAudio_AudioSceneIRGetPoints(IntPtr sceneIR, float[] points, UIntPtr maxPointCount) { }

		private static int ovrAudio_AudioSceneIRGetStatus(IntPtr sceneIR, out AcousticMapStatus status) { }

		private static int ovrAudio_AudioSceneIRGetTransform(IntPtr sceneIR, out float[] matrix4x4) { }

		private static int ovrAudio_AudioSceneIRReadFile(IntPtr sceneIR, string filePath) { }

		private static int ovrAudio_AudioSceneIRReadMemory(IntPtr sceneIR, IntPtr data, ulong dataLength) { }

		private static int ovrAudio_AudioSceneIRSetEnabled(IntPtr sceneIR, int enabled) { }

		private static int ovrAudio_AudioSceneIRSetTransform(IntPtr sceneIR, float* matrix4x4) { }

		private static int ovrAudio_AudioSceneIRWriteFile(IntPtr sceneIR, string filePath) { }

		private static int ovrAudio_ControlVolumeGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		private static int ovrAudio_ControlVolumeGetEnabled(IntPtr control, out int enabled) { }

		private static int ovrAudio_ControlVolumeGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		private static int ovrAudio_ControlVolumeGetTransform(IntPtr control, out float[] matrix4x4) { }

		private static int ovrAudio_ControlVolumeReset(IntPtr control, ControlZoneProperty property) { }

		private static int ovrAudio_ControlVolumeSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		private static int ovrAudio_ControlVolumeSetEnabled(IntPtr control, int enabled) { }

		private static int ovrAudio_ControlVolumeSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		private static int ovrAudio_ControlVolumeSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		private static int ovrAudio_ControlVolumeSetTransform(IntPtr control, float* matrix4x4) { }

		private static int ovrAudio_ControlZoneGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		private static int ovrAudio_ControlZoneGetEnabled(IntPtr control, out int enabled) { }

		private static int ovrAudio_ControlZoneGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		private static int ovrAudio_ControlZoneGetTransform(IntPtr control, out float[] matrix4x4) { }

		private static int ovrAudio_ControlZoneReset(IntPtr control, ControlZoneProperty property) { }

		private static int ovrAudio_ControlZoneSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		private static int ovrAudio_ControlZoneSetEnabled(IntPtr control, int enabled) { }

		private static int ovrAudio_ControlZoneSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		private static int ovrAudio_ControlZoneSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		private static int ovrAudio_ControlZoneSetTransform(IntPtr control, float* matrix4x4) { }

		private static int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry) { }

		private static int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material) { }

		private static int ovrAudio_CreateAudioSceneIR(IntPtr context, out IntPtr sceneIR) { }

		private static int ovrAudio_CreateControlVolume(IntPtr context, out IntPtr control) { }

		private static int ovrAudio_CreateControlZone(IntPtr context, out IntPtr control) { }

		private static int ovrAudio_DestroyAudioGeometry(IntPtr geometry) { }

		private static int ovrAudio_DestroyAudioMaterial(IntPtr material) { }

		private static int ovrAudio_DestroyAudioSceneIR(IntPtr sceneIR) { }

		private static int ovrAudio_DestroyControlVolume(IntPtr control) { }

		private static int ovrAudio_DestroyControlZone(IntPtr control) { }

		private static int ovrAudio_Enable(IntPtr context, int what, int enable) { }

		private static int ovrAudio_Enable(IntPtr context, EnableFlagInternal what, int enable) { }

		public static int ovrAudio_GetPluginContext(out IntPtr context) { }

		public static IntPtr ovrAudio_GetVersion(out int Major, out int Minor, out int Patch) { }

		private static int ovrAudio_InitializeAudioSceneIRParameters(out MapParameters parameters) { }

		private static int ovrAudio_ResetSharedReverb(IntPtr context) { }

		private static int ovrAudio_SetAcousticModel(IntPtr context, AcousticModel quality) { }

		public override int ResetReverb() { }

		public override int SetAcousticModel(AcousticModel model) { }

		public override int SetEnabled(EnableFlagInternal feature, bool enabled) { }

		public override int SetEnabled(int feature, bool enabled) { }

	}

	internal interface INativeInterface
	{

		public int AudioGeometryGetSimplifiedMesh(IntPtr geometry, out float[] vertices, out uint[] indices, out uint[] materialIndices) { }

		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4) { }

		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath) { }

		public int AudioGeometryReadMeshMemory(IntPtr geometry, IntPtr data, ulong dataLength) { }

		public int AudioGeometrySetObjectFlag(IntPtr geometry, ObjectFlags flag, bool enabled) { }

		public int AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount) { }

		public int AudioGeometryUploadSimplifiedMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount, ref MeshSimplification simplification) { }

		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath) { }

		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath) { }

		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value) { }

		public int AudioMaterialReset(IntPtr material, MaterialProperty property) { }

		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value) { }

		public int AudioSceneIRCompute(IntPtr sceneIR, ref MapParameters parameters) { }

		public int AudioSceneIRComputeCustomPoints(IntPtr sceneIR, float[] points, UIntPtr pointCount, ref MapParameters parameters) { }

		public int AudioSceneIRGetEnabled(IntPtr sceneIR, out bool enabled) { }

		public int AudioSceneIRGetPointCount(IntPtr sceneIR, out UIntPtr pointCount) { }

		public int AudioSceneIRGetPoints(IntPtr sceneIR, float[] points, UIntPtr maxPointCount) { }

		public int AudioSceneIRGetStatus(IntPtr sceneIR, out AcousticMapStatus status) { }

		public int AudioSceneIRGetTransform(IntPtr sceneIR, out float[] matrix4x4) { }

		public int AudioSceneIRReadFile(IntPtr sceneIR, string filePath) { }

		public int AudioSceneIRReadMemory(IntPtr sceneIR, IntPtr data, ulong dataLength) { }

		public int AudioSceneIRSetEnabled(IntPtr sceneIR, bool enabled) { }

		public int AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		public int AudioSceneIRWriteFile(IntPtr sceneIR, string filePath) { }

		public int ControlZoneGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		public int ControlZoneGetEnabled(IntPtr control, out bool enabled) { }

		public int ControlZoneGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		public int ControlZoneGetTransform(IntPtr control, out float[] matrix4x4) { }

		public int ControlZoneReset(IntPtr control, ControlZoneProperty property) { }

		public int ControlZoneSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		public int ControlZoneSetEnabled(IntPtr control, bool enabled) { }

		public int ControlZoneSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		public int ControlZoneSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		public int ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		public int CreateAudioGeometry(out IntPtr geometry) { }

		public int CreateAudioMaterial(out IntPtr material) { }

		public int CreateAudioSceneIR(out IntPtr sceneIR) { }

		public int CreateControlZone(out IntPtr control) { }

		public int DestroyAudioGeometry(IntPtr geometry) { }

		public int DestroyAudioMaterial(IntPtr material) { }

		public int DestroyAudioSceneIR(IntPtr sceneIR) { }

		public int DestroyControlZone(IntPtr control) { }

		public int InitializeAudioSceneIRParameters(out MapParameters parameters) { }

		public int ResetReverb() { }

		public int SetAcousticModel(AcousticModel model) { }

		public int SetEnabled(EnableFlagInternal feature, bool enabled) { }

		public int SetEnabled(int feature, bool enabled) { }

	}

	internal enum ovrAudioScalarType
	{
		Int8 = 0,
		UInt8 = 1,
		Int16 = 2,
		UInt16 = 3,
		Int32 = 4,
		UInt32 = 5,
		Int64 = 6,
		UInt64 = 7,
		Float16 = 8,
		Float32 = 9,
		Float64 = 10,
	}

	internal class UnityNativeInterface : INativeInterface
	{
		public const string binaryName = "MetaXRAudioUnity"; //Field offset: 0x0
		private IntPtr context_; //Field offset: 0x10
		private int version; //Field offset: 0x18

		private IntPtr context
		{
			private get { } //Length: 208
		}

		public UnityNativeInterface() { }

		public override int AudioGeometryGetSimplifiedMesh(IntPtr geometry, out float[] vertices, out uint[] indices, out uint[] materialIndices) { }

		public override int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4) { }

		public override int AudioGeometryReadMeshFile(IntPtr geometry, string filePath) { }

		public override int AudioGeometryReadMeshMemory(IntPtr geometry, IntPtr data, ulong dataLength) { }

		public override int AudioGeometrySetObjectFlag(IntPtr geometry, ObjectFlags flag, bool enabled) { }

		public int AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		public override int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount) { }

		public override int AudioGeometryUploadSimplifiedMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount, ref MeshSimplification simplification) { }

		public override int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath) { }

		public override int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath) { }

		public override int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value) { }

		public override int AudioMaterialReset(IntPtr material, MaterialProperty property) { }

		public override int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value) { }

		public override int AudioSceneIRCompute(IntPtr sceneIR, ref MapParameters parameters) { }

		public override int AudioSceneIRComputeCustomPoints(IntPtr sceneIR, float[] points, UIntPtr pointCount, ref MapParameters parameters) { }

		public override int AudioSceneIRGetEnabled(IntPtr sceneIR, out bool enabled) { }

		public override int AudioSceneIRGetPointCount(IntPtr sceneIR, out UIntPtr pointCount) { }

		public override int AudioSceneIRGetPoints(IntPtr sceneIR, float[] points, UIntPtr maxPointCount) { }

		public override int AudioSceneIRGetStatus(IntPtr sceneIR, out AcousticMapStatus status) { }

		public override int AudioSceneIRGetTransform(IntPtr sceneIR, out float[] matrix4x4) { }

		public override int AudioSceneIRReadFile(IntPtr sceneIR, string filePath) { }

		public override int AudioSceneIRReadMemory(IntPtr sceneIR, IntPtr data, ulong dataLength) { }

		public override int AudioSceneIRSetEnabled(IntPtr sceneIR, bool enabled) { }

		public int AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		public override int AudioSceneIRWriteFile(IntPtr sceneIR, string filePath) { }

		public override int ControlZoneGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		public override int ControlZoneGetEnabled(IntPtr control, out bool enabled) { }

		public override int ControlZoneGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		public override int ControlZoneGetTransform(IntPtr control, out float[] matrix4x4) { }

		public override int ControlZoneReset(IntPtr control, ControlZoneProperty property) { }

		public override int ControlZoneSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		public override int ControlZoneSetEnabled(IntPtr control, bool enabled) { }

		public override int ControlZoneSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		public override int ControlZoneSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		public int ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		public override int CreateAudioGeometry(out IntPtr geometry) { }

		public override int CreateAudioMaterial(out IntPtr material) { }

		public override int CreateAudioSceneIR(out IntPtr sceneIR) { }

		public override int CreateControlZone(out IntPtr control) { }

		public override int DestroyAudioGeometry(IntPtr geometry) { }

		public override int DestroyAudioMaterial(IntPtr material) { }

		public override int DestroyAudioSceneIR(IntPtr sceneIR) { }

		public override int DestroyControlZone(IntPtr control) { }

		private IntPtr get_context() { }

		public override int InitializeAudioSceneIRParameters(out MapParameters parameters) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		private static int ovrAudio_AudioGeometryGetSimplifiedMeshWithMaterials(IntPtr geometry, IntPtr unused1, out uint numVertices, IntPtr unused2, IntPtr unused3, out uint numTriangles) { }

		private static int ovrAudio_AudioGeometryGetSimplifiedMeshWithMaterials(IntPtr geometry, float[] vertices, ref uint numVertices, uint[] indices, uint[] materialIndices, ref uint numTriangles) { }

		private static int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4) { }

		private static int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioGeometryReadMeshMemory(IntPtr geometry, IntPtr data, ulong dataLength) { }

		private static int ovrAudio_AudioGeometrySetObjectFlag(IntPtr geometry, ObjectFlags flag, int enabled) { }

		private static int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float* matrix4x4) { }

		private static int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount) { }

		private static int ovrAudio_AudioGeometryUploadSimplifiedMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount, ref MeshSimplification simplification) { }

		private static int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value) { }

		private static int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property) { }

		private static int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value) { }

		private static int ovrAudio_AudioSceneIRCompute(IntPtr sceneIR, ref MapParameters parameters) { }

		private static int ovrAudio_AudioSceneIRComputeCustomPoints(IntPtr sceneIR, float[] points, UIntPtr pointCount, ref MapParameters parameters) { }

		private static int ovrAudio_AudioSceneIRGetEnabled(IntPtr sceneIR, out int enabled) { }

		private static int ovrAudio_AudioSceneIRGetPointCount(IntPtr sceneIR, out UIntPtr pointCount) { }

		private static int ovrAudio_AudioSceneIRGetPoints(IntPtr sceneIR, float[] points, UIntPtr maxPointCount) { }

		private static int ovrAudio_AudioSceneIRGetStatus(IntPtr sceneIR, out AcousticMapStatus status) { }

		private static int ovrAudio_AudioSceneIRGetTransform(IntPtr sceneIR, out float[] matrix4x4) { }

		private static int ovrAudio_AudioSceneIRReadFile(IntPtr sceneIR, string filePath) { }

		private static int ovrAudio_AudioSceneIRReadMemory(IntPtr sceneIR, IntPtr data, ulong dataLength) { }

		private static int ovrAudio_AudioSceneIRSetEnabled(IntPtr sceneIR, int enabled) { }

		private static int ovrAudio_AudioSceneIRSetTransform(IntPtr sceneIR, float* matrix4x4) { }

		private static int ovrAudio_AudioSceneIRWriteFile(IntPtr sceneIR, string filePath) { }

		private static int ovrAudio_ControlVolumeGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		private static int ovrAudio_ControlVolumeGetEnabled(IntPtr control, out int enabled) { }

		private static int ovrAudio_ControlVolumeGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		private static int ovrAudio_ControlVolumeGetTransform(IntPtr control, out float[] matrix4x4) { }

		private static int ovrAudio_ControlVolumeReset(IntPtr control, ControlZoneProperty property) { }

		private static int ovrAudio_ControlVolumeSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		private static int ovrAudio_ControlVolumeSetEnabled(IntPtr control, int enabled) { }

		private static int ovrAudio_ControlVolumeSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		private static int ovrAudio_ControlVolumeSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		private static int ovrAudio_ControlVolumeSetTransform(IntPtr control, float* matrix4x4) { }

		private static int ovrAudio_ControlZoneGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		private static int ovrAudio_ControlZoneGetEnabled(IntPtr control, out int enabled) { }

		private static int ovrAudio_ControlZoneGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		private static int ovrAudio_ControlZoneGetTransform(IntPtr control, out float[] matrix4x4) { }

		private static int ovrAudio_ControlZoneReset(IntPtr control, ControlZoneProperty property) { }

		private static int ovrAudio_ControlZoneSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		private static int ovrAudio_ControlZoneSetEnabled(IntPtr control, int enabled) { }

		private static int ovrAudio_ControlZoneSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		private static int ovrAudio_ControlZoneSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		private static int ovrAudio_ControlZoneSetTransform(IntPtr control, float* matrix4x4) { }

		private static int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry) { }

		private static int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material) { }

		private static int ovrAudio_CreateAudioSceneIR(IntPtr context, out IntPtr sceneIR) { }

		private static int ovrAudio_CreateControlVolume(IntPtr context, out IntPtr control) { }

		private static int ovrAudio_CreateControlZone(IntPtr context, out IntPtr control) { }

		private static int ovrAudio_DestroyAudioGeometry(IntPtr geometry) { }

		private static int ovrAudio_DestroyAudioMaterial(IntPtr material) { }

		private static int ovrAudio_DestroyAudioSceneIR(IntPtr sceneIR) { }

		private static int ovrAudio_DestroyControlVolume(IntPtr control) { }

		private static int ovrAudio_DestroyControlZone(IntPtr control) { }

		private static int ovrAudio_Enable(IntPtr context, int what, int enable) { }

		private static int ovrAudio_Enable(IntPtr context, EnableFlagInternal what, int enable) { }

		public static int ovrAudio_GetPluginContext(out IntPtr context) { }

		public static IntPtr ovrAudio_GetVersion(out int Major, out int Minor, out int Patch) { }

		private static int ovrAudio_InitializeAudioSceneIRParameters(out MapParameters parameters) { }

		private static int ovrAudio_ResetSharedReverb(IntPtr context) { }

		private static int ovrAudio_SetAcousticModel(IntPtr context, AcousticModel quality) { }

		public override int ResetReverb() { }

		public override int SetAcousticModel(AcousticModel model) { }

		public override int SetEnabled(EnableFlagInternal feature, bool enabled) { }

		public override int SetEnabled(int feature, bool enabled) { }

	}

	internal class WwisePluginInterface : INativeInterface
	{
		public const string binaryName = "MetaXRAudioWwise"; //Field offset: 0x0
		private IntPtr context_; //Field offset: 0x10
		private int version; //Field offset: 0x18

		private IntPtr context
		{
			private get { } //Length: 208
		}

		public WwisePluginInterface() { }

		public override int AudioGeometryGetSimplifiedMesh(IntPtr geometry, out float[] vertices, out uint[] indices, out uint[] materialIndices) { }

		public override int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4) { }

		public override int AudioGeometryReadMeshFile(IntPtr geometry, string filePath) { }

		public override int AudioGeometryReadMeshMemory(IntPtr geometry, IntPtr data, ulong dataLength) { }

		public override int AudioGeometrySetObjectFlag(IntPtr geometry, ObjectFlags flag, bool enabled) { }

		public int AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		public override int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount) { }

		public override int AudioGeometryUploadSimplifiedMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount, ref MeshSimplification simplification) { }

		public override int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath) { }

		public override int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath) { }

		public override int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value) { }

		public override int AudioMaterialReset(IntPtr material, MaterialProperty property) { }

		public override int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value) { }

		public override int AudioSceneIRCompute(IntPtr sceneIR, ref MapParameters parameters) { }

		public override int AudioSceneIRComputeCustomPoints(IntPtr sceneIR, float[] points, UIntPtr pointCount, ref MapParameters parameters) { }

		public override int AudioSceneIRGetEnabled(IntPtr sceneIR, out bool enabled) { }

		public override int AudioSceneIRGetPointCount(IntPtr sceneIR, out UIntPtr pointCount) { }

		public override int AudioSceneIRGetPoints(IntPtr sceneIR, float[] points, UIntPtr maxPointCount) { }

		public override int AudioSceneIRGetStatus(IntPtr sceneIR, out AcousticMapStatus status) { }

		public override int AudioSceneIRGetTransform(IntPtr sceneIR, out float[] matrix4x4) { }

		public override int AudioSceneIRReadFile(IntPtr sceneIR, string filePath) { }

		public override int AudioSceneIRReadMemory(IntPtr sceneIR, IntPtr data, ulong dataLength) { }

		public override int AudioSceneIRSetEnabled(IntPtr sceneIR, bool enabled) { }

		public int AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		public override int AudioSceneIRWriteFile(IntPtr sceneIR, string filePath) { }

		public override int ControlZoneGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		public override int ControlZoneGetEnabled(IntPtr control, out bool enabled) { }

		public override int ControlZoneGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		public override int ControlZoneGetTransform(IntPtr control, out float[] matrix4x4) { }

		public override int ControlZoneReset(IntPtr control, ControlZoneProperty property) { }

		public override int ControlZoneSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		public override int ControlZoneSetEnabled(IntPtr control, bool enabled) { }

		public override int ControlZoneSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		public override int ControlZoneSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		public int ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		public override int CreateAudioGeometry(out IntPtr geometry) { }

		public override int CreateAudioMaterial(out IntPtr material) { }

		public override int CreateAudioSceneIR(out IntPtr sceneIR) { }

		public override int CreateControlZone(out IntPtr control) { }

		public override int DestroyAudioGeometry(IntPtr geometry) { }

		public override int DestroyAudioMaterial(IntPtr material) { }

		public override int DestroyAudioSceneIR(IntPtr sceneIR) { }

		public override int DestroyControlZone(IntPtr control) { }

		private IntPtr get_context() { }

		public static IntPtr getOrCreateGlobalOvrAudioContext() { }

		public override int InitializeAudioSceneIRParameters(out MapParameters parameters) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.AudioGeometrySetTransform(IntPtr geometry, in Matrix4x4 matrix) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.AudioSceneIRSetTransform(IntPtr sceneIR, in Matrix4x4 matrix) { }

		private override int MetaXRAcousticNativeInterface.INativeInterface.ControlZoneSetTransform(IntPtr control, in Matrix4x4 matrix) { }

		private static int ovrAudio_AudioGeometryGetSimplifiedMeshWithMaterials(IntPtr geometry, IntPtr unused1, out uint numVertices, IntPtr unused2, IntPtr unused3, out uint numTriangles) { }

		private static int ovrAudio_AudioGeometryGetSimplifiedMeshWithMaterials(IntPtr geometry, float[] vertices, ref uint numVertices, uint[] indices, uint[] materialIndices, ref uint numTriangles) { }

		private static int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4) { }

		private static int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioGeometryReadMeshMemory(IntPtr geometry, IntPtr data, ulong dataLength) { }

		private static int ovrAudio_AudioGeometrySetObjectFlag(IntPtr geometry, ObjectFlags flag, int enabled) { }

		private static int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float* matrix4x4) { }

		private static int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount) { }

		private static int ovrAudio_AudioGeometryUploadSimplifiedMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount, ref MeshSimplification simplification) { }

		private static int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath) { }

		private static int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value) { }

		private static int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property) { }

		private static int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value) { }

		private static int ovrAudio_AudioSceneIRCompute(IntPtr sceneIR, ref MapParameters parameters) { }

		private static int ovrAudio_AudioSceneIRComputeCustomPoints(IntPtr sceneIR, float[] points, UIntPtr pointCount, ref MapParameters parameters) { }

		private static int ovrAudio_AudioSceneIRGetEnabled(IntPtr sceneIR, out int enabled) { }

		private static int ovrAudio_AudioSceneIRGetPointCount(IntPtr sceneIR, out UIntPtr pointCount) { }

		private static int ovrAudio_AudioSceneIRGetPoints(IntPtr sceneIR, float[] points, UIntPtr maxPointCount) { }

		private static int ovrAudio_AudioSceneIRGetStatus(IntPtr sceneIR, out AcousticMapStatus status) { }

		private static int ovrAudio_AudioSceneIRGetTransform(IntPtr sceneIR, out float[] matrix4x4) { }

		private static int ovrAudio_AudioSceneIRReadFile(IntPtr sceneIR, string filePath) { }

		private static int ovrAudio_AudioSceneIRReadMemory(IntPtr sceneIR, IntPtr data, ulong dataLength) { }

		private static int ovrAudio_AudioSceneIRSetEnabled(IntPtr sceneIR, int enabled) { }

		private static int ovrAudio_AudioSceneIRSetTransform(IntPtr sceneIR, float* matrix4x4) { }

		private static int ovrAudio_AudioSceneIRWriteFile(IntPtr sceneIR, string filePath) { }

		private static int ovrAudio_ControlVolumeGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		private static int ovrAudio_ControlVolumeGetEnabled(IntPtr control, out int enabled) { }

		private static int ovrAudio_ControlVolumeGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		private static int ovrAudio_ControlVolumeGetTransform(IntPtr control, out float[] matrix4x4) { }

		private static int ovrAudio_ControlVolumeReset(IntPtr control, ControlZoneProperty property) { }

		private static int ovrAudio_ControlVolumeSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		private static int ovrAudio_ControlVolumeSetEnabled(IntPtr control, int enabled) { }

		private static int ovrAudio_ControlVolumeSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		private static int ovrAudio_ControlVolumeSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		private static int ovrAudio_ControlVolumeSetTransform(IntPtr control, float* matrix4x4) { }

		private static int ovrAudio_ControlZoneGetBox(IntPtr control, out float sizeX, out float sizeY, out float sizeZ) { }

		private static int ovrAudio_ControlZoneGetEnabled(IntPtr control, out int enabled) { }

		private static int ovrAudio_ControlZoneGetFadeDistance(IntPtr control, out float fadeX, out float fadeY, out float fadeZ) { }

		private static int ovrAudio_ControlZoneGetTransform(IntPtr control, out float[] matrix4x4) { }

		private static int ovrAudio_ControlZoneReset(IntPtr control, ControlZoneProperty property) { }

		private static int ovrAudio_ControlZoneSetBox(IntPtr control, float sizeX, float sizeY, float sizeZ) { }

		private static int ovrAudio_ControlZoneSetEnabled(IntPtr control, int enabled) { }

		private static int ovrAudio_ControlZoneSetFadeDistance(IntPtr control, float fadeX, float fadeY, float fadeZ) { }

		private static int ovrAudio_ControlZoneSetFrequency(IntPtr control, ControlZoneProperty property, float frequency, float value) { }

		private static int ovrAudio_ControlZoneSetTransform(IntPtr control, float* matrix4x4) { }

		private static int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry) { }

		private static int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material) { }

		private static int ovrAudio_CreateAudioSceneIR(IntPtr context, out IntPtr sceneIR) { }

		private static int ovrAudio_CreateControlVolume(IntPtr context, out IntPtr control) { }

		private static int ovrAudio_CreateControlZone(IntPtr context, out IntPtr control) { }

		private static int ovrAudio_DestroyAudioGeometry(IntPtr geometry) { }

		private static int ovrAudio_DestroyAudioMaterial(IntPtr material) { }

		private static int ovrAudio_DestroyAudioSceneIR(IntPtr sceneIR) { }

		private static int ovrAudio_DestroyControlVolume(IntPtr control) { }

		private static int ovrAudio_DestroyControlZone(IntPtr control) { }

		private static int ovrAudio_Enable(IntPtr context, int what, int enable) { }

		private static int ovrAudio_Enable(IntPtr context, EnableFlagInternal what, int enable) { }

		public static IntPtr ovrAudio_GetVersion(out int Major, out int Minor, out int Patch) { }

		private static int ovrAudio_InitializeAudioSceneIRParameters(out MapParameters parameters) { }

		private static int ovrAudio_ResetSharedReverb(IntPtr context) { }

		private static int ovrAudio_SetAcousticModel(IntPtr context, AcousticModel quality) { }

		public override int ResetReverb() { }

		public override int SetAcousticModel(AcousticModel model) { }

		public override int SetEnabled(int feature, bool enabled) { }

		public override int SetEnabled(EnableFlagInternal feature, bool enabled) { }

	}

	private static INativeInterface CachedInterface; //Field offset: 0x0

	public static INativeInterface Interface
	{
		 get { } //Length: 183
	}

	public MetaXRAcousticNativeInterface() { }

	private static INativeInterface FindInterface() { }

	public static INativeInterface get_Interface() { }

}

