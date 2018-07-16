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


namespace AdoPart22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string _insertQuery = "";
        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            var _connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Emin\source\repos\AdoPart22\AdoPart22\Data\sample.mdf; Integrated Security = True";
            var _connect = new SqlConnection(_connectionString);
            _connect.Open();
            var _categoryName = CategoryNameBox.Text;

            _insertQuery = "INSERT INTO Category(name) VALUES('" + _categoryName + "')";
            var _insertCommand = new SqlCommand(_insertQuery, _connect);
            if (_insertCommand.ExecuteNonQuery() == 1);
            {
                MessageBox.Show("New category added");
            }
            _connect.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var _connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Emin\source\repos\AdoPart22\AdoPart22\Data\sample.mdf; Integrated Security = True";
            var _connect = new SqlConnection(_connectionString);
            _connect.Open();

            var selectQuery = "SELECT * FROM Category";

            var da = new SqlDataAdapter(selectQuery, _connect);

            var ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                textBox1.Text += item["name"] + "." + item["id"] + "\r\n";
                ProductCategoryBox.Items.Add(item["name"]);
            }


        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            var _ProductName = ProductNameBox.Text;
            var _ProductPrice = Convert.ToInt32(ProductPriceBox.Text);
            var _ProductCategory = ProductCategoryBox.SelectedItem;

            var _connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Emin\source\repos\AdoPart22\AdoPart22\Data\sample.mdf; Integrated Security = True";
            var _connect = new SqlConnection(_connectionString);
            _connect.Open();
            _insertQuery = "INSERT INTO Product(name,ProductPrice,CategoryId)" +
                "VALUES('" + _ProductName + "'," + _ProductPrice + ",(SELECT id FROM Category WHERE name='" + _ProductCategory + "'))";

            var command = new SqlCommand(_insertQuery, _connect);
            command.ExecuteNonQuery();

        }

        private void CategoryNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
