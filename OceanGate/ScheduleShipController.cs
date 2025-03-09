using BLL;
using DAL;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class ScheduleShipController : UserControl
    {
        private LogManager _logManager;

        private BLL.PortManager portManager = new BLL.PortManager();
        private BLL.ShipManager shipManager = new BLL.ShipManager();

        public ScheduleShipController()
        {
            InitializeComponent();
        }

        private void ScheduleShipController_Load(object sender, EventArgs e)
        {
            LoadPorts();
            LoadShips();
        }

        private void LoadPorts()
        {
            try
            {
                var portsList = portManager.GetPorts();
                cmbPort.DisplayMember = "PortName"; // Portların isimlerini ComboBox'ta göstermek için
                cmbPort.ValueMember = "PortID"; // Seçilen portun ID'sini almak için
                cmbPort.DataSource = portsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Portları yükleme işlemi sırasında hata oluştu: {ex.Message}");
            }
        }

        private void LoadShips()
        {
            try
            {
                var shipsList = shipManager.GetShips();
                cmbShip.DisplayMember = "ShipName"; 
                cmbShip.ValueMember = "ShipID"; 
                cmbShip.DataSource = shipsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Shipleri yükleme işlemi sırasında hata oluştu: {ex.Message}");
            }
        }
        


        private void btnAddMovement_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPortId = (int)cmbPort.SelectedValue;
                var selectedShipId = (int)cmbShip.SelectedValue;
                var arrivalDate = dtpArrivalDate.Value;
                var departureDate = dtpDepartureDate.Value;

                // Burada ShipMovements tablosuna kayıt işlemini gerçekleştirirsiniz.
                ShipMovements newMovement = new ShipMovements
                {             
                    PortID = selectedPortId,
                    ShipID = selectedShipId,
                    ArrivalDate = arrivalDate,
                    DepartureDate = departureDate
                };

                using (var context = new OceanGateDBEntities())
                {
                    context.ShipMovements.Add(newMovement);
                    context.SaveChanges();
                }

                MessageBox.Show("Gemi hareketi başarıyla kaydedildi.");
                //_logManager.LogAction("Bir Gemi Harekete Geçti : " , "Ships");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gemi hareketini kaydetme işlemi sırasında hata oluştu: {ex.Message}");
            }
        }

        private void btnListMovements_Click(object sender, EventArgs e)
        {

            try
            {
                var bll = new ShipManager(); // BLL'den instance al
                var shipMovements = bll.GetShipMovements(); // Verileri çek

                dgvMovements.DataSource = shipMovements; // DataGridView'e bağla

                CustomizeDataGridView(); // Veri bağlandıktan sonra özelleştirme yap
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gemi hareketlerini listeleme sırasında hata oluştu: {ex.Message}");
            }
        }

        private void CustomizeDataGridView()
        {
            if (dgvMovements.Columns.Count > 0)
            {
                dgvMovements.Columns["MovementID"].HeaderText = "Hareket ID";
                dgvMovements.Columns["ShipName"].HeaderText = "Gemi Adı";
                dgvMovements.Columns["PortName"].HeaderText = "Liman Adı";
                dgvMovements.Columns["ArrivalDate"].HeaderText = "Varış Tarihi";
                dgvMovements.Columns["DepartureDate"].HeaderText = "Ayrılış Tarihi";

                dgvMovements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}

   

   

