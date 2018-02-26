using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFReader.Model
{
    class FileReaderModel
    {

        public string Getfile(string filename)
        {
            using (Pk_Uppgift.FileReaderReference.FileReaderServiceSoapClient client = new Pk_Uppgift.FileReaderReference.FileReaderServiceSoapClient())
            {
                return client.ReadFile(filename);
            }
        }


    }
}
