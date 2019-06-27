using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsProject
{
    public partial class Form1 : Form
    {
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        SqlCommand myCommand = new SqlCommand();
        SqlConnection sqlConnection = new SqlConnection();

        
        public Form1()
        {
            InitializeComponent();

            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ernest O\\source\\repos\\CarsProject\\CarsProject\\CarsDB.mdf; Integrated Security=True;Connect Timeout=30"; 
            myCommand.CommandText = "Select * From CarsDB";
            myCommand.Connection = sqlConnection;
            myAdapter.SelectCommand = myCommand;
            myAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
