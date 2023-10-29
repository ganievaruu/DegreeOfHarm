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
            { "непродолжительное расстройство здоровья", 1},
            { "стойкая утрата трудоспособности, равная пяти процентам", 1},
            { "отсутствие прямой опасности для жизни потерпевшего", 2},
            { "отсутствие тяжелых состояний", 2},
            { "продолжительное расстройство здоровья", 2},
            { "стойкая утрата трудоспособности", 2},
            { "проникающие раны головы", 3 },
            { "переломы основания черепа и костей свода черепа", 3},
            { "ушибы головного мозга",3 },
            { "проникающие раны позвоночника", 3 },
            { "переломы дуг позвонков шейного отдела", 3 },
            { "односторонние переломы дуг первого и второго позвонков шейного отдела", 3 },
            { "одвывихи и вывихи позвонков шейного отдела", 3 },
            { "перелом-вывих позвонков грудного или поясничного отдела", 3 },
            { "перелом-вывих позвонков поясничного отдела", 3 },
            { "ранения в области шеи с проникновением в гортань", 3 },
            { "ранения в области шеи с проникновением в пищевод", 3 },
            { "ранения в области шеи с проникновением в трахею", 3 },
            { "ранения в области шеи с проникновением в просвет глотки", 3 },
            { "ранения в области груди", 3 },
            { "ранения живота с проникновением в кишечник или в полость мочевого пузыря", 3 },
            { "ранения живота с проникновением в полость мочевого пузыря", 3 },
            { "открытая рана поджелудочной железы", 3 },
            { "открытая рана почек", 3 },
            { "открытая рана надпочечников", 3 },
            { "разрыв любого внутреннего органа", 3 },
            { "двойной перелом кольца таза в задней и передней частях", 3 },
            { "открытый перелом плечевой кости", 3 },
            { "открытый перелом бедренной кости", 3 },
            { "открытый перелом большеберцовой кости", 3 },
            { "нарушение целостности основных кровеносных сосудов", 3 },
            { "термический ожог", 3 },
            { "тяжелый шок третьей степени", 3 },
            { "тяжелый шок четвертой степени", 3 },
            { "кома", 3 },
            { "обширные кровотечения", 3 },
            { "коллапс", 3 },
            { "нарушение кровообращения головного мозга", 3 },
            { "острая сердечная недостаточность", 3 },
            { "острая сосудистая недостаточность", 3 },
            { "острая почечная недостаточность", 3 },
            { "острая печеночная недостаточность", 3 },
            { "тяжелая степень острой дыхательной недостаточности", 3 },
            { "гнойно-септические поражения тканей", 3 },
            { "нарушение кровообращения", 3 },
            { "комплекс нескольких состояний, угрожающих жизни потерпевшего", 3 },
            { "полная слепота на оба глаза", 3 },
            { "снижение остроты зрения до четырех процентов от нормального", 3 },
            { "потеря речи в результате потери голоса", 3 },
            { "потеря возможности изъясняться", 3 },
            { "полная глухота", 3 },
            { "потеря органа", 3 },
            { "стойкое нарушение функционирования органа", 3 },
            { "психические заболевания", 3 },
            { "наркомания, токсикомания", 3 },
            { "общие патологические состояния", 3 },
            { "прерывание беременности на любом этапе", 3 },
            };

            int level = 0;
            string diagnoses = txtDiagnoses.Text; // Значение введенное в TextBox

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
                    lblResult.Text = "Степень вреда здоровью - легкий";
                    break;
                case 2:
                    lblResult.Text = "Степень вреда здоровью - средний";
                    break;
                case 3:
                    lblResult.Text = "Степень вреда здоровью - тяжелый";
                    break;
                default:
                    lblResult.Text = "Такого диагноза нет!";
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