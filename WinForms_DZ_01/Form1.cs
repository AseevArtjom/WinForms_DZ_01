namespace WinForms_DZ_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str1 = "����� ����";
            string str2 = "15 ���,�.���������";
            string str3 = "����������� ������ ��221";

            int count_of_symbols = str1.Length + str2.Length + str3.Length;
            double average_value = count_of_symbols / 3;

            MessageBox.Show(str1);
            MessageBox.Show(str2);
            MessageBox.Show(str3);
            MessageBox.Show(count_of_symbols + " ��������");
            MessageBox.Show("������� �������� �������� : " + average_value);
        }
    }
}