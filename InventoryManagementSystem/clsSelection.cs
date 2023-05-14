using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
namespace InventoryManagementSystem
{
    class clsSelection
    {
        public static int USERID//userID of the user to be loged in
        {
            get;
            private set;
        }

        public static string NAME// name of the user to be loged in
        {
            get;
            private set;
        }

        private static string UserName = null, PassWord = null;//this username and password is stored in database

        private static bool CheckLogin;

        public static bool UserLogin(string username, string password)//this username and password is given by user on login screen
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UserLogin", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Username", username);
                com.Parameters.AddWithValue("@Password", password);
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CheckLogin = true;

                        USERID = Convert.ToInt32(dr["UserID"].ToString());
                        NAME = dr["Name"].ToString();
                        UserName = dr["Username"].ToString();
                        PassWord = dr["Password"].ToString();
                    }
                }
                else
                {
                    CheckLogin = false;

                    if (username != null && password != null)
                    {
                        if (UserName != username && PassWord == password)
                        {
                            MainClass.ShowMsg("Invalid Username!", "Error", "Error");
                        }
                        else if (UserName == username && PassWord != password)
                        {
                            MainClass.ShowMsg("Invalid Password!", "Error", "Error");
                        }
                        else if (UserName != username && PassWord != password)
                        {
                            MainClass.ShowMsg("Invalid Username and Password!", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return CheckLogin;
        }

        public static void SelectUsers(DataGridView gv, DataGridViewColumn gvUserID, DataGridViewColumn gvName, DataGridViewColumn gvUsername, DataGridViewColumn gvPassword, DataGridViewColumn gvPhone, DataGridViewColumn gvEmail, DataGridViewColumn gvStatus, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectUser", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchUser", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvUserID.DataPropertyName = dt.Columns["UserID"].ToString();
                gvName.DataPropertyName = dt.Columns["Name"].ToString();
                gvUsername.DataPropertyName = dt.Columns["Username"].ToString();
                gvPassword.DataPropertyName = dt.Columns["Password"].ToString();
                gvPhone.DataPropertyName = dt.Columns["Phone"].ToString();
                gvEmail.DataPropertyName = dt.Columns["Email"].ToString();
                gvStatus.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectCategories(DataGridView gv, DataGridViewColumn gvCatID, DataGridViewColumn gvName, DataGridViewColumn gvStatus, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectCat", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchCat", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvCatID.DataPropertyName = dt.Columns["CatID"].ToString();
                gvName.DataPropertyName = dt.Columns["Name"].ToString();
                gvStatus.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownList(string procedure, ComboBox cb, string DisplayMember, string ValueMember)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownListWithTwoParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                com.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectProducts(DataGridView gv, DataGridViewColumn gvProID, DataGridViewColumn gvName, DataGridViewColumn gvBarcode, DataGridViewColumn gvExpiryDate, DataGridViewColumn gvCatID, DataGridViewColumn gvCatName, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectProducts", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchProducts", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvProID.DataPropertyName = dt.Columns["ProID"].ToString();
                gvName.DataPropertyName = dt.Columns["Name"].ToString();
                gvBarcode.DataPropertyName = dt.Columns["Barcode"].ToString();
               // gvPrice.DataPropertyName = dt.Columns["Price"].ToString();
                gvExpiryDate.DataPropertyName = dt.Columns["ExpiryDate"].ToString();
                gvCatID.DataPropertyName = dt.Columns["CatID"].ToString();
                gvCatName.DataPropertyName = dt.Columns["CatName"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectSuppliers(DataGridView gv, DataGridViewColumn gvSupID, DataGridViewColumn gvCompanyName, DataGridViewColumn gvContactPerson, DataGridViewColumn gvPhone1, DataGridViewColumn gvPhone2, DataGridViewColumn gvNTN, DataGridViewColumn gvAddress, DataGridViewColumn gvStatus, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectSuppliers", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchSuppliers", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvSupID.DataPropertyName = dt.Columns["SupID"].ToString();
                gvCompanyName.DataPropertyName = dt.Columns["CompanyName"].ToString();
                gvContactPerson.DataPropertyName = dt.Columns["ContactPerson"].ToString();
                gvPhone1.DataPropertyName = dt.Columns["Phone1"].ToString();
                gvPhone2.DataPropertyName = dt.Columns["Phone2"].ToString();
                gvNTN.DataPropertyName = dt.Columns["NTN"].ToString();
                gvAddress.DataPropertyName = dt.Columns["Address"].ToString();
                gvStatus.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static string[] ProductData = new string[3];

        public static string[] GetProductDetails(string barcode)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectProWithBarcode", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProductData[0] = dr[0].ToString(); //Product ID
                        ProductData[1] = dr[1].ToString(); //Product name
                        ProductData[2] = dr[2].ToString(); //Barcode
                    }
                }
                else
                {
                    MainClass.ShowMsg("Invalid Barcode", "Error", "Error");
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return ProductData;
        }

        public static string[] ProductDataForPrice = new string[6];

        public static string[] GetProductDetailsForPrice(string barcode)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectProWithBarcodeForPrice", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProductDataForPrice[0] = dr[0].ToString(); //Product ID
                        ProductDataForPrice[1] = dr[1].ToString(); //Product name
                        ProductDataForPrice[2] = dr[2].ToString(); //Barcode
                        ProductDataForPrice[3] = dr[3].ToString(); //Sale Price
                        ProductDataForPrice[4] = dr[4].ToString(); //Discount
                        ProductDataForPrice[5] = dr[5].ToString(); //Final Sale Price
                    }
                }
                else
                {
                    MainClass.ShowMsg("Invalid Barcode", "Error", "Error");
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return ProductDataForPrice;
        }

        public static void SelectPurchaseDetails(Int64 purchaseId, DataGridView gv, DataGridViewColumn gvPurDetailID, DataGridViewColumn gvProID, DataGridViewColumn gvName, DataGridViewColumn gvQuantity, DataGridViewColumn gvUnitPrice, DataGridViewColumn gvTotalAmount)
        {
            try
            {

                SqlCommand com = new SqlCommand("stp_SelectPurchaseDetails", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@PurchaseID", purchaseId);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvPurDetailID.DataPropertyName = dt.Columns["PurDetailID"].ToString();
                gvProID.DataPropertyName = dt.Columns["ProductID"].ToString();
                gvName.DataPropertyName = dt.Columns["ProductName"].ToString();
                gvQuantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                gvUnitPrice.DataPropertyName = dt.Columns["UnitPrice"].ToString();
                gvTotalAmount.DataPropertyName = dt.Columns["TotalPrice"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        private static int StockCount;
        public static int SelectProductQuantityInStock(Int64 ProductID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectQuantityFromStock", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("ProductID", ProductID);
                MainClass.con.Open();
                StockCount = Convert.ToInt32(com.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return StockCount;
        }
        private static Int64 proID;
        public static Int64 SelectProductIDInStock(Int64 ProductID)
        {
            
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectProductIDFromStock", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProID", ProductID);
                MainClass.con.Open();
                proID = Convert.ToInt64(com.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return proID;
        }

        public static int SelectProductQuantityInStockWithoutConnection(Int64 ProductID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectQuantityFromStock", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("ProductID", ProductID);
                StockCount = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return StockCount;
        }

        public static void SelectAvailableStock(DataGridView gv, DataGridViewColumn gvProID, DataGridViewColumn gvName, DataGridViewColumn gvBarcode, DataGridViewColumn gvCategory, DataGridViewColumn gvExpiry, DataGridViewColumn gvPP, DataGridViewColumn gvSP, DataGridViewColumn gvTotal, DataGridViewColumn gvStock, DataGridViewColumn gvStatus)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStock", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvProID.DataPropertyName = dt.Columns["Product ID"].ToString();
                gvName.DataPropertyName = dt.Columns["Product"].ToString();
                gvBarcode.DataPropertyName = dt.Columns["Barcode"].ToString();
                gvCategory.DataPropertyName = dt.Columns["Category"].ToString();
                gvExpiry.DataPropertyName = dt.Columns["Expiry"].ToString();
                gvPP.DataPropertyName = dt.Columns["PP"].ToString();
                gvSP.DataPropertyName = dt.Columns["SP"].ToString();
                gvTotal.DataPropertyName = dt.Columns["Total"].ToString();
                gvStock.DataPropertyName = dt.Columns["Stock"].ToString();
                gvStatus.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectProductsWithCategories(int CatID,DataGridView gv, DataGridViewColumn gvProID, DataGridViewColumn gvName, DataGridViewColumn gvPP, DataGridViewColumn gvProfit, DataGridViewColumn gvDisc, DataGridViewColumn gvSP)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectProWithCategory", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CatID", CatID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvProID.DataPropertyName = dt.Columns["ProID"].ToString();
                gvName.DataPropertyName = dt.Columns["Product"].ToString();
                gvPP.DataPropertyName = dt.Columns["pp"].ToString();
                gvProfit.DataPropertyName = dt.Columns["Profit"].ToString();
                gvDisc.DataPropertyName = dt.Columns["Disc"].ToString();
                gvSP.DataPropertyName = dt.Columns["SP"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        private static bool ChkProID;
        public static bool SelectProductIDFromPrice(Int64 ProductID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectProductIDFromPrice", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProID", ProductID);
                MainClass.con.Open();
                SqlDataReader dr= com.ExecuteReader();
                if (dr.HasRows)
                {
                    ChkProID = true;
                }
                else
                {
                    ChkProID = false;
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return ChkProID;
        }

        public static void ShowReciept(ReportDocument rd,CrystalReportViewer CRV,string proced, string param1,object val1)
        {
            try
            {
                SqlCommand com = new SqlCommand(proced, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\SalesReciept.rpt");
                rd.SetDataSource(dt);
                CRV.ReportSource=rd;
                CRV.RefreshReport();
            }
            catch (Exception x)
            {

                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectSaleDetails(DateTime date,DataGridView gv,DataGridViewColumn gvSaleID,DataGridViewColumn gvTotal,DataGridViewColumn gvDiscount,DataGridViewColumn gvAmountGiven,DataGridViewColumn gvAmountReturned, DataGridViewColumn gvUserID, DataGridViewColumn gvDoneBy)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectSaleDetails", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Date", date);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvSaleID.DataPropertyName = dt.Columns["SaleID"].ToString();
                gvTotal.DataPropertyName = dt.Columns["Total"].ToString();
                gvDiscount.DataPropertyName = dt.Columns["Discount"].ToString();
                gvAmountGiven.DataPropertyName = dt.Columns["AmountGiven"].ToString();
                gvAmountReturned.DataPropertyName = dt.Columns["AmountReturn"].ToString();
                gvUserID.DataPropertyName = dt.Columns["UserID"].ToString();
                gvDoneBy.DataPropertyName = dt.Columns["DoneBy"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.ShowMsg(x.Message, "Error", "Error");

            }
        }

       
        public static void SalesReturn(Int64 SaleID, DataGridView gv, DataGridViewColumn gvSaleID, DataGridViewColumn gvProID, DataGridViewColumn gvProName, 
            DataGridViewColumn gvBarcode, DataGridViewColumn gvQuantity, DataGridViewColumn gvUnitPrice, DataGridViewColumn gvPrice, 
            DataGridViewColumn gvTotal,DataGridViewColumn gvDiscount, DataGridViewColumn gvTotalDiscount, DataGridViewColumn gvDiscountedPrice, 
            DataGridViewColumn gvAmountGiven, DataGridViewColumn gvAmountReturned, DataGridViewColumn gvDoneBy, DataGridViewColumn gvPaymentType, DataGridViewColumn gvDate)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_GetSalesRecieptWithSaleID", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SaleID", SaleID);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvSaleID.DataPropertyName = dt.Columns["SaleID"].ToString();
                    gvProID.DataPropertyName = dt.Columns["ProID"].ToString();
                    gvProName.DataPropertyName = dt.Columns["Product"].ToString();
                    gvBarcode.DataPropertyName = dt.Columns["Barcode"].ToString();
                    gvQuantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                    gvUnitPrice.DataPropertyName = dt.Columns["Unit Price"].ToString();
                    gvPrice.DataPropertyName = dt.Columns["Per Product Total"].ToString();
                    gvDiscount.DataPropertyName = dt.Columns["Per Product Discount"].ToString();
                    gvTotal.DataPropertyName = dt.Columns["Total Amount"].ToString();
                    gvTotalDiscount.DataPropertyName = dt.Columns["Total Discount"].ToString();
                    gvDiscountedPrice.DataPropertyName = dt.Columns["Discounted Price"].ToString();
                    gvAmountGiven.DataPropertyName = dt.Columns["Amount Given"].ToString();
                    gvAmountReturned.DataPropertyName = dt.Columns["Amount Return"].ToString();
                    gvDoneBy.DataPropertyName = dt.Columns["Sales Man"].ToString();
                    gvPaymentType.DataPropertyName = dt.Columns["Payment Type"].ToString();
                    gvDate.DataPropertyName = dt.Columns["Date"].ToString();
                    gv.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.ShowMsg(x.Message, "Error", "Error");

            }
        }
    }
}
