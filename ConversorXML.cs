using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

//https://learn.microsoft.com/pt-br/dotnet/api/system.xml.serialization.xmlserializer.serialize?view=net-7.0#system-xml-serialization-xmlserializer-serialize(system-xml-xmlwriter-system-object)

namespace Conversor_arquivosUtil
{
	public class ConversorXML
	{
        public ConversorXML()
        {
            
        }

        public string Conversor(object arquivoXml)
        {
            //Pessoa arquivoXml = arquivo as Pessoa;
            //Type tipoClasse = arquivoXml.GetType();

            XmlSerializer serializer = new XmlSerializer(typeof(Pessoa));

            using (StringWriter writer = new StringWriter())
            {
				serializer.Serialize(writer, arquivoXml);
                var xml = writer.ToString();
				return writer.ToString();
			}
        }
    }
}
