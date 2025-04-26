using S1131375XAXBGame;

namespace XAXB視窗版
{
    public partial class Form1 : Form
    {
        XAXBEngine engine = new XAXBEngine();
        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        // === 生成物件 ===
        void GenerateSquareButton(int x, int y, int sizeLength, int tabIndex, string name, string text, string tag, EventHandler func, char color='\0', bool enabled=true) // Action 傳入的參數是方法本身
        {
            //Action<object, EventArgs>
            //動態生成按鈕
            Button btn = new Button();

            btn.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn.Location = new Point(x, y);
            btn.Name = name;
            btn.Size = new Size(sizeLength, sizeLength);
            btn.TabIndex = tabIndex;
            btn.Text = text;
            btn.UseVisualStyleBackColor = true;
            btn.Click += func;
            btn.Tag = tag;

            if(color == 'r')
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
            }
            else if(color == 'g')
            {
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
            }

            btn.Enabled = enabled;

            this.Controls.Add(btn);
        }


        // === 用物件生成排版 ===
        void NumberAndOkAndRemoveButton() // 排版數字、確定(OK)、移除(X) 按鈕
        {
            int xWallGap = 75, yWallGap = 195; // 數字按鈕最初始位置 (左上角)
            int sizeLength = 70, gap = 5; // 按鈕邊長、按鈕的間距

            //動態生成按鈕
            int newi=0, newj=0;
            for (int i=0; i<3; i++) // 按鈕 1~9
            {
                for(int j=0; j<3; j++)
                {
                    int x, y, tabIndex;
                    string name, text, tag;

                    x = xWallGap + j * (sizeLength + gap);
                    y = yWallGap + i * (sizeLength + gap);

                    tabIndex = 3 * i + j + 1;
                    name = $"btnNum{i}{j}";
                    text = $"{3 * i + j + 1}";
                    tag = $"{i}{j}";

                    GenerateSquareButton(x, y, sizeLength, tabIndex, name, text, tag, printShow);
                    newj = j;
                }
                newi = i;
            }
            int newX = xWallGap + newj * (sizeLength + gap);
            int newY = yWallGap + newi * (sizeLength + gap);
            // 按鈕 0
            GenerateSquareButton(newX-(gap+sizeLength), newY+(gap+sizeLength), sizeLength, 10, "btnZero", "0", "zero", printShow);
            // 按鈕 OK
            GenerateSquareButton(newX, newY + (gap + sizeLength), sizeLength, 11, "btnRemove", "OK", "OK", printShow, color:'g');
            // 按鈕 X (移除)
            GenerateSquareButton(newX - 2*(gap + sizeLength), newY + (gap + sizeLength), sizeLength, 12, "btnRemove", "X", "X", printShow, color: 'r');
        }
        void DisplayScreen() // 顯示不能按的按鈕，以達到檢視效果
        {
            int screenNum = 4;

            int xWallGap = 12, yWallGap = 75; // 數字按鈕最初始位置 (左上角)
            int sizeLength = 85, gap = 5; // 按鈕邊長、按鈕的間距
            for (int i=0; i<screenNum; i++)
            {
                int x = xWallGap + i*(sizeLength + gap);
                string name = $"screen{i}";

                GenerateSquareButton(x, yWallGap, sizeLength, i, name, "", $"{i}", printShow, enabled:false);
            }
        }

        // === 初始化 & 組合 遊戲物件 ===
        void InitGame()
        {
            NumberAndOkAndRemoveButton();
            DisplayScreen();
        }

        // === 功能 ===
        private void printShow(object sender, EventArgs e)
        {
            MessageBox.Show("HelloWord");
        }
    }
}
