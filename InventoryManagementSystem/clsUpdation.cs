using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class clsUpdation
    {
        public static void UpdateUsers(int UserID, string Name, string Username, string Password, string Phone, string Email, Int16 Status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateUser", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@UserID", UserID);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Username", Username);
                com.Parameters.AddWithValue("@Password", Password);
                com.Parameters.AddWithValue("@Phone", Phone);
                com.Parameters.AddWithValue("@Email", Email);
                com.Parameters.AddWithValue("@Status", Status);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(Name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateCategories(int CatID, string Name, Int16 Status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateCat", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CatID", CatID);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Status", Status);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(Name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateProducts(Int64 proID, string Name, string Barcode,  int fkCatID, DateTime? ExpiryDate = null)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateProducts", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProID", proID);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Barcode", Barcode);
                if (ExpiryDate == null)
                {
                    com.Parameters.AddWithValue("@ExpiryDate", DBNull.Value);
                }
                else
                {
                    com.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                }
                com.Parameters.AddWithValue("@fkCatID", fkCatID);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(Name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateSuppliers(int SupID, string company, string contactPerson, string Phone1, string address, Int16 status, string Phone2 = null, string NTN = null)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateSuppliers", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SupID", SupID);
                com.Parameters.AddWithValue("@CompanyName", company);
                com.Parameters.AddWithValue("@ContactPerson", contactPerson);
                com.Parameters.AddWithValue("@Phone1", Phone1);
                com.Parameters.AddWithValue("@Address", address);
                com.Parameters.AddWithValue("@Status", status);
                if (Phone2 == null)
                {
                    com.Parameters.AddWithValue("@Phone2", DBNull.Value);
                }
                else
                {
                    com.Parameters.AddWithValue("@Phone2", Phone2);
                }

                if (NTN == null)
                {
                    com.Parameters.AddWithValue("@NTN", DBNull.Value);
                }
                else
                {
                    com.Parameters.AddWithValue("@NTN", NTN);
                }
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(company + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateStock(Int64 ProID, int Quantity)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateStock", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@fkProductID", ProID);
                com.Parameters.AddWithValue("@Quantity", Quantity);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                
            }
            catch (Exception x)
            {

                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Success", "Error");
            }

        }

        public static void UpdateStockWithoutConnection(Int64 ProID, int Quantity)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateStock", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@fkProductID", ProID);
                com.Parameters.AddWithValue("@Quantity", Quantity);
                int st = com.ExecuteNonQuery();
            }
            catch (Exception x)
            {

                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Success", "Error");
            }

        }

        public static void UpdatePrice(Int64 ProID, float pp,float profit, float disc, float sp)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdatePrice", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProID", ProID);
                com.Parameters.AddWithValue("@PP", pp);
                com.Parameters.AddWithValue("@Profit", profit);
                com.Parameters.AddWithValue("@Disc", disc);
                com.Parameters.AddWithValue("@SP", sp);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st>0)
                {
                    MainClass.ShowMsg("Price updated successfully!", "Success", "Success");
                }
            }
            catch (Exception x)
            {

                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Success", "Error");
            }

        }

        public static void UpdatePurchasePrice(Int64 ProID, float pp)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdatePurchasePrice", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProID", ProID);
                com.Parameters.AddWithValue("@PP", pp);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg("Price updated successfully!", "Success", "Success");
                }
            }
            catch (Exception x)
            {

                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Success", "Error");
            }
        }

        public static void UpdateQuantityInSaleDetails(Int64 ProID,Int64 saleID, int Quantity)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateQuantityInSaleDetails", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProductID", ProID);
                com.Parameters.AddWithValue("@SaleID", saleID);
                com.Parameters.AddWithValue("@Quantity", Quantity);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception x)
            {

                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Success", "Error");
            }

        }
    }
}
