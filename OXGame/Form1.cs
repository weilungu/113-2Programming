using System.Diagnostics.Metrics;

namespace OXGame
{
    public partial class Form1 : Form
    {
        OXGameEngine oxEngine = new OXGameEngine();
        Button[,] oxButtons = new Button[3,3];

        string playerMarker = "X";
        int counter = 0;
        public Form1()
        {
            InitializeComponent();

            InitGame();
        }


        private void InitGame()
        {
            // �ʺA�ͦ����s *9
            for(int i=0; i<oxButtons.GetLength(0); i++) // ���� 1~9 �����s
            {
                for(int j=0;  j<oxButtons.GetLength(1); j++)
                {
                    Button btn = new Button();

                    btn.Font = new Font("Microsoft JhengHei UI", 22.2F);
                    btn.Location = new Point(40 + i*130, 40 + j*130);
                    btn.Name = "button" + i + j;
                    btn.Size = new Size(120, 120);
                    btn.TabIndex = 3 * i + j + 1;
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += button1_Click;

                    // ���O���s��������m�]x,y�^
                     btn.Tag = string.Format("{0},{1}", i, j);

                    this.Controls.Add(btn);
                    oxButtons[i, j] = btn;
                }
            }

            // ���ͫ��s 0

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //if(btn.Text != "") // �קK�U�ĤG��
            //{
            //    return;
            //}

            // ���O���s��������m�]x,y�^
            //btn.Tag = String.Format("{0},{1}", i, j);

            string[] xyPos = ((string)btn.Tag).Split(',');
            int x = int.Parse(xyPos[0]);
            int y = int.Parse(xyPos[1]);

            if( !oxEngine.IsValidMove(x, y) ) // �Y���O�X�k����
            {
                MessageBox.Show("Wrong Moving", "Wrong Moving");
                return;
            }

            oxEngine.SetMarker(x, y, playerMarker[0]);

            btn.Text = playerMarker;
            playerMarker = playerMarker == "X" ? "O" : "X";
            nextMarker.Text = playerMarker;
            //counter++;

            CheckWinner();
        }

        private void CheckWinner()
        {
            char winner = oxEngine.IsWinner();

            if(winner == ' ') return;
            MessageBox.Show($"Winner is {winner}", "Game Over");
        }



        //private void CheckWinner()
        //{
        //    string winnerCaption = "Winner is...";

        //    if(button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
        //    {// ��u�O�_��Ĺ�a
        //        MessageBox.Show(button1.Text, winnerCaption);
        //    }
        //    else if(button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
        //    {
        //        MessageBox.Show(button4.Text, winnerCaption);
        //    }
        //    else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
        //    {
        //        MessageBox.Show(button7.Text, winnerCaption);
        //    }
        //    else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
        //    {// ���u�O�_��Ĺ�a
        //        MessageBox.Show(button1.Text, winnerCaption);
        //    }
        //    else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
        //    {
        //        MessageBox.Show(button2.Text, winnerCaption);
        //    }
        //    else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
        //    {
        //        MessageBox.Show(button3.Text, winnerCaption);
        //    }
        //    else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
        //    {// �﨤�u�O�_��Ĺ�a
        //        MessageBox.Show(button1.Text, winnerCaption);
        //    }
        //    else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
        //    {
        //        MessageBox.Show(button3.Text, winnerCaption);
        //    }
        //    else if(counter == 9)
        //    {
        //        MessageBox.Show("����", "Tie");
        //    }
        //}
    }
}
