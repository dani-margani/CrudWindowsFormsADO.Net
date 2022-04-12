using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CrudWindowsFormsAddoNet
{
    public class ItemsCentralesDB
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=Prueba;Integrated Security=True; MultipleActiveResultSets=True";
        public bool Ok()

        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;


        }


        public List<ItemCentral> Get()
        {
            List<ItemCentral> ListItemCentral = new List<ItemCentral>();

            string query = "select Id, Codigo, Descripcion, Precio_Unitario, Precio_Caja from Items_Centrales";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                       
                        ItemCentral oItemCentral = new ItemCentral();
                        oItemCentral.Id = reader.GetInt32(0);
                        oItemCentral.Codigo = reader.GetString(1);
                        oItemCentral.Descripcion = reader.GetString(2);
                        oItemCentral.PrecioUnitario = reader.GetDecimal(3);
                        oItemCentral.PrecioCaja = reader.GetDecimal(4);
                        ListItemCentral.Add(oItemCentral);

                    } 
                    reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw  new Exception("Hay un error en la base de datos"+ex.Message);
                }
                
            }

            return ListItemCentral;

        }

        
    }

    public class ItemCentral
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioCaja { get; set; }
    }
}
