namespace DegreeOfHarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myCollection = new Dictionary<string, int>()
            {
            { "����������������� ������������ ��������", 1},
            { "������� ������ ����������������, ������ ���� ���������", 1},
            { "���������� ������ ��������� ��� ����� ������������", 2},
            { "���������� ������� ���������", 2},
            { "��������������� ������������ ��������", 2},
            { "������� ������ ����������������", 2},
            { "����������� ���� ������", 3 },
            { "�������� ��������� ������ � ������ ����� ������", 3},
            { "����� ��������� �����",3 },
            { "����������� ���� ������������", 3 },
            { "�������� ��� ��������� ������� ������", 3 },
            { "������������� �������� ��� ������� � ������� ��������� ������� ������", 3 },
            { "�������� � ������ ��������� ������� ������", 3 },
            { "�������-����� ��������� �������� ��� ����������� ������", 3 },
            { "�������-����� ��������� ����������� ������", 3 },
            { "������� � ������� ��� � �������������� � �������", 3 },
            { "������� � ������� ��� � �������������� � �������", 3 },
            { "������� � ������� ��� � �������������� � ������", 3 },
            { "������� � ������� ��� � �������������� � ������� ������", 3 },
            { "������� � ������� �����", 3 },
            { "������� ������ � �������������� � �������� ��� � ������� �������� ������", 3 },
            { "������� ������ � �������������� � ������� �������� ������", 3 },
            { "�������� ���� ������������� ������", 3 },
            { "�������� ���� �����", 3 },
            { "�������� ���� �������������", 3 },
            { "������ ������ ����������� ������", 3 },
            { "������� ������� ������ ���� � ������ � �������� ������", 3 },
            { "�������� ������� �������� �����", 3 },
            { "�������� ������� ��������� �����", 3 },
            { "�������� ������� �������������� �����", 3 },
            { "��������� ����������� �������� ����������� �������", 3 },
            { "����������� ����", 3 },
            { "������� ��� ������� �������", 3 },
            { "������� ��� ��������� �������", 3 },
            { "����", 3 },
            { "�������� ������������", 3 },
            { "�������", 3 },
            { "��������� �������������� ��������� �����", 3 },
            { "������ ��������� ���������������", 3 },
            { "������ ���������� ���������������", 3 },
            { "������ �������� ���������������", 3 },
            { "������ ���������� ���������������", 3 },
            { "������� ������� ������ ����������� ���������������", 3 },
            { "������-����������� ��������� ������", 3 },
            { "��������� ��������������", 3 },
            { "�������� ���������� ���������, ���������� ����� ������������", 3 },
            { "������ ������� �� ��� �����", 3 },
            { "�������� ������� ������ �� ������� ��������� �� �����������", 3 },
            { "������ ���� � ���������� ������ ������", 3 },
            { "������ ����������� �����������", 3 },
            { "������ �������", 3 },
            { "������ ������", 3 },
            { "������� ��������� ���������������� ������", 3 },
            { "����������� �����������", 3 },
            { "����������, ������������", 3 },
            { "����� �������������� ���������", 3 },
            { "���������� ������������ �� ����� �����", 3 },
            };

            int level = 0;
            string diagnoses = txtDiagnoses.Text; // �������� ��������� � TextBox

            var diagnosesList = diagnoses.Split(';');

            foreach (var diag in diagnosesList)
            {
                foreach (var di in myCollection)
                {
                    if (diag == di.Key)
                    {
                        if (di.Value > level)
                        {
                            level = di.Value;
                        }
                    }
                }
            }

            switch (level)
            {
                case 1:
                    lblResult.Text = "������� ����� �������� - ������";
                    break;
                case 2:
                    lblResult.Text = "������� ����� �������� - �������";
                    break;
                case 3:
                    lblResult.Text = "������� ����� �������� - �������";
                    break;
                default:
                    lblResult.Text = "������ �������� ���!";
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}