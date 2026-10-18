//Type is in global namespace

public class MetaXRAudioNativeInterface
{
	internal class FMODPluginInterface : NativeInterface
	{
		public const string binaryName = "MetaXRAudioFMOD"; //Field offset: 0x0
		private IntPtr context_; //Field offset: 0x10

		private IntPtr context
		{
			private get { } //Length: 66
		}

		public FMODPluginInterface() { }

		private IntPtr get_context() { }

		public override int GetRaycastHits(Vector3[] points, Vector3[] normals, int length) { }

		public override int GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position) { }

		private static int ovrAudio_Enable(IntPtr context, int what, int enable) { }

		private static int ovrAudio_Enable(IntPtr context, EnableFlag what, int enable) { }

		public static int ovrAudio_GetPluginContext(out IntPtr context) { }

		private static int ovrAudio_GetRaycastHits(IntPtr context, Vector3[] points, Vector3[] normals, int length) { }

		private static int ovrAudio_GetRoomDimensions(IntPtr context, float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position) { }

		private static int ovrAudio_SetAdvancedBoxRoomParametersUnity(IntPtr context, float width, float height, float depth, bool lockToListenerPosition, float positionX, float positionY, float positionZ, float[] wallMaterials) { }

		private static int ovrAudio_SetDynamicRoomInterpSpeed(IntPtr context, float InterpSpeed) { }

		private static int ovrAudio_SetDynamicRoomMaxWallDistance(IntPtr context, float MaxWallDistance) { }

		private static int ovrAudio_SetDynamicRoomRaysPerSecond(IntPtr context, int RaysPerSecond) { }

		private static int ovrAudio_SetDynamicRoomRaysRayCacheSize(IntPtr context, int RayCacheSize) { }

		private static int ovrAudio_SetRoomClutterFactor(IntPtr context, float[] clutterFactor) { }

		private static int ovrAudio_SetSharedReverbWetLevel(IntPtr context, float linearLevel) { }

		public override int SetAdvancedBoxRoomParameters(float width, float height, float depth, bool lockToListenerPosition, Vector3 position, float[] wallMaterials) { }

		public override int SetDynamicRoomInterpSpeed(float InterpSpeed) { }

		public override int SetDynamicRoomMaxWallDistance(float MaxWallDistance) { }

		public override int SetDynamicRoomRaysPerSecond(int RaysPerSecond) { }

		public override int SetDynamicRoomRaysRayCacheSize(int RayCacheSize) { }

		public override int SetEnabled(int feature, bool enabled) { }

		public int SetEnabled(EnableFlag feature, bool enabled) { }

		public override int SetRoomClutterFactor(float[] clutterFactor) { }

