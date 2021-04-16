using Ejemplo.Filtro.ComboxResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SQLite;
using Ejemplo.Filtro.TablasConstantes;
using Ejemplo.Filtro.DTOS;
using Ejemplo.Filtro.Constantes;

namespace Ejemplo.Filtro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // para llenar el combo box 
            
        }

        private async  void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(ComboxFilterOptions.GetValue.ToArray());
            comboBox1.SelectedIndex = 0;
            using(var db = new SQLiteConnection(ConnectionString.Value))
            {
                var sqlQuery = new StringBuilder();
                sqlQuery.Append($"SELECT * FROM {TableConstants.DIRECTORIO}");
                dataGridView1.DataSource   = (await db.QueryAsync<DirectorioDTO>(sqlQuery.ToString())).ToList();
            }
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var db = new SQLiteConnection(ConnectionString.Value))
            {
                var sqlQuery = new StringBuilder();
                sqlQuery.Append($"SELECT * FROM {TableConstants.DIRECTORIO} Where {comboBox1.SelectedItem} LIKE @param ");
                var f = sqlQuery.ToString();
                dataGridView1.DataSource = (await db.QueryAsync<DirectorioDTO>(sqlQuery.ToString(),new { param = $"%{textBox1.Text}%"})).ToList();
            }
        }
    }
}
