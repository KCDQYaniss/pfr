namespace uLipSync;

public static class TextureCreator
{
	[BurstCompile]
	private struct CreateBakedDataWaveTextureJob : IJob
	{
		[WriteOnly]
		public NativeArray texColors; //Field offset: 0x0
		[DeallocateOnJobCompletion]
		[ReadOnly]
		public NativeArray phonemeColors; //Field offset: 0x10
		[DeallocateOnJobCompletion]
		[ReadOnly]
		public NativeArray phonemeRatios; //Field offset: 0x20
		[DeallocateOnJobCompletion]
		[ReadOnly]
		public NativeArray volumes; //Field offset: 0x30
		[ReadOnly]
		public int width; //Field offset: 0x40
		[ReadOnly]
		public int height; //Field offset: 0x44
		[ReadOnly]
		public int phonemeCount; //Field offset: 0x48
		[ReadOnly]
		public float smooth; //Field offset: 0x4C

		public override void Execute() { }

	}

	[BurstCompile]
	private struct CreateMfccTextureJob : IJob
	{
		[WriteOnly]
		public NativeArray texColors; //Field offset: 0x0
		[DeallocateOnJobCompletion]
		[ReadOnly]
		public NativeArray array; //Field offset: 0x10
		[ReadOnly]
		public int width; //Field offset: 0x20
		[ReadOnly]
		public int height; //Field offset: 0x24
		[ReadOnly]
		public float min; //Field offset: 0x28
		[ReadOnly]
		public float max; //Field offset: 0x2C

		public override void Execute() { }

		private Color ToRGB(float hue) { }

	}


	private static void ApplyPixelData(Texture2D tex, NativeArray array) { }

	public static Texture2D CreateBakedDataWaveTexture(BakedData data, int width, int height, float smooth = 0.85) { }

	public static Texture2D CreateMfccTexture(Texture2D tex, Profile profile, int index) { }

	public static Texture2D CreateMfccTexture(Texture2D tex, MfccData mfcc, float min, float max) { }

	private static NativeArray GetOrCreatePixelData(Texture2D tex) { }

}

