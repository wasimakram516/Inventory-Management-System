using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class clsInsertion
    {
        public static void InsertUsers(string Name, string Username, string Password, string Phone, string Email, Int16 Status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddUser", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Username", Username);
                com.Parameters.AddWithValue("@Password", Password);
                com.Parameters.AddWithValue("@Phone", Phone);
                com.Parameters.AddWithValue("@Email", Email);
                com.Parameters.AddWithValue("@Status", Status);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(Name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void InsertCategories(string Name, Int16 Status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddCat", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Status", Status);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMsg(Name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void InsertProducts(string Name, string Barcode, int fkCatID, DateTime? ExpiryDate = null)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddProducts", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Barcode", Barcode);
                // com.Parameters.AddWithValue("@Price", Price);
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
                MainClass.ShowMsg(Name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void InsertSuppliers(string company, string contactPerson, string Phone1, string address, Int16 status, string Phone2 = null, string NTN = null)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddSuppliers", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
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
                MainClass.ShowMsg(company + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        private static Int64 PurchaseID;
        public static Int64 InsertPurchases(DateTime date, int DoneBy, int SuplierID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddPurchases", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@DoneBy", DoneBy);
                com.Parameters.AddWithValue("@fkSuplierID", SuplierID);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                com.CommandText = "stp_SelectLastPurchaseID";
                com.Parameters.Clear();
                PurchaseID = Convert.ToInt64(com.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return PurchaseID;
        }

        static int count;
        public static int InsertPurchaseDetails(Int64 PurID, Int64 ProID, int Quantity, float TotalPrice)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddPurchaseDetails", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@fkPurchaseID", PurID);
                com.Parameters.AddWithValue("@ProductID", ProID);
                com.Parameters.AddWithValue("@Quantity", Quantity);
                com.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                MainClass.con.Open();
                count = com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return count;
        }

        public static void InsertStock(Int64 ProID, int Quantity)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddStock", MainClass.con);
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
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }

        }

        public static void InsertDeletedItems(Int64 PurID, int UserID, Int64 ProID, int Quantity, DateTime date)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddDeletedItemsPI", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@PurchaseID", PurID);
                com.Parameters.AddWithValue("@fkProductID", ProID);
                com.Parameters.AddWithValue("@Quantity", Quantity);
                com.Parameters.AddWithValue("@UserID", UserID);
                com.Parameters.AddWithValue("@Deleted_Date", date);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }

        }

        public static void InsertPrice(Int64 ProID, float PurchasePrice)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddPrice", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProID", ProID);
                com.Parameters.AddWithValue("@PurPrice", PurchasePrice);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }

        }

        public static void InsertSales(DataGridView gv, string gvProID, string gvQuantity,string gvDiscount,string gvFinalSalePrice, int DoneBy, DateTime Date, float TotalAmount, float TotalDiscount, float AmouuntGiven, float AmountReturn, string PayType)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand com = new SqlCommand("stp_AddSales", MainClass.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@DoneBy", DoneBy);
                    com.Parameters.AddWithValue("@Date", Date);
                    com.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    com.Parameters.AddWithValue("@TotalDiscount", TotalDiscount);
                    com.Parameters.AddWithValue("@AmountGiven", AmouuntGiven);
                    com.Parameters.AddWithValue("@AmountReturn", AmountReturn);
                    if (PayType=="Cash")
                    {
                        com.Parameters.AddWithValue("@PayType", 0);
                    }
                    else if (PayType== "Debit Card")
                    {
                        com.Parameters.AddWithValue("@PayType", 1);
                    }
                    else if (PayType=="Credit Card" )
                    {
                        com.Parameters.AddWithValue("@PayType", 2);
                    }
                    MainClass.con.Open();
                    int SaleCount = com.ExecuteNonQuery();
                    if (SaleCount > 0)
                    {
                        SqlCommand com2 = new SqlCommand("stp_SelectSaleID", MainClass.con);
                        com2.CommandType = CommandType.StoredProcedure;
                        Int64 SaleID = Convert.ToInt64(com2.ExecuteScalar());
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand com3 = new SqlCommand("stp_AddSaleDetails", MainClass.con);
                            com3.CommandType = CommandType.StoredProcedure;
                            com3.Parameters.AddWithValue("@fkSaleID", SaleID);
                            com3.Parameters.AddWithValue("@fkProductID", Convert.ToInt64(row.Cells[gvProID].Value.ToString()));
                            com3.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells[gvQuantity].Value.ToString()));
                            com3.Parameters.AddWithValue("@SalePrice", Convert.ToSingle(row.Cells[gvFinalSalePrice].Value.ToString()));
                            com3.Parameters.AddWithValue("@Discount", Convert.ToSingle(row.Cells[gvDiscount].Value.ToString()));
                            com3.ExecuteNonQuery();
                            int QuantityInStock = clsSelection.SelectProductQuantityInStockWithoutConnection(Convert.ToInt64(row.Cells[gvProID].Value.ToString()));
                            int CurrentQuantity = Convert.ToInt32(row.Cells[gvQuantity].Value.ToString());
                            int RemaingQuantityInStock = QuantityInStock - CurrentQuantity;
                            clsUpdation.UpdateStockWithoutConnection(Convert.ToInt64(row.Cells[gvProID].Value.ToString()), RemaingQuantityInStock);
                        }
                    }
                    MainClass.con.Close();
                    MainClass.ShowMsg("Sales Succesfully Done..!", "Success", "Success");
                    sc.Complete();
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        static int RefCount;
        public static int InsertSalesRefund(Int64 SaleID, DateTime date,int DoneBy,Int64 proID,int Quantity,float RefAmount)
        {
            using (TransactionScope sc=new TransactionScope())
            {
                try
                {
                    SqlCommand com = new SqlCommand("stp_AddSalesRefund", MainClass.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@fkSalesID", SaleID);
                    com.Parameters.AddWithValue("@Date", date);
                    com.Parameters.AddWithValue("@DoneBy", DoneBy);
                    com.Parameters.AddWithValue("@RefAmount", RefAmount);
                    MainClass.con.Open();
                    RefCount = com.ExecuteNonQuery();
                    if (RefCount>0)
                    {
                        SqlCommand com2 = new SqlCommand("stp_SelectSaleRefundID", MainClass.con);
                        com2.CommandType = CommandType.StoredProcedure;
                        int SaleRefundID =Convert.ToInt32( com2.ExecuteScalar());
                        SqlCommand com3 = new SqlCommand("stp_AddSalesRefundDetails", MainClass.con);
                        com3.CommandType = CommandType.StoredProcedure;
                        com3.Parameters.AddWithValue("@fkSaleRefundID", SaleRefundID);
                        com3.Parameters.AddWithValue("@fkProID", proID);
                        com3.Parameters.AddWithValue("@Quantity", Quantity);
                        com3.ExecuteNonQuery();
                    }
                    MainClass.con.Close();
                    sc.Complete();
                }
                catch (Exception x)
                {
                    MainClass.con.Close();
                    MainClass.ShowMsg(x.Message, "Error", "Error");
                }
                return RefCount;
                
            }
            
        }
    }
}
