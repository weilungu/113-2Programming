namespace 計時器
{
    public partial class Form1 : Form
    {
        int counter;
        public Form1()
        {
            InitializeComponent();

            counter = 100; // 設定計時時間

            timer1.Interval = 1000; // 時間間隔為 1000 毫秒 = 1 秒
        }

        private void btn_start_Click(object sender, EventArgs e) // 當按了開始按鈕後
        {
            timer1.Start(); // 開始計時
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            lb_displayTime.Text = counter.ToString();

            if(counter <= 0) // 當計時器的值 <= 0 時
            {
                timer1.Stop(); // 停止計時
                counter = 100;
                lb_displayTime.Text = counter.ToString(); // 重新校正顯示時間的標籤

                MessageBox.Show(text: "時間到", caption: "時間到"); // 提醒時間到
            }
        }
    }
}
