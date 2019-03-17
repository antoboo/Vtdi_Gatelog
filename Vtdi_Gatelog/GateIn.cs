using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vtdi_Gatelog
{
    public partial class GateIn : Form
    {
      //  Step 1 intitalize object
      private GateInDatabaseEntities ctx;

        public GateIn()
        {
            InitializeComponent();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {

            txtFirstName.Clear();
            txtLastName.Clear();
            txtLic.Clear();
            txtLic.Clear();
            //LtBxReason 



        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            //get all values from the form interface.                     
            var platenum = txtLic.Text;
            var fname = txtFirstName.Text;               
            var lname = txtLastName.Text;
            var type = cbvehicle.SelectedValue;
            var purpose = cbreason.SelectedValue;
            var items = cbitems.SelectedValue;
            var userinfo = txtUser.Text;
            var recordDateTimeIn = DateTime.Now; // Capturing the time stamp from Computer

            // Step 2 create the object from the database
            ctx = new GateInDatabaseEntities();


            if (String.IsNullOrEmpty(lname) || String.IsNullOrEmpty(platenum))
            {//Validating that the Text Box is not empty

                MessageBox.Show("Platenum or Last Name is empty");

            }
            
            MessageBox.Show($"Name: {fname} {lname} \r\n Plate Number: {platenum} \r\n Car Type: {type}" +
                $"\r\n Item/s Declared  {items}  Reason for Visit: {purpose}");



            //GateIn record = new GateInTable();
            //table that you are about to store data in
            var record = new GateInTable();


            //Populate the fields in the object
            record.FirstName = fname;
            record.LastName = lname;
            record.PlateNum = platenum;
            record.PurposeID = (int) purpose ;
            record.ItemsToDeclareID = Convert.ToInt32(items);
            record.VehicletypesID = (int)type;
            record.DateTimeIn = recordDateTimeIn;
           


            //Add the record to this table
            //In this "object" in this "Table" in row
            ctx.GateInTables.Add(record);
            ctx.SaveChanges();




            MessageBox.Show("Document has been saved");
        }

        private void BTExit_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void GateIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gateInDatabaseDataSet.Vehicletypes' table. You can move, or remove it, as needed.
            this.vehicletypesTableAdapter.Fill(this.gateInDatabaseDataSet.Vehicletypes);
            // TODO: This line of code loads data into the 'gateInDatabaseDataSet.ItemstoDeclare' table. You can move, or remove it, as needed.
            this.itemstoDeclareTableAdapter.Fill(this.gateInDatabaseDataSet.ItemstoDeclare);
            // TODO: This line of code loads data into the 'gateInDatabaseDataSet.Gender' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'gateInDatabaseDataSet.GateInTable' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'gateInDatabaseDataSet.Purpose' table. You can move, or remove it, as needed.
            this.purposeTableAdapter.Fill(this.gateInDatabaseDataSet.Purpose);

            
        }
    }
}
