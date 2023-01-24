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
    public partial class 랜덤넘버발생 : Form
    {
        List<int> data = new List<int>(); //난수들을 저장할 리스트(문제용)
        List<int> data2 = new List<int>();//난수들을 저장할 리스트(문제용,중복제거)
        List<int> data3 = new List<int>(); //난수들을 저장할 리스트(보기용)
        List<int> data4 = new List<int>();//난수들을 저장할 리스트(보기용,중복제거)
        Random rand = new Random(); //난수발생
        public 랜덤넘버발생()
        {
            InitializeComponent();            
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            //버튼을 중복으로 누를때를 위해 모든 리스트와 라벨 텍스트 초기화
            data.Clear();
            data2.Clear();
            data3.Clear();
            data4.Clear();
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

            //랜덤 문제 발생
            while (true) //중복을 제거한 리스트의 크기가 3(문제의 갯수)가 될때까지 무한 반복
            {             
                int a = rand.Next(0, 5); //0~4까지의 숫자
                data.Add(a);
                data2 = data.Distinct().ToList();
                if (data2.Count == 3)
                    break;
            }

            //랜덤 보기 발생
            while (true) //중복을 제거한 리스트의 크기가 4(보기의 갯수)가 될때까지 무한 반복
            {               
                int a = rand.Next(0, 4); //0~3까지의 숫자
                data3.Add(a);
                data4 = data3.Distinct().ToList();
                if (data4.Count == 4)
                    break;
            }

            for (int i = 0; i < data.Count; i++) {
                label5.Text += data[i] + " ";             
            }
            for (int i = 0; i < data2.Count; i++)
            {
                label6.Text += data2[i] + " ";                
            }
            for (int i = 0; i < data3.Count; i++)
            {
                label7.Text += data3[i] + " ";
            }
            for (int i = 0; i < data4.Count; i++)
            {
                label8.Text += data4[i] + " ";
            }            
        }
        
    }
}
