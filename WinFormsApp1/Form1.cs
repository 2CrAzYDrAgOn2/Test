namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int rightAnswers, counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 0:
                    counter++;
                    if (radioButton2.Checked)
                    {
                        MessageBox.Show("������ �����!");
                        rightAnswers++;
                        label2.Text = $"���������� ���������� �������: {rightAnswers}";
                    }
                    else
                    {
                        MessageBox.Show("�������� �����!");
                    }
                    label1.Text = "��������� ������";
                    radioButton1.Text = "�������� �����";
                    radioButton2.Text = "�������� �����";
                    radioButton3.Text = "������ �����";
                    break;

                case 1:
                    counter++;
                    if (radioButton3.Checked)
                    {
                        MessageBox.Show("������ �����!");
                        rightAnswers++;
                        label2.Text = $"���������� ���������� �������: {rightAnswers}";
                    }
                    else
                    {
                        MessageBox.Show("�������� �����!");
                    }
                    label1.Text = "������ ������";
                    radioButton1.Text = "������ �����";
                    radioButton2.Text = "�������� �����";
                    radioButton3.Text = "�������� �����";
                    break;

                case 2:
                    counter++;
                    if (radioButton1.Checked)
                    {
                        MessageBox.Show("������ �����!");
                        rightAnswers++;
                        label2.Text = $"���������� ���������� �������: {rightAnswers}";
                    }
                    else
                    {
                        MessageBox.Show("�������� �����!");
                    }
                    MessageBox.Show($"�� ������ ���� ���������. �����������! ���������� ���������� �������: {rightAnswers}");
                    break;

                default:
                    MessageBox.Show("�� ��� ������ ����!");
                    break;
            }
        }
    }
}