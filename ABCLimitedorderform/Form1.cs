using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//The namespace is used to organise code into logical groups and prevents name collisions, especially using multiple libraries
//The partial section allows the classes to be split. The class can be spread to separate files, allowing programmers to work on it
//At the same time

namespace ABCLimitedorderform
{
    //Public is a permissive class, no restrictions meaning that any class or types can access this
    public partial class Form1 : Form
    {
        //Datatable resprsenting one table of in-memory data. then using a string to specify the table name
        DataTable dtOrders;
        //Streamreader implements a textreader and from there, reads the characters.Then uses a string to initialise a new instance
        StreamReader sr;

        // This section of code writes a CSV file. the two lines shown below are two ways to do this
        //
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Orders\\orders.csv";
        string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Orders";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //If statment where if the directory does not existm it will create a new one
            dtLoad();
            if (!Directory.Exists(directory))
            {

                var mydir = Directory.CreateDirectory(directory);
            }
            //Another if statment where if the file does not exists, it will create a new new file name 'filepath'
            if (!File.Exists(filepath))
            {
                var myfile = File.Create(filepath);
                myfile.Close();
            }
            //Statment where if the file does not exist, a pop message will show
            if (new FileInfo(filepath).Length == 0)
            {
                MessageBox.Show("please add records to your csv file");
                Application.Exit();
            }
            else
            //Else statment wher if there is data in the file, it will output the data
            {
                populate();
                tbload();
            }
        }
        //when the application loads, it will call this function.
        private void dtLoad()
        {
            dtOrders = new DataTable();
            //If there is no coloums when the application loads, it will populate new coloums and will specify the datatype.
            if (dtOrders.Columns.Count == 0)
            {
                dtOrders.Columns.Add("orderNo").DataType = typeof(UInt32);
                dtOrders.Columns.Add("customerid").DataType = typeof(UInt32);
                dtOrders.Columns.Add("productname");
                dtOrders.Columns.Add("productprice").DataType = typeof(UInt32);
                dtOrders.Columns.Add("quantity").DataType = typeof(UInt32);
            }
        }
        //
        private void populate()
        {
            sr = new StreamReader(filepath, true);

            while (sr.Peek() >= 0)
            {
                // this section reads the line and trims the end comma
                string line = sr.ReadLine();
                line = line.TrimEnd(',');
                string[] fields = line.Split(',');

                // This section will create a new row and then assigns new data to that row 'Orderno'
                var newRow = dtOrders.NewRow();

                newRow["orderNo"] = fields[0];
                newRow["customerid"] = fields[1];
                newRow["productname"] = fields[2];
                newRow["productprice"] = fields[3];
                newRow["quantity"] = fields[4];
                dtOrders.Rows.Add(newRow);
                UInt32[] listItems = dtOrders.AsEnumerable().Select(r => r.Field<uint>("orderNo")).ToArray();
                LbList.DataSource = listItems;
            }
            sr.Close();

        }

        private void tbload()
        {
            tblOrderNo.Text = dtOrders.Rows[0][0].ToString();
            tblCustomerId.Text = dtOrders.Rows[0][1].ToString();
            tblProductName.Text = dtOrders.Rows[0][2].ToString();
            TblPrice.Text = dtOrders.Rows[0][3].ToString();
            TblQuantity.Text = dtOrders.Rows[0][4].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}