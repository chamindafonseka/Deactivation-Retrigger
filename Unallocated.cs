using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Bulk_Deactivation_Retrigger
{
    public partial class Unallocated : Form
    {
        public string cs = @"Data Source = 192.168.128.150;Initial Catalog = SBSSMS ; User ID = appuser; Password=241To232";
        public int cid = 100;
        int invid1 = 0;
        int invid2 = 0;
        public static string deactDetails;

        public Unallocated()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {

                    con.Open();
                    string qry = "SELECT COUNT(i.InventoryID) FROM Inventory i WHERE  i.ContractID = 0  AND i.CASID = 4 AND i.ItemType = 2  ";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    lblTotalBoxes.Text = (Convert.ToInt32(cmd.ExecuteScalar())).ToString();

                    string qry2 = "SELECT min(i.InventoryID) FROM Inventory i    WHERE  i.ContractID = 0  AND  i.CASID = 4 AND i.ItemType = 2 ";
                    SqlCommand cmd2 = new SqlCommand(qry2, con);
                    lblMin.Text = (Convert.ToInt32(cmd2.ExecuteScalar())).ToString();

                    string qry3 = "SELECT max(i.InventoryID) FROM Inventory i    WHERE  i.ContractID = 0  AND  i.CASID = 4 AND i.ItemType = 2 "; SqlCommand cmd3 = new SqlCommand(qry3, con);
                    lblMax.Text = (Convert.ToInt32(cmd3.ExecuteScalar())).ToString();

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                invid1 = Convert.ToInt32(txtFrom.Text);
                invid2 = Convert.ToInt32(txtTo.Text);

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string qry = "SELECT COUNT(i.InventoryID) FROM Inventory i   WHERE   i.ContractID = 0  AND   i.CASID = 4 AND i.ItemType = 2    AND i.InventoryID >=  @InventoryID1 AND i.InventoryID <= @InventoryID2";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    
                    cmd.Parameters.AddWithValue("@InventoryID1", invid1);
                    cmd.Parameters.AddWithValue("@InventoryID2", invid2);
                    lblCheck.Text = (Convert.ToInt32(cmd.ExecuteScalar())).ToString();
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                var fileName = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "write.txt");
                using (StreamWriter writer = File.AppendText(fileName))
                {

                    writer.WriteLine(DateTime.Now.ToString() + " From InvID : " + invid1 + "  To InventryID : " + invid2 + " unallocated Boxes : " + lblCheck.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeactCmd_Click(object sender, EventArgs e)
        {
            try
            {


                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string qry2 = "INSERT INTO  CASAuthorization (ContractID, InventoryID, AuthorizationType, RequestType, AppUserID, InvoiceAdjustment, StatusAdjustment, SentSMS ) SELECT 0 AS ContractID, Inventory.InventoryID  ,2 AS AuthorizationType, 13 AS RequestType,2 AS AppUserID,0 AS InvoiceAdjustment,0 AS StatusAdjustment,1 AS SentSMS  FROM Inventory WHERE Inventory.ContractID = 0 AND Inventory.ItemType = 2 AND Inventory.CASID = 4  AND Inventory.InventoryID >= @InventoryID1 AND Inventory.InventoryID <= @InventoryID2";

                    SqlCommand cmd2 = new SqlCommand(qry2, con);

                    cmd2.Parameters.AddWithValue("@InventoryID1", invid1);
                    cmd2.Parameters.AddWithValue("@InventoryID2", invid2);
                    int b = cmd2.ExecuteNonQuery();

                    MessageBox.Show("Deactivation command has been sent to " + b + " boxes" + "\n" + "From InvID : " + invid1 + "  To InventryID : " + invid2);
                    con.Close();



                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtFrom.Text = txtTo.Text = lblCheck.Text = string.Empty;

        }
    }
}
