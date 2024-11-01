using GraficaFuncionesMath;
using Microsoft.Extensions.DependencyInjection;

namespace FarmaRey
{
    public partial class FrmInicio : Form
    {
        private readonly IServiceProvider serviceProvider;

        public FrmInicio(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void btnEnun1_Click(object sender, EventArgs e)
        {
            FrmDashboard form = serviceProvider.GetRequiredService<FrmDashboard>();
            form.ShowDialog();
        }

        private void btnEnun2_Click(object sender, EventArgs e)
        {
            FrmGraficadora form = new();
            form.ShowDialog();
        }
    }
}
