using Reporter.BUS;
using Reporter.UI.components;
using Reporter.UI.Components;

namespace Reporter.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bang1.Instance.SetupDataGridView(dgvBaoCao);
            Bang2.Instance.SetupBang2(dgvKetQuaNoiTru);
            Bang3.Instance.SetupBang3(dgvKetQuaThucHienDV);
            Bang4.Instance.SetupBang4(dgvSoLieuKhoaKhamBenh);
        }

    }
}

