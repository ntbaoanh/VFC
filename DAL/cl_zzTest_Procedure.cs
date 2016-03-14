using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace DAL
{
    public class cl_zzTest_Procedure
    {
        public DataTable GetStores(int _sbsNo)
        {
            DataTable _dt = new DataTable();
            Utilities.ORACon _oraCon = new Utilities.ORACon();

            OracleCommand command = new OracleCommand( );
            command.Connection = _oraCon.GetConnection("192.168.9.248");
            command.CommandText = "NN_Invoice.spud_Select_Stores";
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter v_sbs_no = command.Parameters.Add( "v_sbs_no" , OracleDbType.Int16 );
            v_sbs_no.Value = 2;

            OracleParameter v_result = command.Parameters.Add( "v_result" , OracleDbType.RefCursor );
            v_result.Direction = ParameterDirection.Output;

            OracleDataAdapter da = new OracleDataAdapter( command );
            da.Fill( _dt );

            return _dt;
        }
    }
}
