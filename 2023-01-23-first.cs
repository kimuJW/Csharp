using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch12_객체동적생성
{
    public partial class 랜덤시험문제 : Form
    {
        GroupBox[] GB = new GroupBox[3];//랜덤문제 3개를 저장할 배열
        RadioButton[,] Bogi = new RadioButton[3, 5];//각 문제에 대한 보기들의 배열
        Label IbScore = new Label(); //점수가 출력될 라벨
        Button button = new Button(); //채점하기 버튼
        int Score = 0; //초기 점수는 0점
        List<int> data = new List<int>(); //난수들을 저장할 리스트(문제용)
        List<int> data2 = new List<int>();//난수들을 저장할 리스트(문제용,중복제거)
        List<int> data3 = new List<int>(); //난수들을 저장할 리스트(보기용)
        List<int> data4 = new List<int>();//난수들을 저장할 리스트(보기용,중복제거)
        PictureBox TV_Image = new PictureBox(); //TV 이미지를 넣을 픽쳐박스
        List<Bitmap> ImageList = new List<Bitmap>();//에스파 문제의 이미지들을 저장할 리스트
        Random rand = new Random();// rand 객체 생성
           
        public 랜덤시험문제()
        {
            InitializeComponent();
            string aa = "[문제";
            string[,] Question = new string[5, 6]
            {
                {"10+10 = ?", "이십","삼십","사십","오십","이십"},
                {"해당 프로젝트를 작성할 때 쓰인 언어는?", "C","C++","C#","JAVA","C#"},
                {"올해의 년도는?", "2018","2019","2020","2021","2021"},
                {"다음중 에스파 멤버가 아닌 사람은?", "카리나","윈터","지젤","아이유","아이유"},
                {"해당 사진 속 가전 제품은 무엇인가?","선풍기","에어컨","TV","냉장고","TV" }
            };

            TV_Image.Image = Properties.Resources.TV; //픽쳐박스에 TV이미지 삽입
            TV_Image.SizeMode = PictureBoxSizeMode.StretchImage; //이미지가 안짤리게 펴줌

            //에스파 문제에 사용될 이미지들을 리스트에 넣어줌
            ImageList.Add(Properties.Resources.아이유); //여기서 아이유 사진을 처음에 넣어준 이유는 사용하기 위함이 아니라 인덱스 번호를 맞추기 위함임
            ImageList.Add(Properties.Resources.카리나); //1
            ImageList.Add(Properties.Resources.윈터); //2
            ImageList.Add(Properties.Resources.지젤); //3
            ImageList.Add(Properties.Resources.아이유);//4(정답)
            
            //각 이미지 사이즈를 조절해서 다시 넣어줌
            for (int i = 0; i < ImageList.Count; i++) {
                int width = 130;
                int height = 130;
                Size resize = new Size(width, height);
                Bitmap resizeimage = new Bitmap(ImageList[i], resize);
                ImageList[i] = resizeimage;
            }
           
            //랜덤 문제 발생
            while (true) //중복을 제거한 리스트의 크기가 3(문제의 갯수)이 될때까지 무한 반복
            {                           
                int a = rand.Next(0, 5);
                data.Add(a);                 
                data2 = data.Distinct().ToList(); //data2 리스트에는 중복없이 0~4까지의 숫자가 3개 들어감
                if (data2.Count == 3)
                    break;               
            }
                 
            //랜덤 보기 발생
            while (true) //중복을 제거한 리스트의 크기가 4(보기의 갯수)가 될때까지 무한 반복
            {             
                int a = rand.Next(1, 5);
                data3.Add(a);                
                data4 = data3.Distinct().ToList(); //data4 리스트에는 중복없이 1~4까지의 숫자가 4개 들어감
                if (data4.Count == 4)
                    break;
            }
                       
            //문제랑 보기 설정
            for (int n = 0; n < 3; n++) //문제 넣기
            {
                GB[n] = new GroupBox();
                this.GB[n].AutoSize = true;
                if (n == 1) //문제 2번을 넣을 때
                {              
                    if (GB[n - 1].Text.Contains("에스파")) //1번 문제가 에스파 문제였으면 그룹박스 크기를 고려하여 2번 그룹박스의 위치 수정
                    {
                        this.GB[n].Location = new Point(10, 210 + (n * 130));
                    }
                    else //1번 문제가 에스파 문제가 아니었으므로 정상적으로 위치 선정
                        this.GB[n].Location = new Point(10, 10 + (n * 160));
                }
                else if (n == 2) //문제 3번을 넣을 때
                {                
                    if (GB[n - 1].Text.Contains("에스파")) //2번 문제가 에스파 문제였으면 그룹박스 크기를 고려하여 3번 그룹박스의 위치 수정
                    {
                        this.GB[n].Location = new Point(10, 180 + (n * 160));
                    }
                    else if (GB[n - 2].Text.Contains("에스파")) //1번 문제가 에스파 문제였으면 그룹박스 크기를 고려하여 3번 그룹박스의 위치 수정
                    {
                        this.GB[n].Location = new Point(10, 180 + (n * 160));
                    }
                    else //1,2번 문제가 에스파 문제가 아니었으므로 정상적으로 위치 선정
                        this.GB[n].Location = new Point(10, 10 + (n * 160));
                }
                else //에스파 문제가 선정되지 않았다면 전부 정상적으로 위치 선정
                    this.GB[n].Location = new Point(10, 10 + (n * 160));

                this.GB[n].Size = new Size(300, 120);    //그룹박스 사이즈 설정       
                this.GB[n].TabIndex = 0;
                this.GB[n].TabStop = false;
                this.GB[n].Text = aa + (n + 1) + "]  " + Question[data2[n], 0];                
                this.Controls.Add(GB[n]);
                if (GB[n].Text.Contains("가전"))
                {                                  
                    this.TV_Image.Size = new Size(100, 100); //TV 이미지의 크기 설정
                    this.TV_Image.TabIndex = 0;
                    this.TV_Image.TabStop = false;                                     
                    this.TV_Image.Top = ((this.GB[n].Height - TV_Image.Height) + 20) / 2; // 그룹박스에 넣을 픽쳐박스의 세로 위치 설정
                    this.TV_Image.Left = ((this.GB[n].Width - TV_Image.Width) + 20) / 8; //그룹박스에 넣을 픽쳐박스의 가로 위치 설정
                    this.GB[n].Controls.Add(TV_Image); //TV 이미지가 담긴 픽쳐박스를 그룹박스에 부착
                }
                            
                    for (int i = 0; i < 5; i++)//보기 넣기
                {
                    Bogi[n, i] = new RadioButton();
                    this.Bogi[n, i].AutoSize = true;
                    if (GB[n].Text.Contains("가전")) //가전 제품 문제가 나왔을 경우
                    {
                        this.Bogi[n, i].Location = new Point(150, 40 + (i * 20)); //보기의 위치를 오른쪽으로 밀어줌(이미지와 겹치기 때문에)
                        if (i == 4) //보기 5번은 정답의 value(TV)를 넣어두고 숨겨둠
                        {
                            this.Bogi[n, i].Text = Question[data2[n], 5];                            
                            Bogi[n, 4].Visible = false;
                        }
                        else                        
                            this.Bogi[n, i].Text = Question[data2[n], data4[i]];  //보기 1~4번에 텍스트를 설정
                    }

                    else if (GB[n].Text.Contains("에스파")) //에스파 문제가 나왔을 경우
                    {                                               
                        //보기의 위치를 재설정
                        if (i > 1)
                        {
                            this.Bogi[n, i].Location = new Point(230, 30 + ((i-2) * 120));
                        }
                        else
                        {
                            this.Bogi[n, i].Location = new Point(30, 30 + (i * 120));
                        }
                        if (i == 4) //보기 5번은 정답의 value(공백 4개)를 넣어두고 숨겨둠
                        {
                            this.Bogi[n, i].Image = ImageList[i];
                            this.Bogi[n, i].Text = "    ";
                            Bogi[n, 4].Visible = false;
                        }
                        else // 보기 1~4번에 이미지를 부착
                            this.Bogi[n, i].Image = ImageList[data4[i]]; 
                        
                        if (Bogi[n, i].Image.Equals(ImageList[4])) //만약 해당 보기의 이미지가 정답(아이유)이라면 정답의 value(공백 4개)를 넣어줌
                        {
                            this.Bogi[n, i].Text = "    ";
                        }
                    }

                    else //가전제품, 에스파 문제를 제외한 나머지 문제에 해당
                    {
                        if (i == 4)
                        {
                            this.Bogi[n, i].Location = new Point(30, 60 + (i * 20));                  
                            this.Bogi[n, i].Text = Question[data2[n], 5];
                            Bogi[n, 4].Visible = false;
                        }
                        else
                        {
                            this.Bogi[n, i].Location = new Point(30, 30 + (i * 20));                     
                            this.Bogi[n, i].Text = Question[data2[n], data4[i]];
                        }
                    }                    
                    this.GB[n].Controls.Add(this.Bogi[n, i]);
                }
            }

            //점수판
            this.IbScore.Name = "IbScore";
            this.IbScore.Text = "Score";
            this.IbScore.Size = new Size(90, 30);
            this.IbScore.Location = new Point(30, 510);
            //채점하기 버튼
            this.button.Name = "btnSubmit";
            this.button.Text = "채점하기";
            this.button.Size = new Size(90, 30);
            this.button.Location = new Point(130, 500);
            this.button.AutoSize = true;
            this.button.Click += new EventHandler(button_Click);
            this.Size = new Size(350, 580);
            //에스파 문제가 있을 경우 버튼과 라벨의 위치 조정, 폼 사이즈 조절
            for (int i = 0; i < 3; i++) {
                if (GB[i].Text.Contains("에스파"))
                {
                 this.IbScore.Location = new Point(30, 660);
                 this.button.Location = new Point(130, 650);
                 this.Size = new Size(420, 750);
                }                
            }                      
            this.Controls.Add(button); //채점하기 버튼 부착
            this.Controls.Add(IbScore); //점수판 부착

            //채점하기 버튼을 눌렀을 때 이벤트
            void button_Click(object sender, EventArgs e)
            {
                Button button = sender as Button;  //버튼 객체 생성           
                Score = 0; //버튼을 여러번 누를시 점수 중복가산 방지
                for (int n = 0; n < 3; n++)  // 문제수 for 문
                {
                    for (int i = 0; i < 4; i++) // 보기수 for 문
                    {
                        if (Bogi[n, i].Text.Equals(Bogi[n, 4].Text)) //답이 맞으면 점수 1점 추가(Text로 정답 구분)
                        {
                            if (Bogi[n, i].Checked)
                            {
                                Score++;
                            }
                        }                        
                    }
                }
                IbScore.Text = "Score : " + Convert.ToString(Score);
            }
        }       
    }
}