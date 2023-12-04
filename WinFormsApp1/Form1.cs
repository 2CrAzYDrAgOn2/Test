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
                        MessageBox.Show("Верный ответ!");
                        rightAnswers++;
                        label2.Text = $"Количество правильных ответов: {rightAnswers}";
                    }
                    else
                    {
                        MessageBox.Show("Неверный ответ!");
                    }
                    label1.Text = "Следующий вопрос";
                    radioButton1.Text = "Неверный ответ";
                    radioButton2.Text = "Неверный ответ";
                    radioButton3.Text = "Верный ответ";
                    break;

                case 1:
                    counter++;
                    if (radioButton3.Checked)
                    {
                        MessageBox.Show("Верный ответ!");
                        rightAnswers++;
                        label2.Text = $"Количество правильных ответов: {rightAnswers}";
                    }
                    else
                    {
                        MessageBox.Show("Неверный ответ!");
                    }
                    label1.Text = "Третий вопрос";
                    radioButton1.Text = "Верный ответ";
                    radioButton2.Text = "Неверный ответ";
                    radioButton3.Text = "Неверный ответ";
                    break;

                case 2:
                    counter++;
                    if (radioButton1.Checked)
                    {
                        MessageBox.Show("Верный ответ!");
                        rightAnswers++;
                        label2.Text = $"Количество правильных ответов: {rightAnswers}";
                    }
                    else
                    {
                        MessageBox.Show("Неверный ответ!");
                    }
                    MessageBox.Show($"Вы прошли тест полностью. Поздравляем! Количество правильных ответов: {rightAnswers}");
                    break;

                default:
                    MessageBox.Show("Вы уже прошли тест!");
                    break;
            }
        }
    }
}