using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class ConnectDB
    {
        //public String databaseDBBIT = "bithis";
        //public String hostDBBIT = "172.25.1.5";
        //public String userDBBIT = "sa";
        //public String passDBBIT = "Orawanhospital1*";
        public String databaseDBBIT = "bithis_m";             //bit
        public String hostDBBIT = "localhost";
        public String userDBBIT = "sa";
        public String passDBBIT = "Ekartc2c5";
        public String portDBBIT = "3306";

        public String databaseDBBITDemo = "bithis";             //bit
        public String hostDBBITDemo = "localhost";
        public String userDBBITDemo = "sa";
        public String passDBBITDemo = "Ekartc2c5";
        public String portDBBITDemo = "3306";

        public String databaseDBORCMA = "hisorc_ma";        //orc master
        public String hostDBORCMA = "localhost";
        public String userDBORCMA = "root";
        public String passDBORCMA = "";
        public String portDBORCMA = "3306";

        public String databaseDBORCBA = "hisorc_ba";        // orc backoffice
        public String hostDBORCBA = "localhost";
        public String userDBORCBA = "root";
        public String passDBORCBA = "";
        public String portDBORCBA = "3306";

        public String databaseDBORCBIT = "bithis";        // orc BIT
        public String hostDBORCBIT = "localhost";
        public String userDBORCBIT = "root";
        public String passDBORCBIT = "";
        public String portDBORCBIT = "3306";
        
        public SqlConnection connBIT, connMainHIS1, connBITDemo;
        public MySqlConnection connORCMA, connORCBA, connORCBIT;
        public int _rowsAffected = 0;
        public ConnectDB(String host)
        {
            if (host == "bit")
            {
                connBIT = new SqlConnection();
                //connMainHIS.ConnectionString = GetConfig(hostName);
                connBIT.ConnectionString = "Server=" + hostDBBIT + ";Database=" + databaseDBBIT + ";Uid=" + userDBBIT + ";Pwd=" + passDBBIT + ";";
            }
            else if (host == "orc_ma")
            {
                connORCMA = new MySqlConnection();
                connORCMA.ConnectionString = "Server=" + hostDBORCMA + ";Database=" + databaseDBORCMA + ";Uid=" + userDBORCMA + ";Pwd=" + passDBORCMA + ";port = "+ portDBORCMA + ";Connection Timeout = 300;default command timeout=0; CharSet=utf8;";
            }
            else if (host == "orc_ba")
            {
                connORCBA = new MySqlConnection();
                connORCBA.ConnectionString = "Server=" + hostDBORCBA + ";Database=" + databaseDBORCBA + ";Uid=" + userDBORCBA + ";Pwd=" + passDBORCBA + ";port = "+ portDBORCBA + ";Connection Timeout = 300;default command timeout=0; CharSet=utf8;";
            }
            else if (host == "orc_bit")
            {
                connORCBIT = new MySqlConnection();
                connORCBIT.ConnectionString = "Server=" + hostDBORCBIT + ";Database=" + databaseDBORCBIT + ";Uid=" + userDBORCBIT + ";Pwd=" + passDBORCBIT + ";port = "+ portDBORCBIT + ";Connection Timeout = 300;default command timeout=0; CharSet=utf8;";
            }
            else if (host == "bithis")
            {
                connBITDemo = new SqlConnection();
                connBITDemo.ConnectionString = "Server=" + hostDBBITDemo + ";Database=" + databaseDBBITDemo + ";Uid=" + userDBBITDemo + ";Pwd=" + passDBBITDemo + ";";
            }
        }
        public ConnectDB(String hostDB, String databaseDB, String userDB, String passDB)
        {
            connBITDemo = new SqlConnection();
            //connMainHIS.ConnectionString = GetConfig(hostName);
            connBITDemo.ConnectionString = "Server=" + hostDB + ";Database=" + databaseDB + ";Uid=" + userDB + ";Pwd=" + passDB + ";";

        }

        public DataTable selectData(String sql, String host)
        {
            DataTable toReturn = new DataTable();
            if (host == "bit")
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connBIT;
                SqlDataAdapter adapMainhis = new SqlDataAdapter(comMainhis);
                try
                {
                    connBIT.Open();
                    adapMainhis.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    connBIT.Close();
                    comMainhis.Dispose();
                    adapMainhis.Dispose();
                }
            }
            else if (host == "orc_ma")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;
                com.Connection = connORCMA;
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                try
                {
                    connORCMA.Open();
                    adap.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    connORCMA.Close();
                    com.Dispose();
                    adap.Dispose();
                }
            }
            else if (host == "orc_ba")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;
                com.Connection = connORCBA;
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                try
                {
                    connORCBA.Open();
                    adap.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    connORCBA.Close();
                    com.Dispose();
                    adap.Dispose();
                }
            }
            else if (host == "orc_bit")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;
                com.Connection = connORCBIT;
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                try
                {
                    connORCBIT.Open();
                    adap.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    connORCBIT.Close();
                    com.Dispose();
                    adap.Dispose();
                }
            }
            else if (host == "bit_demo")
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connBITDemo;
                SqlDataAdapter adapMainhis = new SqlDataAdapter(comMainhis);
                try
                {
                    connBITDemo.Open();
                    adapMainhis.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    connBITDemo.Close();
                    comMainhis.Dispose();
                    adapMainhis.Dispose();
                }
            }
            return toReturn;
        }

        public String ExecuteNonQuery(String sql, String host)
        {
            String toReturn = "";
            if (host == "bit")
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connBIT;
                try
                {
                    connBIT.Open();
                    _rowsAffected = comMainhis.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connBIT.Close();
                    comMainhis.Dispose();
                }
            }
            else if (host == "orc_ma")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;                
                com.Connection = connORCMA;
                try
                {
                    connORCMA.Open();
                    _rowsAffected = com.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connORCMA.Close();
                    com.Dispose();
                }
            }
            else if (host == "orc_ba")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;
                com.Connection = connORCBA;
                try
                {
                    connORCBA.Open();
                    _rowsAffected = com.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connORCBA.Close();
                    com.Dispose();
                }
            }
            else if (host == "orc_bit")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;
                com.Connection = connORCBIT;
                try
                {
                    connORCBIT.Open();
                    _rowsAffected = com.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connORCBIT.Close();
                    com.Dispose();
                }
            }
            else if (host == "bit_demo")
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connBITDemo;
                try
                {
                    connBITDemo.Open();
                    _rowsAffected = comMainhis.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connBITDemo.Close();
                    comMainhis.Dispose();
                }
            }
            return toReturn;
        }
        public String ExecuteNonQueryAutoIncrement(String sql, String host)
        {
            String toReturn = "";
            if (host == "bit")
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connBIT;
                try
                {
                    connBIT.Open();
                    _rowsAffected = comMainhis.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connBIT.Close();
                    comMainhis.Dispose();
                }
            }
            else if (host == "orc_ma")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;
                com.Connection = connORCMA;
                try
                {
                    connORCMA.Open();
                    _rowsAffected = com.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connORCMA.Close();
                    com.Dispose();
                }
            }
            else if (host == "orc_ba")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;
                com.Connection = connORCBA;
                try
                {
                    connORCBA.Open();
                    _rowsAffected = com.ExecuteNonQuery();
                    toReturn = com.LastInsertedId.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connORCBA.Close();
                    com.Dispose();
                }
            }
            else if (host == "orc_bit")
            {
                MySqlCommand com = new MySqlCommand();
                com.CommandText = sql;
                com.Connection = connORCBIT;
                try
                {
                    connORCBIT.Open();
                    _rowsAffected = com.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connORCBIT.Close();
                    com.Dispose();
                }
            }
            return toReturn;
        }
    }
}
