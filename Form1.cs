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
    public partial class Form1 : Form
    {
        public string cs = @"Data Source = 192.168.128.150;Initial Catalog = SBSSMS ; User ID = appuser; Password=241To232";
        public int cid = 100;
        int invid1 = 0;
        int invid2 = 0;
        public static string deactDetails;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if ("-1" == cmbCAS.SelectedIndex.ToString())
            {
                MessageBox.Show("Please select the CAS");
                cmbCAS.Focus();
                return;
            }            

            string cas =    cmbCAS.SelectedItem.ToString();
            

            if (cas == "iCAS")
            {
                cid = 4;
            }
            else if (cas == "NSTV")
            {
                cid = 3;
            }
            else
            {
                MessageBox.Show("Select the CAS Type!");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {

                con.Open();
                string qry = "SELECT COUNT(i.InventoryID) FROM Inventory i , Contract c  WHERE  i.ContractID = c.ContractID AND c.StatusID <> 1 AND i.CASID = @CASID  AND i.ItemType = 2  ";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@CASID", cid);
                lblTotalBoxes.Text = (Convert.ToInt32(  cmd.ExecuteScalar())).ToString();

                string qry2 = "SELECT Min(i.InventoryID) FROM Inventory i , Contract c  WHERE i.ContractID = c.ContractID AND c.StatusID <> 1 AND i.CASID = @CASID AND i.ItemType = 2  ";
                SqlCommand cmd2 = new SqlCommand(qry2, con);
                cmd2.Parameters.AddWithValue("@CASID", cid);
                lblMin.Text = (Convert.ToInt32(cmd2.ExecuteScalar())).ToString();

                string qry3 = "SELECT Max(i.InventoryID) FROM Inventory i , Contract c  WHERE i.ContractID = c.ContractID AND c.StatusID <> 1 AND i.CASID = @CASID  AND i.ItemType = 2  "; SqlCommand cmd3 = new SqlCommand(qry3, con);
                cmd3.Parameters.AddWithValue("@CASID", cid);
                lblMax.Text = (Convert.ToInt32(cmd3.ExecuteScalar())).ToString();

                con.Close();                 
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
                    string qry = "SELECT COUNT(i.InventoryID) FROM Inventory i , Contract c  WHERE i.ContractID = c.ContractID AND c.StatusID <> 1 AND i.CASID = @CASID  AND i.ItemType = 2    AND i.InventoryID >=  @InventoryID1 AND i.InventoryID <= @InventoryID2";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@CASID", cid);
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

                    writer.WriteLine(DateTime.Now.ToString() + " From InvID : " + invid1 + "  To InventryID : " + invid2 + "  Boxes : " + lblCheck.Text);

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

                    string qry2 = "INSERT INTO  CASAuthorization (ContractID, InventoryID, AuthorizationType, RequestType, AppUserID, InvoiceAdjustment, StatusAdjustment, SentSMS ) SELECT Contract.ContractID  ,Inventory.InventoryID  ,2 AS AuthorizationType,13 AS RequestType,2 AS AppUserID,0 AS InvoiceAdjustment,0 AS StatusAdjustment,1 AS SentSMS FROM Contract, Inventory, Agreement WHERE Contract.AgreementID = Agreement.AgreementID AND Contract.ContractID = Inventory.ContractID AND Inventory.ItemType = 2 AND Contract.StatusID <> 1  AND Inventory.CASID = @CASID  AND Inventory.InventoryID >= @InventoryID1 AND Inventory.InventoryID <= @InventoryID2";

                    SqlCommand cmd2 = new SqlCommand(qry2, con);
                    cmd2.Parameters.AddWithValue("@CASID", cid);
                    cmd2.Parameters.AddWithValue("@InventoryID1", invid1);
                    cmd2.Parameters.AddWithValue("@InventoryID2", invid2);
                    int b = cmd2.ExecuteNonQuery();

                    MessageBox.Show("Deactivation command has been sent to " + b + " boxes" +"\n" + "From InvID : " + invid1 + "  To InventryID : " + invid2 );
                    con.Close();              



                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtFrom.Text = txtTo.Text =   lblCheck.Text = string.Empty;

            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFrom.Text = txtTo.Text = lblCheck.Text =  cmbCAS.Text = lblTotalBoxes.Text = lblMax.Text = lblMin.Text =          string.Empty;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Unallocated f = new Unallocated();
            f.ShowDialog();
            this.Close();
        }
    }
}
