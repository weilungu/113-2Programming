using S1131375XAXBGame;

namespace XAXB視窗版
{
    public partial class Form1 : Form
    {
        XAXBEngine engine = new XAXBEngine();
        Button[] numric, screen, keys;

        int counter, screenNum;
        string luckyNum;
        public Form1()
        {
            screenNum = engine.GetGuessNum;
            luckyNum = engine.GetLuckyNumber();

            screen = new Button[screenNum];
            numric = new Button[10];
            keys = new Button[2]; // 0=X ; 1=OK;

            counter = 0;

            InitializeComponent();
            InitGame();
        }

        // === 生成物件 ===
        object GenerateSquareButton(int x, int y, int sizeLength, int tabIndex, string name, string text, string tag, EventHandler func, char color='\0', bool enabled=true) // Action 傳入的參數是方法本身
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

            return btn;
        }


        // === 用物件生成排版 ===
        void NumericKeypad() // 排版數字、確定(OK)、移除(X) 按鈕
        {
            int xWallGap = 75, yWallGap = 195; // 數字按鈕最初始位置 (左上角)
            int sizeLength = 70, gap = 5; // 按鈕邊長、按鈕的間距

            //動態生成按鈕
            int newi=0, newj=0;
            int nIndex = 1;
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

                    numric[nIndex] = (Button)GenerateSquareButton(x, y, sizeLength, tabIndex, name, text, tag, DisplayToScreen);
                    nIndex++;
                    
                    newj = j;
                }
                newi = i;
            }
            int newX = xWallGap + newj * (sizeLength + gap);
            int newY = yWallGap + newi * (sizeLength + gap);
            // 按鈕 0
            numric[0] = (Button)GenerateSquareButton(newX-(gap+sizeLength), newY+(gap+sizeLength), sizeLength, 0, "btnZero", "0", "zero", DisplayToScreen);

            // 按鈕 X (移除)
            keys[0] = (Button)GenerateSquareButton(newX - 2 * (gap + sizeLength), newY + (gap + sizeLength), sizeLength, 11, "btnRemove", "X", "X", RemoveToScreen, color: 'r');
            // 按鈕 OK
            keys[1] = (Button)GenerateSquareButton(newX, newY + (gap + sizeLength), sizeLength, 12, "btnRemove", "OK", "OK", SubmitResult, color:'g');
        
            keys[0].Enabled = false;
            keys[1].Enabled = false;
        }
        void ViewScreen() // 顯示不能按的按鈕，以達到檢視效果
        {
            int screenNum = engine.GetGuessNum;

            int xWallGap = 12, yWallGap = 75; // 數字按鈕最初始位置 (左上角)
            int sizeLength = 85, gap = 5; // 按鈕邊長、按鈕的間距
            for (int i=0; i<screenNum; i++)
            {
                int x = xWallGap + i*(sizeLength + gap);
                string name = $"screen{i}";

                screen[i] = (Button)GenerateSquareButton(x, yWallGap, sizeLength, i, name, "", $"{i}", Empty, enabled:false);
            }

        }
        void Test() // 測試用
        {
            int[] size = new int[] { 400, 600 };
            int x = size[0], y = size[1];
            GenerateSquareButton(x / 2 - 100 / 2, 0, 100, 100, "test", "測試用", "test", Test); // 測試用
        }

        // === 初始化 & 組合 遊戲物件 ===
        void InitGame()
        {
            NumericKeypad();
            ViewScreen();
            Test();
        }

        // === 功能 ===
        void Empty(object sender, EventArgs e)
        {

        } // 空的
        void Test(object sender, EventArgs e) // 測試用
        {
            Button btn = (Button)sender;
            btn.Text = luckyNum;
        }

        void DisplayToScreen(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string text = btn.Text;
            screen[counter].Text = text;

            counter++;
            btn.Enabled = false;

            if (engine.isFilled(counter))
            {
                for (int i = 0; i < numric.Length; i++)
                {
                    numric[i].Enabled = false;
                }
            }
            keys[0].Enabled = (text != ""); // 當 text = 0~9 時，X 的按紐會被開啟

            string playerGuess = null;
            foreach (Button i in screen)
            {
                playerGuess += i.Text;
            }
            keys[1].Enabled = engine.IsLegal(playerGuess); // 當 營幕按紐是滿的， OK 按鈕被開啟
        } // 把數字按紐顯示到螢幕按鈕上
        void RemoveToScreen(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int index = counter - 1; // 被填上螢幕的數字的位置，當全部為空， index = -1
            int screenNum = int.Parse(screen[index].Text);
            bool screenNotEmpty = $"{screenNum}" != "";
            bool isAllEmpty = true;

            // btn 代表已經按下去才能作用，keys[0] 代表它會先檢查，兩者同樣是 X 按紐
            keys[0].Enabled = index > 0; // 當螢幕是全空的，index = -1
            if (screenNotEmpty) // "X" 的運作
            {
                screen[index].Text = "";
                counter--;
            }

            if (!engine.isFilled(counter)) // 如果螢幕按鈕不是滿的
            {
                keys[1].Enabled = false; // 把 OK 按鈕關閉
                for(int i = 0; i < numric.Length; i++) // 把所有數字按鈕打開
                {
                    numric[i].Enabled = true;
                }
                foreach(Button i in screen) // 然後把那些在螢幕上的數字按鈕關閉
                {
                    if(i.Text != "")
                    {
                        int t = int.Parse(i.Text);
                        numric[t].Enabled = false;
                    }
                }
            }
        } // 把數字從螢幕按鈕移除
        void SubmitResult(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string playerGuess = null;
            foreach(Button i in screen)
            {
                playerGuess += i.Text;
            }

            if(engine.IsGameover(playerGuess)) // 贏的情況
            {
                MessageBox.Show("你贏了!恭喜", "you win!");
                //btn.Font = "Microsoft JhengHei UI, 7.8pt";

                // 改變字體大小、字的顯示
                btn.Font = new Font("Microsoft JhengHei UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
                btn.Text = "你贏了!\n恭喜";

                foreach(Button i in keys) // 關閉 "X"、"OK" 按鈕
                {
                    i.Enabled = false;
                }
            }
            else // 沒有贏的情況
            {
                foreach(Button i in screen) // 螢幕清空
                {
                    i.Text = "";
                }
                foreach(Button i in numric) // 把所有數字按鈕開啟
                {
                    i.Enabled = true;
                }
                counter = 0; // 計數器歸零
            }
        } // 確認使否為贏
    }
}
