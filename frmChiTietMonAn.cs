using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Project
{
    public partial class frmChiTietMonAn : Form
    {
        frmDanhSachMonAn a = new frmDanhSachMonAn();
        string loiKhuyen_1 = "Hạn chế thực phẩm chứa quá nhiều chất" +
            " béo cũng là một cách để bạn duy trình ổn định cân nặng của cơ thể. " +
            "Giảm thiểu những bệnh liên quan đến tim mạch. " +
            "Thay thế dầu động vật bằng dầu thực vật cũng là " +
            "một cách để giảm việc dùng quá nhiều chất béo.";
        string loiKhuyen_2 = "Người lao động chân tay hoặc vận " +
            "động viên sẽ cần nhiều calo hơn người làm việc văn" +
            " phòng hoặc không làm việc. Người lớn tuổi sẽ cần ít " +
            "calo hơn người trẻ.";
        string loiKhuyen_3 = "Trong dinh dưỡng, Calo là đơn vị dùng để" +
            " đo năng lượng bạn hấp thụ vào từ thức ăn để duy trì hoạt " +
            "động của cơ thể. Nguồn năng lượng này duy trì hơi thở, não " +
            "bộ, nhịp tim và các hoạt động khác của cơ thể.  Tất cả các " +
            "loại thức ăn hàng ngày đều chứa một lượng calo nhất định.";
        string loiKhuyen_4 = "Chắc hẳn bạn đã từng thắc mắc tại sao có " +
            "người gọi là Calo, có người gọi là Kcal rồi đúng không! Trên" +
            " thực thế: Calo = Kcal. Ở Anh mọi người thường dùng Kcal hơn;" +
            " ở Việt Nam, Mỹ và một số nước khác thì dùng từ Calo. Hãy " +
            "ăn uống điều độ bạn nhé <3";
        string loiKhuyen_5 = "Ăn đúng lượng calo phù hợp với hoạt động hằng " +
            "ngày của bạn, điều này giúp cân bằng năng lượng đưa vào và " +
            "năng lượng tiêu hao. Nếu bạn ăn hay uống quá nhiều, bạn sẽ tăng cân." +
            " Ngược lại, nếu ăn uống ít bạn sẽ giảm cân. Các chuyên gia khuyên rằng " +
            "nam giới cần khoảng 2.500 calo mỗi ngày, phụ nữ cần khoảng 2000 calo." +
            " Một bộ phận lớn những người trưởng thành ăn nhiều calo hơn mức cần thiết," +
            " trong khi họ nên ăn ít hơn.";
        string loiKhuyen_6 = "Ăn đa dạng các loại thức ăn để đảm bảo chế" +
            " độ ăn uống cân bằng và cơ thể nhận được tất cả các chất dinh" +
            " dưỡng cần thiết.";
        List<string> LoiKhuyen = new List<string>();
        Random r = new Random();
        public frmChiTietMonAn()
        {
            InitializeComponent();
            LoiKhuyen.Add(loiKhuyen_1);
            LoiKhuyen.Add(loiKhuyen_2);
            LoiKhuyen.Add(loiKhuyen_3);
            LoiKhuyen.Add(loiKhuyen_4);
            LoiKhuyen.Add(loiKhuyen_5);
            LoiKhuyen.Add(loiKhuyen_6);
        }

        private void frmChiTietMonAn_Load(object sender, EventArgs e)
        {
            PrepareData();
        }
        private void PrepareData()
        {
            lblMon.Text = "Món : " + a.tenMon;
            lblCalo.Text = "Tổng số calo : " + a.calo;
            lblNhomMon.Text = "Thuộc loại món : " + a.nhomMon;
            txtLoiKhuyen.Text = LoiKhuyen[r.Next(0,6)];
        }
    }
}
