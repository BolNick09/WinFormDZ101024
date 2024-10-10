namespace Form_DZ_1
{
    public partial class DZForm : Form
    {
        public DZForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Int32.TryParse(tbNumber.Text, out int a);
        }

        private void btnShowResume_Click(object sender, EventArgs e)
        {
            btnShowResume.Enabled = false;
            showResume();
            btnShowResume.Enabled = true;
        }

        private void btnGuessNum_Click(object sender, EventArgs e)
        {
            btnGuessNum.Enabled = false;
            guessNum();
            btnGuessNum.Enabled = true;
        }

        private void showResume()
        {
            DialogResult dialogResult = new();
            dialogResult = MessageBox.Show("Большаков Никита Андреевич", "Первая часть резюме", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                dialogResult = MessageBox.Show("15.07.1997", "Вторая часть резюме", MessageBoxButtons.OKCancel);
            else
                return;
            MessageBox.Show("Системный программист", "Третья часть резюме", MessageBoxButtons.OK);
            return;

        }
        private void guessNum()
        {
            int userNum;
            if (Int32.TryParse(tbNumber.Text, out userNum) == false)
                return;
            if (userNum < 0 || userNum > 2000)
                return;

            int count = 0;
            int leftBorder = 0;
            int rightBorder = 2000;
            
            int guessedNum = (leftBorder + rightBorder) / 2;
            do
            {
                count++;
                if (guessedNum > userNum)                    
                    rightBorder = guessedNum;
                else
                    leftBorder = guessedNum;
                guessedNum = (leftBorder + rightBorder) / 2;
            }
            while (guessedNum != userNum);

            MessageBox.Show($"Число пользователя - {userNum} Ответ найден за {count} шагов");
        }

       
    }
}