		public override int SetSharedReverbWetLevel(float linearLevel) { }

	}

	internal interface NativeInterface
	{

		public int GetRaycastHits(Vector3[] points, Vector3[] normals, int length) { }

		public int GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position) { }

		public int SetAdvancedBoxRoomParameters(float width, float height, float depth, bool lockToListenerPosition, Vector3 position, float[] wallMaterials) { }

		public int SetDynamicRoomInterpSpeed(float InterpSpeed) { }

		public int SetDynamicRoomMaxWallDistance(float MaxWallDistance) { }

		public int SetDynamicRoomRaysPerSecond(int RaysPerSecond) { }

		public int SetDynamicRoomRaysRayCacheSize(int RayCacheSize) { }

		public int SetEnabled(int feature, bool enabled) { }

		public int SetRoomClutterFactor(float[] clutterFactor) { }

		public int SetSharedReverbWetLevel(float linearLevel) { }

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

	[Obfuscation(Exclude = True)]
	internal class UnityNativeInterface : NativeInterface
	{
		public const string binaryName = "MetaXRAudioUnity"; //Field offset: 0x0
		private IntPtr context_; //Field offset: 0x10

		private IntPtr context
		{
			private get { } //Length: 66
		}

		public UnityNativeInterface() { }

		private IntPtr get_context() { }

		public override int GetRaycastHits(Vector3[] points, Vector3[] normals, int length) { }

		public override int GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position) { }

		private static int ovrAudio_Enable(IntPtr context, int what, int enable) { }

		private static int ovrAudio_Enable(IntPtr context, EnableFlag what, int enable) { }

		public static int ovrAudio_GetPluginContext(out IntPtr context) { }

		private static int ovrAudio_GetRaycastHits(IntPtr context, Vector3[] points, Vector3[] normals, int length) { }

		private static int ovrAudio_GetRoomDimensions(IntPtr context, float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position) { }

		private static int ovrAudio_SetAdvancedBoxRoomParametersUnity(IntPtr context, float width, float height, float depth, bool lockToListenerPosition, float positionX, float positionY, float positionZ, float[] wallMaterials) { }

		private static int ovrAudio_SetDynamicRoomInterpSpeed(IntPtr context, float InterpSpeed) { }

		private static int ovrAudio_SetDynamicRoomMaxWallDistance(IntPtr context, float MaxWallDistance) { }

		private static int ovrAudio_SetDynamicRoomRaysPerSecond(IntPtr context, int RaysPerSecond) { }

		private static int ovrAudio_SetDynamicRoomRaysRayCacheSize(IntPtr context, int RayCacheSize) { }

		private static int ovrAudio_SetRoomClutterFactor(IntPtr context, float[] clutterFactor) { }

		private static int ovrAudio_SetSharedReverbWetLevel(IntPtr context, float linearLevel) { }

		public override int SetAdvancedBoxRoomParameters(float width, float height, float depth, bool lockToListenerPosition, Vector3 position, float[] wallMaterials) { }

		public override int SetDynamicRoomInterpSpeed(float InterpSpeed) { }

		public override int SetDynamicRoomMaxWallDistance(float MaxWallDistance) { }

		public override int SetDynamicRoomRaysPerSecond(int RaysPerSecond) { }

		public override int SetDynamicRoomRaysRayCacheSize(int RayCacheSize) { }

		public override int SetEnabled(int feature, bool enabled) { }

		public int SetEnabled(EnableFlag feature, bool enabled) { }

		public override int SetRoomClutterFactor(float[] clutterFactor) { }

		public override int SetSharedReverbWetLevel(float linearLevel) { }

	}

	internal class WwisePluginInterface : NativeInterface
	{
		public const string binaryName = "MetaXRAudioWwise"; //Field offset: 0x0
		private IntPtr context_; //Field offset: 0x10

		private IntPtr context
		{
			private get { } //Length: 62
		}

		public WwisePluginInterface() { }

		private IntPtr get_context() { }

		public static IntPtr getOrCreateGlobalOvrAudioContext() { }

		public override int GetRaycastHits(Vector3[] points, Vector3[] normals, int length) { }

		public override int GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position) { }

		private static int ovrAudio_Enable(IntPtr context, int what, int enable) { }

		private static int ovrAudio_Enable(IntPtr context, EnableFlag what, int enable) { }

		private static int ovrAudio_GetRaycastHits(IntPtr context, Vector3[] points, Vector3[] normals, int length) { }

		private static int ovrAudio_GetRoomDimensions(IntPtr context, float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position) { }

		private static int ovrAudio_SetAdvancedBoxRoomParametersUnity(IntPtr context, float width, float height, float depth, bool lockToListenerPosition, float positionX, float positionY, float positionZ, float[] wallMaterials) { }

		private static int ovrAudio_SetDynamicRoomInterpSpeed(IntPtr context, float InterpSpeed) { }

		private static int ovrAudio_SetDynamicRoomMaxWallDistance(IntPtr context, float MaxWallDistance) { }

		private static int ovrAudio_SetDynamicRoomRaysPerSecond(IntPtr context, int RaysPerSecond) { }

		private static int ovrAudio_SetDynamicRoomRaysRayCacheSize(IntPtr context, int RayCacheSize) { }

		private static int ovrAudio_SetRoomClutterFactor(IntPtr context, float[] clutterFactor) { }

		private static int ovrAudio_SetSharedReverbWetLevel(IntPtr context, float linearLevel) { }

		public override int SetAdvancedBoxRoomParameters(float width, float height, float depth, bool lockToListenerPosition, Vector3 position, float[] wallMaterials) { }

		public override int SetDynamicRoomInterpSpeed(float InterpSpeed) { }

		public override int SetDynamicRoomMaxWallDistance(float MaxWallDistance) { }

		public override int SetDynamicRoomRaysPerSecond(int RaysPerSecond) { }

		public override int SetDynamicRoomRaysRayCacheSize(int RayCacheSize) { }

		public override int SetEnabled(int feature, bool enabled) { }

		public int SetEnabled(EnableFlag feature, bool enabled) { }

		public override int SetRoomClutterFactor(float[] clutterFactor) { }

		public override int SetSharedReverbWetLevel(float linearLevel) { }

	}

	private static NativeInterface CachedInterface; //Field offset: 0x0

	public static NativeInterface Interface
	{
		 get { } //Length: 183
	}

	public MetaXRAudioNativeInterface() { }

	private static NativeInterface FindInterface() { }

	public static NativeInterface get_Interface() { }

}

