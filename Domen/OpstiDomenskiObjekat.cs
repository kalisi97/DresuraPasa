using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        OpstiDomenskiObjekat citajRedTabele(DataRow red);
        OpstiDomenskiObjekat citajRedTabeleID(DataRow red);
        OpstiDomenskiObjekat citajRedTabele1(DataRow red);

        string ID { get; }
        string NazivTabele { get; }
        string Insert { get; }
        string Update { get; }
        string UslovID { get; }
        string OpstiUslov { get; }
        string ID1 { get; }
        string UslovID1 { get; }

        
    }
}
