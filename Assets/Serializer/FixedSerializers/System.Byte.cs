using System.IO;
using System.Collections;

namespace cloudsoft
{
	public class System_Byte_Serializer : Serializer {

		public System_Byte_Serializer()
		{
			SerializerOf = typeof(byte);
			ManualChange = true;
		}


		public override object Read( SerializerStream stream, System.Type type )
		{
			return stream.ReadSystem_Byte();
		}
		public override int Write( SerializerStream stream, object obj )
		{
			byte b = (byte)obj;
			stream.WriteSystem_Byte( b );
			return 1;
		}
	}

	public partial class SerializerStream
	{
		public int WriteSystem_Byte(  byte value )
		{
			buffer[pos++] = value ;
			return 1 ;
		}
		public byte ReadSystem_Byte( )
		{
			return buffer[pos++];
		}

		public int WriteBytes( byte[] value )
		{
			int size = 0;
			if( value == null )
			{
                size = WriteSystem_UInt32((uint)0);
				return size;
			}
            size = WriteSystem_UInt32((uint)value.Length);
            System.Buffer.BlockCopy(value, 0, buffer, pos, value.Length);
            pos += value.Length;
			size += value.Length ;
			return size;
		}
		public  byte[] ReadBytes()
		{
            uint size = ReadSystem_UInt32();
			if( size == 0 )
				return null;
			byte[] value = new byte[size];
			System.Buffer.BlockCopy(buffer, pos, value, 0, value.Length);
            pos += value.Length;
			return value ;
		}
	}
}

