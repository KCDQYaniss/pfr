namespace System.Xml.Schema;

public class XmlSchemaValidationException : XmlSchemaException
{

	protected XmlSchemaValidationException(SerializationInfo info, StreamingContext context) { }

	public XmlSchemaValidationException() { }

	internal XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	internal XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	internal XmlSchemaValidationException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

