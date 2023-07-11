using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_arquivosUtil
{
	public class ConversorJson
	{
        public ConversorJson()
        {
            
        }
		public string Conversor (object Arquivo)
		 {
			//string output = JsonConvert.SerializeObject(Arquivo);
			
			string output = JsonConvert.SerializeObject(Arquivo,Formatting.Indented);

			return output;
		}
		
	}
}
