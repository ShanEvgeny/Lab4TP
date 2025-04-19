namespace Лаб4ТП
{
    public partial class Form1 : Form
    {
        List<Drink> drinksList = new List<Drink>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear();
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                switch (random.Next() % 3)
                {
                    case 0:
                        this.drinksList.Add(Juice.Generate());
                        break;
                    case 1:
                        this.drinksList.Add(Soda.Generate());
                        break;
                    case 2:
                        this.drinksList.Add(Alcohol.Generate());
                        break;
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            int juicesCount = 0;
            int sodaCount = 0;
            int alcoholCount = 0;
            int number = 1;
            var queue = "";
            foreach (var drink in this.drinksList)
            {
                if (drink is Juice)
                {
                    juicesCount++;
                    queue += number + ". Сок\n";
                }
                else if (drink is Soda)
                {
                    sodaCount++;
                    queue += number + ". Газировка\n";
                }
                else if (drink is Alcohol)
                {
                    alcoholCount++;
                    queue += number + ". Алкоголь\n";
                }
                number++;
            }
            txtInfo.Text = "Сок\tГазир\tАлкоголь";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", juicesCount, sodaCount, alcoholCount);
            txtQueue.Text = queue;
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.drinksList.Count == 0)
            {
                txtOut.Text = "Автомат пуст";
                return;
            }
            var drink = this.drinksList[0];
            this.drinksList.RemoveAt(0);
            txtOut.Text = drink.GetInfo();
            ShowInfo();
        }
    }
}