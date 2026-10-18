namespace Assets.CommonAssets.Scripts.Utilities;

public static class ColliderExtendedDebug
{
	internal struct Box
	{
		[CompilerGenerated]
		private Vector3 <localFrontTopLeft>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Vector3 <localFrontTopRight>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private Vector3 <localFrontBottomLeft>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private Vector3 <localFrontBottomRight>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		private Vector3 <origin>k__BackingField; //Field offset: 0x30

		public Vector3 backBottomLeft
		{
			 get { } //Length: 81
		}

		public Vector3 backBottomRight
		{
			 get { } //Length: 80
		}

		public Vector3 backTopLeft
		{
			 get { } //Length: 81
		}

		public Vector3 backTopRight
		{
			 get { } //Length: 81
		}

		public Vector3 frontBottomLeft
		{
			 get { } //Length: 64
		}

		public Vector3 frontBottomRight
		{
			 get { } //Length: 64
		}

		public Vector3 frontTopLeft
		{
			 get { } //Length: 63
		}

		public Vector3 frontTopRight
		{
			 get { } //Length: 64
		}

		public Vector3 localBackBottomLeft
		{
			 get { } //Length: 56
		}

		public Vector3 localBackBottomRight
		{
			 get { } //Length: 55
		}

		public Vector3 localBackTopLeft
		{
			 get { } //Length: 56
		}

		public Vector3 localBackTopRight
		{
			 get { } //Length: 56
		}

		public private Vector3 localFrontBottomLeft
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private Vector3 localFrontBottomRight
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private Vector3 localFrontTopLeft
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 18
			[CompilerGenerated]
			private set { } //Length: 15
		}

		public private Vector3 localFrontTopRight
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private Vector3 origin
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public Box(Vector3 origin, Vector3 halfExtents, Quaternion orientation) { }

		public Box(Vector3 origin, Vector3 halfExtents) { }

		public Vector3 get_backBottomLeft() { }

		public Vector3 get_backBottomRight() { }

		public Vector3 get_backTopLeft() { }

		public Vector3 get_backTopRight() { }

		public Vector3 get_frontBottomLeft() { }

		public Vector3 get_frontBottomRight() { }

		public Vector3 get_frontTopLeft() { }

		public Vector3 get_frontTopRight() { }

		public Vector3 get_localBackBottomLeft() { }

		public Vector3 get_localBackBottomRight() { }

		public Vector3 get_localBackTopLeft() { }

		public Vector3 get_localBackTopRight() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Vector3 get_localFrontBottomLeft() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Vector3 get_localFrontBottomRight() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Vector3 get_localFrontTopLeft() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Vector3 get_localFrontTopRight() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Vector3 get_origin() { }

		public void Rotate(Quaternion orientation) { }

		[CompilerGenerated]
		private void set_localFrontBottomLeft(Vector3 value) { }

		[CompilerGenerated]
		private void set_localFrontBottomRight(Vector3 value) { }

		[CompilerGenerated]
		private void set_localFrontTopLeft(Vector3 value) { }

		[CompilerGenerated]
		private void set_localFrontTopRight(Vector3 value) { }

		[CompilerGenerated]
		private void set_origin(Vector3 value) { }

	}


	private static Vector3 CastCenterOnCollision(Vector3 origin, Vector3 direction, float hitInfoDistance) { }

	public static void DrawBox(Vector3 origin, Vector3 halfExtents, Quaternion orientation, Color color) { }

	public static void DrawBox(Vector3 origin, Vector3 halfExtents, Quaternion orientation, Color color, float duration) { }

	public static void DrawBox(Box box, Color color) { }

	public static void DrawBox(Box box, Color color, float time) { }

	public static void DrawBoxCastBox(Vector3 origin, Vector3 halfExtents, Quaternion orientation, Vector3 direction, float distance, Color color) { }

	public static void DrawBoxCastOnHit(Vector3 origin, Vector3 halfExtents, Quaternion orientation, Vector3 direction, float hitInfoDistance, Color color) { }

	private static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation) { }

}

