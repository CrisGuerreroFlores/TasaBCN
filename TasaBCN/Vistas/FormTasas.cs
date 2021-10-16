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
using System.Xml.Serialization;
using TasaBCN.Model;
using TasaBCN.tasaBCN_Services;
using TasaBCN.XMLModel;

namespace TasaBCN.Vistas
{
    public partial class FormTasas : Form
    {
        public FormTasas()
        {
            InitializeComponent();
        }

        private async void FormTasas_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 9; i++)
            {
                var year = DateTime.Today.AddYears((i * -1)).Year;
                cb_anio.Items.Add(year);
            }

             cb_anio.SelectedIndex = 0;
             cb_mes.SelectedIndex = DateTime.Today.Month - 1;

            cb_anio.SelectedIndexChanged += cb_anio_SelectedIndexChanged;
            cb_mes.SelectedIndexChanged += cb_mes_SelectedIndexChanged;


            await GetDataMonth();
        }

        #region LoadTasaMes
        private async Task GetDataMonth()
        {
            using(var bcn = new Tipo_Cambio_BCNSoapClient())
            {
                int.TryParse(cb_anio.Text, out int year);

                var results = await bcn.RecuperaTC_MesAsync(year, cb_mes.SelectedIndex + 1);
                var xmlSerializer = new XmlSerializer(typeof(TasasBCN));

                using(var ms = new MemoryStream(Encoding.UTF8.GetBytes(results.Body.RecuperaTC_MesResult.ToString())))
                {
                    var resultDeserializer = xmlSerializer.Deserialize(ms) as TasasBCN;
                    var binding = new BindingList<Tasa>(resultDeserializer?.TasasCambio);

                    dgv_tasasCambio.DataSource = binding.OrderBy(t => t.Day).ToList();
                }
            }
        }
        #endregion

        private async void cb_anio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidateDate())
            {
                await GetDataMonth();
            }
        }

        private async void cb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidateDate())
            {
                await GetDataMonth();
            }
        }
        private bool ValidateDate()
        {
            int.TryParse(cb_anio.Text, out int year);

            bool result = new DateTime(year, cb_mes.SelectedIndex + 1, 1) < DateTime.Now;

            if (!result)
            {
                MessageBox.Show("Aún no hay registros para ese mes");
            }

            return result;
        }

        private async void btn_Generar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
