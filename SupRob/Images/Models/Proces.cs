using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupRob.Images.Models
{
   public  class Proces
    {
        
            List<Processor> proce = new List<Processor>();
            public void AddProces(Processor proces)
            {
                proce.Add(proces);


            }

            public List<Processor> GetAllProcesor()
            {
                return proce;
            }

            
         
        }
}
