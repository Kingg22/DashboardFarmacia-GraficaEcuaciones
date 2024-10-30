using System.Data;

namespace FarmaRey
{
    public partial class FrmSelectData : Form
    {
        public List<object> SelectedItems = new List<object>();

        public FrmSelectData(Object data)
        {
            InitializeComponent();
            // Añadir los datos
            dgvData.DataSource = data;
            // Hacer de solo lectura los datos
            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.ReadOnly = true;
            }
            // Añadir una columna para seleccionar
            dgvData.Columns.Add(new DataGridViewCheckBoxColumn {
                Name = "Select", 
                HeaderText = "Selccionar", 
                TrueValue = true, 
                FalseValue = false, 
                ReadOnly = false
            });
            // Si tiene columna de Id no hacerlo visible
            if (dgvData.Columns.Contains("Id"))
            {
                dgvData.Columns["Id"].Visible = false;
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            // Devolver una lista con los items seleccionado
            SelectedItems = dgvData.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Select"].Value))
                .Select(row => row.Cells["Id"].Value)
                .ToList();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
