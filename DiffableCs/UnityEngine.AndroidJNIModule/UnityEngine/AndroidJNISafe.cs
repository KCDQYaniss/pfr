namespace UnityEngine;

internal class AndroidJNISafe
{

	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span args) { }

	public static void CheckException() { }

	public static void DeleteLocalRef(IntPtr localref) { }

	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	public static IntPtr FindClass(string name) { }

	public static bool[] FromBooleanArray(IntPtr array) { }

	public static byte[] FromByteArray(IntPtr array) { }

	public static char[] FromCharArray(IntPtr array) { }

	public static double[] FromDoubleArray(IntPtr array) { }

	public static float[] FromFloatArray(IntPtr array) { }

	public static int[] FromIntArray(IntPtr array) { }

	public static long[] FromLongArray(IntPtr array) { }

	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	public static sbyte[] FromSByteArray(IntPtr array) { }

	public static short[] FromShortArray(IntPtr array) { }

	public static int GetArrayLength(IntPtr array) { }

	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	public static IntPtr GetObjectClass(IntPtr ptr) { }

	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	public static string GetStringChars(IntPtr str) { }

	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span args) { }

	public static IntPtr NewString(string chars) { }

	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	public static IntPtr ToBooleanArray(bool[] array) { }

	public static IntPtr ToByteArray(byte[] array) { }

	public static IntPtr ToCharArray(char[] array) { }

	public static IntPtr ToDoubleArray(double[] array) { }

	public static IntPtr ToFloatArray(float[] array) { }

	public static IntPtr ToIntArray(int[] array) { }

	public static IntPtr ToLongArray(long[] array) { }

	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	public static IntPtr ToSByteArray(sbyte[] array) { }

	public static IntPtr ToShortArray(short[] array) { }

}

