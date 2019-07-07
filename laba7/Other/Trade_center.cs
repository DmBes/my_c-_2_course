using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace laba7.Other
{
    [Serializable]
    class Trade_center : Kiosk
    {

        protected int CountsWorker;


        public Kiosk kio = new Kiosk();



        public Trade_center(string Name, string Adress, int workers) : base(Name, Adress)
        {
            CountsWorker = workers;
        }

        public Trade_center(int workers) : this(new Kiosk("das", "dad"), 600)
        {
            CountsWorker = workers;
        }



        public Trade_center(Kiosk a, int workers)
        {
            kio = a;
        }

        public void upload_i(string name_file)
        {

            using (FileStream xq = new FileStream(name_file, FileMode.OpenOrCreate))
            {
                BinaryWriter bw = new BinaryWriter(xq);
                bw.Write(this.NameObject);
                
                bw.Write(this.AdressObject);
                bw.Write(this.CountsWorker);

            }
        }

        public Trade_center download_i(string name_file)
        {

            using (FileStream xq = new FileStream(name_file, FileMode.Open))
            {
                BinaryReader bw = new BinaryReader(xq);
                string rea1 = bw.ReadString();
                string rea2 = bw.ReadString();
                int rea3 = bw.ReadInt32();

                return new Trade_center(rea1,rea2,rea3);

  



            }
        }



        public void upload_x(string name_file)
        {

            using (StreamWriter xq = new StreamWriter(name_file,false))
            {
                
                xq.Write(this.NameObject);

                xq.Write(this.AdressObject);
                xq.Write(this.CountsWorker);

            }
        }

    }
}
